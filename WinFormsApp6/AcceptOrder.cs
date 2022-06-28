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
    public partial class AcceptOrder : Form
    {
        public AcceptOrder()
        {
            InitializeComponent();
            Settings1.Default.productquant = 0;
            using (StreamReader reader = new StreamReader($"{Settings1.Default.Login}clients.txt"))
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    comboBoxname.Items.Add(arr[0]);
                }
            }
            using (StreamReader reader1 = new StreamReader("products.txt"))
            {
                string? line;
                while((line = reader1.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    comboBoxproduct.Items.Add(arr[0]);
                }
            }
        }

        private void numericquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (comboBoxname.SelectedIndex == -1)
                errorProvider1.SetError(comboBoxname, "выберите клиента");
            else
            {
                errorProvider1.SetError(comboBoxname, "");
                ok++;
            }
            if (comboBoxproduct.SelectedIndex == -1)
                errorProvider1.SetError(comboBoxproduct, "выберите продукт");
            else
            {
                errorProvider1.SetError(comboBoxproduct, "");
                ok++;
            }
            if (numericquantity.Value == 0)
                errorProvider1.SetError(numericquantity, "выберите количество");
            else
            {
                errorProvider1.SetError(numericquantity, "");
                ok++;
            }
            if (ok == 3)
            {
                using (StreamWriter writer = new StreamWriter($"{Settings1.Default.Login}orders.txt", true))
                {
                    writer.WriteLine($"{comboBoxname.SelectedItem} {comboBoxproduct.SelectedItem} {numericquantity.Value} {dateTimePicker1.Value}");
                }
                Settings1.Default.productaccept = comboBoxproduct.SelectedItem.ToString();
                Settings1.Default.productquant = (int)numericquantity.Value;
                MessageBox.Show("Заказ добавлен", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void comboBoxproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("products.txt"))
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                   
                    if (arr[0] == comboBoxproduct.SelectedItem.ToString())
                    {
                        numericquantity.Maximum = int.Parse(arr[2]);
                    }
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
        }
    }
}
