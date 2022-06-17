
namespace Lab3.Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.isFullBox = new System.Windows.Forms.CheckBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Угол:";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.okButton.Location = new System.Drawing.Point(20, 204);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(180, 58);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(236, 204);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 58);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // isFullBox
            // 
            this.isFullBox.AutoSize = true;
            this.isFullBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isFullBox.Location = new System.Drawing.Point(21, 148);
            this.isFullBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isFullBox.Name = "isFullBox";
            this.isFullBox.Size = new System.Drawing.Size(178, 29);
            this.isFullBox.TabIndex = 14;
            this.isFullBox.Text = "Заполненность";
            this.isFullBox.UseVisualStyleBackColor = true;
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lengthBox.Location = new System.Drawing.Point(116, 21);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(253, 30);
            this.lengthBox.TabIndex = 15;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightBox.Location = new System.Drawing.Point(116, 60);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(253, 30);
            this.heightBox.TabIndex = 16;
            // 
            // angleBox
            // 
            this.angleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.angleBox.Location = new System.Drawing.Point(116, 100);
            this.angleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(253, 30);
            this.angleBox.TabIndex = 17;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 276);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.isFullBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox isFullBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox angleBox;
    }
}