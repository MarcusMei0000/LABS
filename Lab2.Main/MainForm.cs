using InputString;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab2.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            string name = firstNameTextbox.Text;
            uint firstAmount = (uint)numberEnteredFirstNumeric.Value;
            uint graduatedAmount = (uint)numberGraduatedFirstNumeric.Value;
            University university = new University(name, firstAmount, graduatedAmount);
            university.Q();
            textBox2.Text+= university.ToString() + "\r\n";

            name = secondNameTextbox.Text;
            firstAmount = (uint)numberEnteredSecondNumeric.Value;
            graduatedAmount = (uint)numberGraduatedSecondNumeric.Value;
            double percent = (uint)percentGraduatedNumeric.Value;
            ExtendetUniversity exUniversity = new ExtendetUniversity(name, firstAmount, graduatedAmount, percent);
            exUniversity.Q();
            textBox2.Text += exUniversity.ToString() + "\r\n";
        }
    }
}

/* var s = textBox1.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            string name = s[i++];
            uint firstAmount = Convert.ToUInt32(s[i++]);
            uint graduatedAmount = Convert.ToUInt32(s[i++]);
            University university = new University(name, firstAmount, graduatedAmount);
            university.Q();
            textBox2.Text+= university.ToString() + "\r\n";

            name = s[i++];
            firstAmount = Convert.ToUInt32(s[i++]);
            graduatedAmount = Convert.ToUInt32(s[i++]);
            double persent = Convert.ToDouble(s[i++]);
            ExtendetUniversity exUniversity = new ExtendetUniversity(name, firstAmount, graduatedAmount, persent);
            exUniversity.Q();
            textBox2.Text += university.ToString() + "\r\n";*/