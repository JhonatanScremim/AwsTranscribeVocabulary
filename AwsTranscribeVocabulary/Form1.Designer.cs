
namespace AwsTranscribeVocabulary
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.comboBoxBucket = new System.Windows.Forms.ComboBox();
            this.BtSearch = new System.Windows.Forms.Button();
            this.BtJob = new System.Windows.Forms.Button();
            this.BtVocabularyFilter = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(98, 39);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(432, 27);
            this.TextBox.TabIndex = 0;
            // 
            // comboBoxBucket
            // 
            this.comboBoxBucket.FormattingEnabled = true;
            this.comboBoxBucket.Location = new System.Drawing.Point(98, 93);
            this.comboBoxBucket.Name = "comboBoxBucket";
            this.comboBoxBucket.Size = new System.Drawing.Size(293, 28);
            this.comboBoxBucket.TabIndex = 1;
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(545, 37);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(94, 29);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "BtSearch";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // BtJob
            // 
            this.BtJob.Location = new System.Drawing.Point(436, 93);
            this.BtJob.Name = "BtJob";
            this.BtJob.Size = new System.Drawing.Size(94, 29);
            this.BtJob.TabIndex = 3;
            this.BtJob.Text = "BtJob";
            this.BtJob.UseVisualStyleBackColor = true;
            this.BtJob.Click += new System.EventHandler(this.BtJob_Click);
            // 
            // BtVocabularyFilter
            // 
            this.BtVocabularyFilter.Location = new System.Drawing.Point(98, 161);
            this.BtVocabularyFilter.Name = "BtVocabularyFilter";
            this.BtVocabularyFilter.Size = new System.Drawing.Size(94, 29);
            this.BtVocabularyFilter.TabIndex = 4;
            this.BtVocabularyFilter.Text = "BtVocabularyFilter";
            this.BtVocabularyFilter.UseVisualStyleBackColor = true;
            this.BtVocabularyFilter.Click += new System.EventHandler(this.BtVocabularyFilter_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.BtVocabularyFilter);
            this.Controls.Add(this.BtJob);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.comboBoxBucket);
            this.Controls.Add(this.TextBox);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button BtVocabularyFilter;
        private System.Windows.Forms.Button BtJob;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.ComboBox comboBoxBucket;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

