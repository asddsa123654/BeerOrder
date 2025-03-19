using System;
using System.Windows.Forms;

namespace BeerOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Отримання кількості порцій
            int quantity = int.Parse(txtQuantity.Text);
            double totalPrice = 0;

            // Перевірка вибору сортів пива та обчислення вартості
            if (chkLight.Checked)
            {
                totalPrice += 50 * quantity; // ціна для світлого пива
            }
            if (chkDark.Checked)
            {
                totalPrice += 60 * quantity; // ціна для темного пива
            }

            // Знижка 15%, якщо більше 20 порцій
            if (quantity > 20)
            {
                totalPrice *= 0.85; // застосування знижки
            }

            // Виведення результату
            lblResult.Text = "Загальна вартість: " + totalPrice.ToString("C");
        }
    }
}
