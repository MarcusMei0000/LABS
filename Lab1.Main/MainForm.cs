using Lab1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Lab1.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Candy bestChoko = new Chocolate("Риттер спорт", 100, 5, 30, "Риттер", 36, ChocolateKinds.Milk);
            Candy choco = new Chocolate("Риттер спорт", 150, 3.44, 30, "Риттер", 36, ChocolateKinds.Bitter);
            Candy zefir = new Marshmallow("Домашний", 230, 2.77, 50, "АэрСвит", MarshmallowKinds.Long, 1);
            Candy zefi = new Marshmallow("Домашний", 230, 1, 50, "АэрСвит", MarshmallowKinds.Long, 2);

            Gift gift = new Gift("Новогодний подарок", new List<Candy>());
            gift.Add(bestChoko);
            gift.Add(choco);
            gift.Add(zefir);
            gift.Add(zefi);

            textBox1.Text += bestChoko.ToString() + "\r\n" + zefir.ToString();
            textBox2.Text += "Вес подарка: " + gift.Weight + "g\r\n\r\n";

            var filtered = CandyFilters.WeightFilter(gift.Candies, 100, 200);
            filtered = CandyFilters.PriceFilter(filtered, 3, 4);

            textBox2.Text += "Отфильтрованные по весу от 100 до 200:\r\n";

            foreach (var item in filtered)
                textBox2.Text += item + "\r\n";

            gift.Candies.Sort(new PriceComparer<Candy>());

            textBox2.Text += "Отсортированные по цене:\r\n";

            foreach (var item in gift.Candies)
                textBox2.Text += item + "\r\n";
        }
    }
}