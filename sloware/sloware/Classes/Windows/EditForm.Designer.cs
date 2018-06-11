namespace sloware.Classes.Windows
{
    partial class EditForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLineNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveExample = new System.Windows.Forms.Button();
            this.buttonRemoveTranslation = new System.Windows.Forms.Button();
            this.comboBoxLanguage2 = new System.Windows.Forms.ComboBox();
            this.buttonAddExample = new System.Windows.Forms.Button();
            this.buttonAddTranslation = new System.Windows.Forms.Button();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage1 = new System.Windows.Forms.ComboBox();
            this.textBoxExampleTranslation = new System.Windows.Forms.TextBox();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.listBoxTranslations = new System.Windows.Forms.ListBox();
            this.textBoxExamples = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(447, 345);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(528, 345);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxLineNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxWord);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRemoveExample);
            this.panel1.Controls.Add(this.buttonRemoveTranslation);
            this.panel1.Controls.Add(this.comboBoxLanguage2);
            this.panel1.Controls.Add(this.buttonAddExample);
            this.panel1.Controls.Add(this.buttonAddTranslation);
            this.panel1.Controls.Add(this.textBoxExample);
            this.panel1.Controls.Add(this.comboBoxLanguage1);
            this.panel1.Controls.Add(this.textBoxExampleTranslation);
            this.panel1.Controls.Add(this.textBoxTranslation);
            this.panel1.Controls.Add(this.listBoxTranslations);
            this.panel1.Controls.Add(this.textBoxExamples);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(606, 371);
            this.panel1.MinimumSize = new System.Drawing.Size(606, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 371);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxLineNumber
            // 
            this.comboBoxLineNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLineNumber.FormattingEnabled = true;
            this.comboBoxLineNumber.Location = new System.Drawing.Point(363, 322);
            this.comboBoxLineNumber.Name = "comboBoxLineNumber";
            this.comboBoxLineNumber.Size = new System.Drawing.Size(33, 21);
            this.comboBoxLineNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Word:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(45, 3);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(151, 20);
            this.textBoxWord.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Language:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Example translation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Example:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Translation:";
            // 
            // buttonRemoveExample
            // 
            this.buttonRemoveExample.Location = new System.Drawing.Point(402, 319);
            this.buttonRemoveExample.Name = "buttonRemoveExample";
            this.buttonRemoveExample.Size = new System.Drawing.Size(98, 23);
            this.buttonRemoveExample.TabIndex = 14;
            this.buttonRemoveExample.Text = "Remove example";
            this.buttonRemoveExample.UseVisualStyleBackColor = true;
            this.buttonRemoveExample.Click += new System.EventHandler(this.buttonRemoveExample_Click);
            // 
            // buttonRemoveTranslation
            // 
            this.buttonRemoveTranslation.Location = new System.Drawing.Point(3, 319);
            this.buttonRemoveTranslation.Name = "buttonRemoveTranslation";
            this.buttonRemoveTranslation.Size = new System.Drawing.Size(107, 23);
            this.buttonRemoveTranslation.TabIndex = 13;
            this.buttonRemoveTranslation.Text = "Remove translation";
            this.buttonRemoveTranslation.UseVisualStyleBackColor = true;
            this.buttonRemoveTranslation.Click += new System.EventHandler(this.buttonRemoveTranslation_Click);
            // 
            // comboBoxLanguage2
            // 
            this.comboBoxLanguage2.FormattingEnabled = true;
            this.comboBoxLanguage2.Items.AddRange(new object[] {
            "Polish",
            "English",
            "German",
            "Russian",
            "Ukrainian"});
            this.comboBoxLanguage2.Location = new System.Drawing.Point(263, 322);
            this.comboBoxLanguage2.Name = "comboBoxLanguage2";
            this.comboBoxLanguage2.Size = new System.Drawing.Size(91, 21);
            this.comboBoxLanguage2.TabIndex = 12;
            // 
            // buttonAddExample
            // 
            this.buttonAddExample.Location = new System.Drawing.Point(506, 318);
            this.buttonAddExample.Name = "buttonAddExample";
            this.buttonAddExample.Size = new System.Drawing.Size(97, 23);
            this.buttonAddExample.TabIndex = 11;
            this.buttonAddExample.Text = "Add example";
            this.buttonAddExample.UseVisualStyleBackColor = true;
            this.buttonAddExample.Click += new System.EventHandler(this.buttonAddExample_Click);
            // 
            // buttonAddTranslation
            // 
            this.buttonAddTranslation.Location = new System.Drawing.Point(110, 319);
            this.buttonAddTranslation.Name = "buttonAddTranslation";
            this.buttonAddTranslation.Size = new System.Drawing.Size(86, 23);
            this.buttonAddTranslation.TabIndex = 10;
            this.buttonAddTranslation.Text = "Add translation";
            this.buttonAddTranslation.UseVisualStyleBackColor = true;
            this.buttonAddTranslation.Click += new System.EventHandler(this.buttonAddTranslation_Click);
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(202, 293);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(194, 20);
            this.textBoxExample.TabIndex = 9;
            // 
            // comboBoxLanguage1
            // 
            this.comboBoxLanguage1.FormattingEnabled = true;
            this.comboBoxLanguage1.Items.AddRange(new object[] {
            "Polish",
            "English",
            "German",
            "Russian",
            "Ukrainian"});
            this.comboBoxLanguage1.Location = new System.Drawing.Point(110, 292);
            this.comboBoxLanguage1.Name = "comboBoxLanguage1";
            this.comboBoxLanguage1.Size = new System.Drawing.Size(86, 21);
            this.comboBoxLanguage1.TabIndex = 8;
            // 
            // textBoxExampleTranslation
            // 
            this.textBoxExampleTranslation.Location = new System.Drawing.Point(402, 293);
            this.textBoxExampleTranslation.Name = "textBoxExampleTranslation";
            this.textBoxExampleTranslation.Size = new System.Drawing.Size(201, 20);
            this.textBoxExampleTranslation.TabIndex = 7;
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Location = new System.Drawing.Point(3, 292);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(101, 20);
            this.textBoxTranslation.TabIndex = 5;
            // 
            // listBoxTranslations
            // 
            this.listBoxTranslations.FormattingEnabled = true;
            this.listBoxTranslations.Location = new System.Drawing.Point(3, 29);
            this.listBoxTranslations.Name = "listBoxTranslations";
            this.listBoxTranslations.Size = new System.Drawing.Size(193, 238);
            this.listBoxTranslations.TabIndex = 4;
            // 
            // textBoxExamples
            // 
            this.textBoxExamples.Location = new System.Drawing.Point(202, 3);
            this.textBoxExamples.Multiline = true;
            this.textBoxExamples.Name = "textBoxExamples";
            this.textBoxExamples.ReadOnly = true;
            this.textBoxExamples.Size = new System.Drawing.Size(401, 264);
            this.textBoxExamples.TabIndex = 2;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 371);
            this.Controls.Add(this.panel1);
            this.Name = "EditForm";
            this.Text = "Add new word";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveExample;
        private System.Windows.Forms.Button buttonRemoveTranslation;
        private System.Windows.Forms.ComboBox comboBoxLanguage2;
        private System.Windows.Forms.Button buttonAddExample;
        private System.Windows.Forms.Button buttonAddTranslation;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.ComboBox comboBoxLanguage1;
        private System.Windows.Forms.TextBox textBoxExampleTranslation;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.ListBox listBoxTranslations;
        private System.Windows.Forms.TextBox textBoxExamples;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.ComboBox comboBoxLineNumber;
    }
}