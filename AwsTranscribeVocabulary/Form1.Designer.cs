
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxWords = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(139, 21);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(431, 27);
            this.TextBox.TabIndex = 0;
            // 
            // comboBoxBucket
            // 
            this.comboBoxBucket.BackColor = System.Drawing.Color.White;
            this.comboBoxBucket.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBucket.FormattingEnabled = true;
            this.comboBoxBucket.Location = new System.Drawing.Point(139, 69);
            this.comboBoxBucket.Name = "comboBoxBucket";
            this.comboBoxBucket.Size = new System.Drawing.Size(431, 28);
            this.comboBoxBucket.TabIndex = 1;
            // 
            // BtSearch
            // 
            this.BtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtSearch.FlatAppearance.BorderSize = 0;
            this.BtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.BtSearch.Location = new System.Drawing.Point(576, 21);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(89, 27);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "Abrir";
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // BtJob
            // 
            this.BtJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BtJob.FlatAppearance.BorderSize = 0;
            this.BtJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtJob.ForeColor = System.Drawing.Color.LightGray;
            this.BtJob.Location = new System.Drawing.Point(475, 449);
            this.BtJob.Name = "BtJob";
            this.BtJob.Size = new System.Drawing.Size(173, 57);
            this.BtJob.TabIndex = 3;
            this.BtJob.Text = "Upload do arquivo";
            this.BtJob.UseVisualStyleBackColor = false;
            this.BtJob.Click += new System.EventHandler(this.BtJob_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBoxWords
            // 
            this.richTextBoxWords.BackColor = System.Drawing.Color.White;
            this.richTextBoxWords.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxWords.Location = new System.Drawing.Point(15, 163);
            this.richTextBoxWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxWords.Name = "richTextBoxWords";
            this.richTextBoxWords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxWords.Size = new System.Drawing.Size(431, 343);
            this.richTextBoxWords.TabIndex = 5;
            this.richTextBoxWords.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha as palavras que vão ser cencuradas:  (as palavras devem ser separadas por" +
    " um \"enter\")";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escolher arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escolher bucket:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(692, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxWords);
            this.Controls.Add(this.BtJob);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.comboBoxBucket);
            this.Controls.Add(this.TextBox);
            this.Name = "FormMain";
            this.Text = "VocabularyFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button BtJob;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.ComboBox comboBoxBucket;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox richTextBoxWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

