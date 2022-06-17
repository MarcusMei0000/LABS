
namespace Lab6.Main
{
    partial class SelectDoctorType
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете тип врача";
            // 
            // selectDoctorComboBox
            // 
            this.selectDoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDoctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectDoctorComboBox.FormattingEnabled = true;
            this.selectDoctorComboBox.Location = new System.Drawing.Point(16, 33);
            this.selectDoctorComboBox.Name = "selectDoctorComboBox";
            this.selectDoctorComboBox.Size = new System.Drawing.Size(178, 28);
            this.selectDoctorComboBox.TabIndex = 1;
            this.selectDoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDoctorComboBox_SelectedIndexChanged);
            // 
            // agreeButton
            // 
            this.agreeButton.Enabled = false;
            this.agreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeButton.Location = new System.Drawing.Point(16, 67);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(121, 33);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Выбрать";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // SelectDoctorType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 114);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.selectDoctorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectDoctorType";
            this.Text = "Выберете тип врача";
            this.Load += new System.EventHandler(this.SelectDoctorType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectDoctorComboBox;
        private System.Windows.Forms.Button agreeButton;
    }
}