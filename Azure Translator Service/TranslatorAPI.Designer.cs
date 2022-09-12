namespace TranslatorAPI
{
    partial class TranslatorAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.output2 = new System.Windows.Forms.RichTextBox();
            this.view = new System.Windows.Forms.RichTextBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.btnExamples = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.lang1 = new System.Windows.Forms.ComboBox();
            this.lang2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(85, 131);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(236, 330);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(435, 131);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(193, 151);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(435, 324);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(193, 137);
            this.output2.TabIndex = 2;
            this.output2.Text = "";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(727, 131);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(237, 330);
            this.view.TabIndex = 3;
            this.view.Text = "";
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(342, 238);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 4;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Location = new System.Drawing.Point(342, 306);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(75, 23);
            this.btnSpeech.TabIndex = 5;
            this.btnSpeech.Text = "Speech";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // btnExamples
            // 
            this.btnExamples.Location = new System.Drawing.Point(342, 371);
            this.btnExamples.Name = "btnExamples";
            this.btnExamples.Size = new System.Drawing.Size(75, 23);
            this.btnExamples.TabIndex = 6;
            this.btnExamples.Text = "Example";
            this.btnExamples.UseVisualStyleBackColor = true;
            this.btnExamples.Click += new System.EventHandler(this.btnExamples_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(342, 178);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 7;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // lang1
            // 
            this.lang1.FormattingEnabled = true;
            this.lang1.Items.AddRange(new object[] {
            "English",
            "Vietnamese",
            "Detect language"});
            this.lang1.Location = new System.Drawing.Point(85, 101);
            this.lang1.Name = "lang1";
            this.lang1.Size = new System.Drawing.Size(121, 24);
            this.lang1.TabIndex = 8;
            // 
            // lang2
            // 
            this.lang2.FormattingEnabled = true;
            this.lang2.Items.AddRange(new object[] {
            "English",
            "Vietnamese"});
            this.lang2.Location = new System.Drawing.Point(435, 101);
            this.lang2.Name = "lang2";
            this.lang2.Size = new System.Drawing.Size(121, 24);
            this.lang2.TabIndex = 9;
            // 
            // TranslatorAPI
            // 
            this.ClientSize = new System.Drawing.Size(1033, 526);
            this.Controls.Add(this.lang2);
            this.Controls.Add(this.lang1);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnExamples);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.view);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Name = "TranslatorAPI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TranslatorAPI_FormClosed);
            this.Load += new System.EventHandler(this.TranslatorAPI_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RichTextBox output2;
        private System.Windows.Forms.RichTextBox view;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.Button btnExamples;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.ComboBox lang1;
        private System.Windows.Forms.ComboBox lang2;
    }
}

