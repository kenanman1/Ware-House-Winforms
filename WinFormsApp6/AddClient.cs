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
    public partial class AddClient : Form
    {
        public AddClient()
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
            if (string.IsNullOrEmpty(textBoxsurname.Text))
                errorProvider1.SetError(textBoxsurname, "заполните поле");
            else
            {
                errorProvider1.SetError(textBoxsurname, "");
                ok++;
            }
            if (string.IsNullOrEmpty(textBoxadress.Text))
                errorProvider1.SetError(textBoxadress, "заполните поле");
            else
            {
                errorProvider1.SetError(textBoxadress, "");
                ok++;
            }
            if (textBoxphone.Text.Length != 12)
                errorProvider1.SetError(textBoxphone, "введите правильный номер телефона");
            else
            {
                errorProvider1.SetError(textBoxphone, "");
                ok++;
            }
            if (!textBoxemail.Text.Contains('@') || !textBoxemail.Text.Contains('.'))
                errorProvider1.SetError(textBoxemail, "введите правильный email");
            else
            {
                errorProvider1.SetError(textBoxemail, "");
                ok++;
            }
            if (ok == 5)
            {
                textBoxadress.Text.Trim();
                using (StreamWriter stream = new StreamWriter($"{Settings1.Default.Login}clients.txt", true))
                {
                    stream.WriteLine($"{textBoxname.Text} {textBoxsurname.Text} {textBoxemail.Text} {textBoxphone.Text} {textBoxadress.Text}");
                }
                MessageBox.Show("Клиент добавлен", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void textBoxphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
