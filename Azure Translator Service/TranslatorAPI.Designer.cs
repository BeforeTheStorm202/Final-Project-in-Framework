namespace Azure_Translator_Service
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
            this.view = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lang2 = new System.Windows.Forms.ComboBox();
            this.lang1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWord = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(1043, 184);
            this.view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(426, 432);
            this.view.TabIndex = 28;
            this.view.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Your input";
            // 
            // lang2
            // 
            this.lang2.FormattingEnabled = true;
            this.lang2.Items.AddRange(new object[] {
            "Vietnamese",
            "English"});
            this.lang2.Location = new System.Drawing.Point(805, 151);
            this.lang2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang2.Name = "lang2";
            this.lang2.Size = new System.Drawing.Size(198, 26);
            this.lang2.TabIndex = 26;
            // 
            // lang1
            // 
            this.lang1.FormattingEnabled = true;
            this.lang1.Items.AddRange(new object[] {
            "English",
            "Vietnamese",
            "Detect language"});
            this.lang1.Location = new System.Drawing.Point(212, 151);
            this.lang1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lang1.Name = "lang1";
            this.lang1.Size = new System.Drawing.Size(228, 26);
            this.lang1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Translation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1039, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Examples";
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(490, 400);
            this.btnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(113, 109);
            this.btnText.TabIndex = 22;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Synonyms/Other type";
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(646, 434);
            this.output2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(357, 182);
            this.output2.TabIndex = 20;
            this.output2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "MS Azure API";
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(490, 244);
            this.btnWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(113, 116);
            this.btnWord.TabIndex = 18;
            this.btnWord.Text = "Word Lookup";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(646, 184);
            this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(357, 175);
            this.output.TabIndex = 17;
            this.output.Text = "";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(85, 184);
            this.input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(356, 432);
            this.input.TabIndex = 16;
            this.input.Text = "";
            // 
            // TranslatorAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 722);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lang2);
            this.Controls.Add(this.lang1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TranslatorAPI";
            this.Text = "Your Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lang2;
        private System.Windows.Forms.ComboBox lang1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox output2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RichTextBox input;
    }
}

