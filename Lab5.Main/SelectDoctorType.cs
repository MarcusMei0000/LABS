using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Main
{
    public partial class SelectDoctorType : Form
    {
        private readonly IEnumerable<Type> doctorTypes;

        public Type SelectedType { get; private set; }

        public SelectDoctorType(IEnumerable<Type> doctorTypes)
        {
            InitializeComponent();

            this.doctorTypes = doctorTypes;

            SelectedType = null;
        }

        private void selectDoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = doctorTypes.First(type => type.Name == selectDoctorComboBox.SelectedItem.ToString());
            agreeButton.Enabled = true;
        }

        private void SelectDoctorType_Load(object sender, EventArgs e)
        {
            // fill combo box
            selectDoctorComboBox.Items.AddRange(doctorTypes.Select(type => type.Name).ToArray());
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            // кнопка доступна только при выборе, поэтому можно сразу закрыть
            if (SelectedType == null)
                MessageBox.Show("Вы не выбрали тип врача");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
