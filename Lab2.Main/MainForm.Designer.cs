namespace Lab2.Main
{
    partial class MainForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentGraduatedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.secondNameTextbox = new System.Windows.Forms.TextBox();
            this.numberEnteredFirstNumeric = new System.Windows.Forms.NumericUpDown();
            this.numberEnteredSecondNumeric = new System.Windows.Forms.NumericUpDown();
            this.numberGraduatedFirstNumeric = new System.Windows.Forms.NumericUpDown();
            this.numberGraduatedSecondNumeric = new System.Windows.Forms.NumericUpDown();
            this.percentGraduatedNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberEnteredFirstNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEnteredSecondNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGraduatedFirstNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGraduatedSecondNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentGraduatedNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 332);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(900, 352);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название высшего учебного заведения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество выпустившихся\r\n";
            // 
            // percentGraduatedLabel
            // 
            this.percentGraduatedLabel.AutoSize = true;
            this.percentGraduatedLabel.Location = new System.Drawing.Point(492, 223);
            this.percentGraduatedLabel.Name = "percentGraduatedLabel";
            this.percentGraduatedLabel.Size = new System.Drawing.Size(410, 20);
            this.percentGraduatedLabel.TabIndex = 5;
            this.percentGraduatedLabel.Text = "Процент выпустившихся, работающих по специальности\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество поступивших";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество выпустившихся\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество поступивших";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Название высшего учебного заведения";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(23, 48);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(421, 27);
            this.firstNameTextbox.TabIndex = 10;
            // 
            // secondNameTextbox
            // 
            this.secondNameTextbox.Location = new System.Drawing.Point(491, 47);
            this.secondNameTextbox.Name = "secondNameTextbox";
            this.secondNameTextbox.Size = new System.Drawing.Size(421, 27);
            this.secondNameTextbox.TabIndex = 11;
            // 
            // numberEnteredFirstNumeric
            // 
            this.numberEnteredFirstNumeric.InterceptArrowKeys = false;
            this.numberEnteredFirstNumeric.Location = new System.Drawing.Point(23, 107);
            this.numberEnteredFirstNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberEnteredFirstNumeric.Name = "numberEnteredFirstNumeric";
            this.numberEnteredFirstNumeric.Size = new System.Drawing.Size(150, 27);
            this.numberEnteredFirstNumeric.TabIndex = 12;
            this.numberEnteredFirstNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberEnteredSecondNumeric
            // 
            this.numberEnteredSecondNumeric.InterceptArrowKeys = false;
            this.numberEnteredSecondNumeric.Location = new System.Drawing.Point(494, 107);
            this.numberEnteredSecondNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberEnteredSecondNumeric.Name = "numberEnteredSecondNumeric";
            this.numberEnteredSecondNumeric.Size = new System.Drawing.Size(150, 27);
            this.numberEnteredSecondNumeric.TabIndex = 13;
            this.numberEnteredSecondNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberGraduatedFirstNumeric
            // 
            this.numberGraduatedFirstNumeric.InterceptArrowKeys = false;
            this.numberGraduatedFirstNumeric.Location = new System.Drawing.Point(23, 175);
            this.numberGraduatedFirstNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberGraduatedFirstNumeric.Name = "numberGraduatedFirstNumeric";
            this.numberGraduatedFirstNumeric.Size = new System.Drawing.Size(150, 27);
            this.numberGraduatedFirstNumeric.TabIndex = 14;
            this.numberGraduatedFirstNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberGraduatedSecondNumeric
            // 
            this.numberGraduatedSecondNumeric.InterceptArrowKeys = false;
            this.numberGraduatedSecondNumeric.Location = new System.Drawing.Point(494, 175);
            this.numberGraduatedSecondNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberGraduatedSecondNumeric.Name = "numberGraduatedSecondNumeric";
            this.numberGraduatedSecondNumeric.Size = new System.Drawing.Size(150, 27);
            this.numberGraduatedSecondNumeric.TabIndex = 15;
            this.numberGraduatedSecondNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // percentGraduatedNumeric
            // 
            this.percentGraduatedNumeric.InterceptArrowKeys = false;
            this.percentGraduatedNumeric.Location = new System.Drawing.Point(494, 246);
            this.percentGraduatedNumeric.Name = "percentGraduatedNumeric";
            this.percentGraduatedNumeric.Size = new System.Drawing.Size(150, 27);
            this.percentGraduatedNumeric.TabIndex = 16;
            this.percentGraduatedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 696);
            this.Controls.Add(this.percentGraduatedNumeric);
            this.Controls.Add(this.numberGraduatedSecondNumeric);
            this.Controls.Add(this.numberGraduatedFirstNumeric);
            this.Controls.Add(this.numberEnteredSecondNumeric);
            this.Controls.Add(this.numberEnteredFirstNumeric);
            this.Controls.Add(this.secondNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.percentGraduatedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberEnteredFirstNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEnteredSecondNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGraduatedFirstNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGraduatedSecondNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentGraduatedNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label percentGraduatedLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox firstNameTextbox;
        private TextBox secondNameTextbox;
        private NumericUpDown numberEnteredFirstNumeric;
        private NumericUpDown numberEnteredSecondNumeric;
        private NumericUpDown numberGraduatedFirstNumeric;
        private NumericUpDown numberGraduatedSecondNumeric;
        private NumericUpDown percentGraduatedNumeric;
    }
}