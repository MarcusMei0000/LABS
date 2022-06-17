using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputString
{
    // класс для ввода строки, которая соответсвует валидатору
    // вызывается через ShowDialog

    public partial class InputStringDialog : Form
    {
        // валидатор строки
        IStringValidator validator;

        // строка и get свойство, чтобы получить её после ввода через ShowDialog
        string value = null;

        public string Value
        {
            get => value;
        }

        // в конструкторе берём валидатор и сообщения для ввода
        public InputStringDialog(IStringValidator validator, string message = "Введите строку")
        {
            InitializeComponent();

            this.validator = validator;

            Text = message;
            messageLabel.Text = message;
        }

        // кнопка подтвержедения ввода нажата
        private void okButton_Click(object sender, EventArgs e)
        {
            // строка не валидная
            if (!validator.IsValid(inputStringTextBox.Text))
            {
                // сообщаем об этом и почему это так
                MessageBox.Show("Неправильный ввод\n" + validator.ErrorMessage);
            }
            else
            {
                // всё ок, задаём value и что диалог успешен, закрываем форму
                value = inputStringTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
