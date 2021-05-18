using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.TranscribeService;
using Amazon.TranscribeService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsTranscribeVocabulary
{
    public partial class FormMain : Form
    {
        string credentialName = "AWS Educate";
        AWSCredentials credentials;
        private static readonly RegionEndpoint region = RegionEndpoint.USEast1;
        private string vocabularyFilter;
        AmazonS3Client client;
        public FormMain()
        {
            InitializeComponent();
            comboBoxBucket.Items.Clear();
            var listBuckets = S3ListBuckets();
            foreach (var item in listBuckets)
            {
                comboBoxBucket.Items.Add(item);
            }
        }

        private void GetCredentials()
        {
            var chain = new CredentialProfileStoreChain();
            if (!chain.TryGetAWSCredentials(credentialName, out credentials))
            {
                MessageBox.Show("Erro ao pegar credencial");
            }
        }

        private void S3Client()
        {
            GetCredentials();
            client = new AmazonS3Client(credentials, region);
        }

        private List<string> S3ListBuckets()
        {
            var buckets = new List<string>();
            S3Client();
            ListBucketsResponse listBuckets = (client.ListBucketsAsync()).Result;
            foreach (S3Bucket i in listBuckets.Buckets)
            {
                buckets.Add(i.BucketName);
            }
            return buckets;
        }

        private async Task<bool> UpLoadToS3(string file)
        {
            GetCredentials();
            try
            {
                var s3Client = new AmazonS3Client(credentials, region);
                var fileTransferUtility = new TransferUtility(s3Client);
                await fileTransferUtility.UploadAsync(file, comboBoxBucket.SelectedItem.ToString());
                return true;
            }
            catch (AmazonS3Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}");
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}");
                return false;
            }
        }

        private async Task ExecuteTranscribeAsync()
        {
            AmazonTranscribeServiceClient transcribeServiceClient = new AmazonTranscribeServiceClient(credentials, region);
            string jobName = $"Trascribe-Reuniao-{DateTime.Now.ToString("yyyymmddhhmmss")}";
            StartTranscriptionJobRequest jobRequest = new StartTranscriptionJobRequest
            {
                Media = new Media { MediaFileUri = "s3://" + "my-transcribe-bucket-input/" + Path.GetFileName(openFileDialog.FileName) },
                OutputBucketName = comboBoxBucket.SelectedItem.ToString(),
                LanguageCode = LanguageCode.PtBR,
                MediaFormat = MediaFormat.Mp4,
                TranscriptionJobName = jobName,
                Settings = new Settings()
                {
                    VocabularyFilterName = vocabularyFilter
                }
            };

            await transcribeServiceClient.StartTranscriptionJobAsync(jobRequest);
        }

        private async Task ExecuteVocabularyFilter(List<string> words)
        {
            var client = new AmazonTranscribeServiceClient(credentials, region);
            string vocabularyFilterName = $"my-audio-bucket-001-{DateTime.Now.ToString("yyyymmddhhmmss")}";
            var createVocabularyFilter = new CreateVocabularyFilterRequest()
            {
                LanguageCode = LanguageCode.PtBR,
                VocabularyFilterName = vocabularyFilterName,
                Words = words
            };

            await client.CreateVocabularyFilterAsync(createVocabularyFilter);

            var getRequest = new GetVocabularyFilterRequest()
            {
                VocabularyFilterName = vocabularyFilterName
            };

            var data = await client.GetVocabularyFilterAsync(getRequest);

            vocabularyFilter = data.VocabularyFilterName;
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            TextBox.Text = openFileDialog.FileName;
        }

        private async void BtJob_Click(object sender, EventArgs e)
        {
            var words = GetWords();
            await ExecuteVocabularyFilter(words);
            await UpLoadToS3(openFileDialog.FileName);
            await ExecuteTranscribeAsync();
        }

        private List<string> GetWords()
        {
            string allWords = richTextBoxWords.Text.ToString();
            string[] arrayWords = allWords.Split("\n");
            
            List<string> words = new List<string>();
            foreach (string singleWord in arrayWords)
            {
                words.Add(singleWord);
            }

            return words;
        }
    }
}
