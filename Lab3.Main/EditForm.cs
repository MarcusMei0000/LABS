using InputString;
using Lab3.Models;
using Lab3.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Main
{
    public partial class EditForm : Form
    {
        public Rhombus Value { get; private set; }

        public EditForm(Rhombus rhombus)
        {
            InitializeComponent();

            Value = rhombus;           

            lengthBox.Text = rhombus.Length.ToString(); 
            heightBox.Text = rhombus.Height.ToString();
            angleBox.Text = rhombus.Angle.ToString();
            isFullBox.Checked = rhombus.isFull;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Length = Double.Parse(lengthBox.Text);
                Value.Height = Double.Parse(heightBox.Text);
                Value.Angle = Double.Parse(angleBox.Text);
                Value.isFull = isFullBox.Checked;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число.\n" +
                    "Проверьте, что во всех полях введены числа");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
