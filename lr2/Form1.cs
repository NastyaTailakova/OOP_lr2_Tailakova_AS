using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Указываем базовую цену за чашку кофе
            double americanoPrice = 129.99;
            double espressoPrice = 149.99;
            double lattePrice = 199.99;
            double cappuccinoPrice = 249.99;
            double moccachinoPrice = 269.99;

            // Получаем количество чашек из TextBox
            if (!int.TryParse(txtCups.Text, out int cups) || cups <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное количество чашек.");
                return;
            }

            // Получаем выбранный тип кофе
            double coffeePrice;
            switch (cmbCoffeeType.SelectedItem.ToString())
            {
                case "Американо":
                    coffeePrice = americanoPrice;
                    break;
                case "Эспрессо":
                    coffeePrice = espressoPrice;
                    break;
                case "Латте":
                    coffeePrice = lattePrice;
                    break;
                case "Капучино":
                    coffeePrice = cappuccinoPrice;
                    break;
                case "Мокачино":
                    coffeePrice = moccachinoPrice;
                    break;
                default:
                    MessageBox.Show("Пожалуйста, выберите тип кофе.");
                    return;
            }

            // Учитываем дополнения
            double sugarCost = chkSugar.Checked ? 9.99 : 0.00;
            double milkCost = chkMilk.Checked ? 19.99 : 0.00;

            // Рассчитываем общую стоимость
            double totalCost = cups * (coffeePrice + sugarCost + milkCost);
            lblResult.Text = $"Итого: {totalCost:F2} руб";
        }
    }
}
