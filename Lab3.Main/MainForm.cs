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
    public partial class MainForm : Form
    {
        IRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            _repository = new ListRepository();
        }
       

        void ShowRepository()
        {
            IEnumerable<Item> allFigure = _repository.GetAll();

            dataGridView1.Rows.Clear();

            foreach (var item in allFigure)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow currentRow = dataGridView1.Rows[rowIndex];

                currentRow.Cells[0].Value = item.index;
                if (item.figure is Rhombus)
                {
                    var itemRhombus = item.figure as Rhombus;

                    currentRow.Cells[1].Value = itemRhombus.Length;
                    currentRow.Cells[2].Value = itemRhombus.Height;
                    currentRow.Cells[3].Value = itemRhombus.CountArea();
                    currentRow.Cells[4].Value = itemRhombus.CountPerimeter();
                    currentRow.Cells[5].Value = itemRhombus.isFull ? "Сплошной" : "Контур";
                    currentRow.Cells[6].Value = itemRhombus.CountAreaWithAngle();
                    currentRow.Cells[7].Value = itemRhombus.CountAreaWithHeight();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputId = new InputStringDialog(new NotNegativeIntValidator(), "Введите id");

            if (inputId.ShowDialog() == DialogResult.OK)
            {
                // id введено, удаление
                try
                {
                    _repository.Delete(Int32.Parse(inputId.Value));
                    ShowRepository();
                }
                catch (ArgumentException exception)
                {
                    // id не найдено
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // добавить = редактировать пустоe
            EditForm addRhombus = new EditForm(new Rhombus());

            if (addRhombus.ShowDialog() == DialogResult.OK)
            {
                Item item = new Item(addRhombus.Value, dataGridView1.Rows.Count);
                _repository.Add(item);
                ShowRepository();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputId = new InputStringDialog(new NotNegativeIntValidator(), "Введите id");
            
            if (inputId.ShowDialog() == DialogResult.OK)
            {
                // ввели id
                try
                {
                    Item editItem = _repository.Get(Int32.Parse(inputId.Value));

                    EditForm editRhombus = new EditForm(editItem.figure as Rhombus);

                    if (editRhombus.ShowDialog() == DialogResult.OK)
                    {
                        Item item = new Item(editRhombus.Value, Int32.Parse(inputId.Value));
                        _repository.Update(item);
                    }

                    ShowRepository();
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
