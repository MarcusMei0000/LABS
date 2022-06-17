
namespace Lab4.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.selectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.selectMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PropertiesListBox = new System.Windows.Forms.ListBox();
            this.ParametersListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputParametersButton = new System.Windows.Forms.Button();
            this.startMethodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс";
            // 
            // selectTypeComboBox
            // 
            this.selectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectTypeComboBox.FormattingEnabled = true;
            this.selectTypeComboBox.Location = new System.Drawing.Point(16, 41);
            this.selectTypeComboBox.Name = "selectTypeComboBox";
            this.selectTypeComboBox.Size = new System.Drawing.Size(141, 28);
            this.selectTypeComboBox.TabIndex = 1;
            this.selectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTypeComboBox_SelectedIndexChanged);
            // 
            // selectMethodComboBox
            // 
            this.selectMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMethodComboBox.Enabled = false;
            this.selectMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectMethodComboBox.FormattingEnabled = true;
            this.selectMethodComboBox.Location = new System.Drawing.Point(167, 41);
            this.selectMethodComboBox.Name = "selectMethodComboBox";
            this.selectMethodComboBox.Size = new System.Drawing.Size(246, 28);
            this.selectMethodComboBox.TabIndex = 3;
            this.selectMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.selectMethodComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(163, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Метод";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Enabled = false;
            this.createObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createObjectButton.Location = new System.Drawing.Point(419, 29);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(142, 50);
            this.createObjectButton.TabIndex = 4;
            this.createObjectButton.Text = "Создать объект класса";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Свойста объекта";
            // 
            // PropertiesListBox
            // 
            this.PropertiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PropertiesListBox.FormattingEnabled = true;
            this.PropertiesListBox.ItemHeight = 20;
            this.PropertiesListBox.Location = new System.Drawing.Point(12, 107);
            this.PropertiesListBox.Name = "PropertiesListBox";
            this.PropertiesListBox.Size = new System.Drawing.Size(379, 204);
            this.PropertiesListBox.TabIndex = 6;
            // 
            // ParametersListBox
            // 
            this.ParametersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ParametersListBox.FormattingEnabled = true;
            this.ParametersListBox.ItemHeight = 20;
            this.ParametersListBox.Location = new System.Drawing.Point(12, 334);
            this.ParametersListBox.Name = "ParametersListBox";
            this.ParametersListBox.Size = new System.Drawing.Size(379, 104);
            this.ParametersListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Параметры метода";
            // 
            // inputParametersButton
            // 
            this.inputParametersButton.Enabled = false;
            this.inputParametersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputParametersButton.Location = new System.Drawing.Point(417, 107);
            this.inputParametersButton.Name = "inputParametersButton";
            this.inputParametersButton.Size = new System.Drawing.Size(144, 50);
            this.inputParametersButton.TabIndex = 9;
            this.inputParametersButton.Text = "Ввести параметры";
            this.inputParametersButton.UseVisualStyleBackColor = true;
            this.inputParametersButton.Click += new System.EventHandler(this.inputParametersButton_Click);
            // 
            // startMethodButton
            // 
            this.startMethodButton.Enabled = false;
            this.startMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startMethodButton.Location = new System.Drawing.Point(419, 181);
            this.startMethodButton.Name = "startMethodButton";
            this.startMethodButton.Size = new System.Drawing.Size(144, 50);
            this.startMethodButton.TabIndex = 10;
            this.startMethodButton.Text = "Выполнить метод";
            this.startMethodButton.UseVisualStyleBackColor = true;
            this.startMethodButton.Click += new System.EventHandler(this.startMethodButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.startMethodButton);
            this.Controls.Add(this.inputParametersButton);
            this.Controls.Add(this.ParametersListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropertiesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.selectMethodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectTypeComboBox;
        private System.Windows.Forms.ComboBox selectMethodComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox PropertiesListBox;
        private System.Windows.Forms.ListBox ParametersListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inputParametersButton;
        private System.Windows.Forms.Button startMethodButton;
    }
}

