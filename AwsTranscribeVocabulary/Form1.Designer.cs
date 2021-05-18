
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
            this.richTextBoxWords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(13, 12);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(378, 23);
            this.TextBox.TabIndex = 0;
            // 
            // comboBoxBucket
            // 
            this.comboBoxBucket.BackColor = System.Drawing.Color.White;
            this.comboBoxBucket.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBucket.FormattingEnabled = true;
            this.comboBoxBucket.Location = new System.Drawing.Point(13, 53);
            this.comboBoxBucket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBucket.Name = "comboBoxBucket";
            this.comboBoxBucket.Size = new System.Drawing.Size(378, 23);
            this.comboBoxBucket.TabIndex = 1;
            // 
            // BtSearch
            // 
            this.BtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtSearch.FlatAppearance.BorderSize = 0;
            this.BtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.BtSearch.Location = new System.Drawing.Point(404, 11);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(82, 27);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "Open File";
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // BtJob
            // 
            this.BtJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtJob.FlatAppearance.BorderSize = 0;
            this.BtJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtJob.ForeColor = System.Drawing.Color.LightGray;
            this.BtJob.Location = new System.Drawing.Point(404, 50);
            this.BtJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtJob.Name = "BtJob";
            this.BtJob.Size = new System.Drawing.Size(82, 27);
            this.BtJob.TabIndex = 3;
            this.BtJob.Text = "Upload File";
            this.BtJob.UseVisualStyleBackColor = false;
            this.BtJob.Click += new System.EventHandler(this.BtJob_Click);
            // 
            // BtVocabularyFilter
            // 
            this.BtVocabularyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtVocabularyFilter.FlatAppearance.BorderSize = 0;
            this.BtVocabularyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVocabularyFilter.ForeColor = System.Drawing.Color.LightGray;
            this.BtVocabularyFilter.Location = new System.Drawing.Point(404, 90);
            this.BtVocabularyFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtVocabularyFilter.Name = "BtVocabularyFilter";
            this.BtVocabularyFilter.Size = new System.Drawing.Size(82, 27);
            this.BtVocabularyFilter.TabIndex = 4;
            this.BtVocabularyFilter.Text = "Filter Results";
            this.BtVocabularyFilter.UseVisualStyleBackColor = false;
            this.BtVocabularyFilter.Click += new System.EventHandler(this.BtVocabularyFilter_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBoxWords
            // 
            this.richTextBoxWords.BackColor = System.Drawing.Color.White;
            this.richTextBoxWords.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxWords.Location = new System.Drawing.Point(13, 93);
            this.richTextBoxWords.Name = "richTextBoxWords";
            this.richTextBoxWords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxWords.Size = new System.Drawing.Size(378, 294);
            this.richTextBoxWords.TabIndex = 5;
            this.richTextBoxWords.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(504, 399);
            this.Controls.Add(this.richTextBoxWords);
            this.Controls.Add(this.BtVocabularyFilter);
            this.Controls.Add(this.BtJob);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.comboBoxBucket);
            this.Controls.Add(this.TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox richTextBoxWords;
    }
}

