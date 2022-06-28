using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (string.IsNullOrEmpty(textBoxname.Text))
                errorProvider1.SetError(textBoxname, "заполните поле");
            else
            {
                errorProvider1.SetError(textBoxname, "");
                ok++;
            }
            if (string.IsNullOrEmpty(textBoxprice.Text))
                errorProvider1.SetError(textBoxprice, "заподните поле");
            else
            {
                errorProvider1.SetError(textBoxprice, "");
                ok++;
            }
            if (string.IsNullOrEmpty(textBoxdescription.Text))
                errorProvider1.SetError(textBoxdescription, "заполните поле");
            else
            {
                errorProvider1.SetError(textBoxdescription, "");
                ok++;
            }
            if (numericUpDown1.Value == 0)
                errorProvider1.SetError(numericUpDown1, "введите количество");
            else
            {
                errorProvider1.SetError(numericUpDown1, "");
                ok++;
            }
            if (ok == 4)
            {
                using (StreamWriter writer = new StreamWriter("products.txt", true))
                {
                    writer.WriteLine($"{textBoxname.Text} {textBoxprice.Text} {numericUpDown1.Value} {textBoxdescription.Text}");
                }
                MessageBox.Show("Продукт добавлен", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
