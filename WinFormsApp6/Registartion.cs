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
    

    public partial class Registartion : Form
    {
        public Registartion()
        {
            InitializeComponent();
            StreamWriter streamWriter = new StreamWriter("logins.txt", true);
            streamWriter.Close();
            toolTip1.SetToolTip(textBoxpassword, "минимум 8 символов");
            toolTip1.SetToolTip(textBoxlogin, "минимум 6 символов");
        }

        

        private void buttonconfirm_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.Text.Length < 8)
                errorProvider1.SetError(textBoxpassword, "пароль должен состоять из 8 символов");
            else
                errorProvider1.SetError(textBoxpassword, "");
            if (textBoxlogin.Text.Length < 6)
                errorProvider1.SetError(textBoxlogin, "логин должен состоять из 6 символов");
            else
                errorProvider1.SetError(textBoxlogin, "");
            if (textBoxrepeatpas.Text != textBoxpassword.Text)
                errorProvider1.SetError(textBoxrepeatpas, "пароли не совпaдают");
            else
                errorProvider1.SetError(textBoxrepeatpas, "");
            if (string.IsNullOrEmpty(textBoxname.Text))
                errorProvider1.SetError(textBoxname, "заполните поле");
            else
                errorProvider1.SetError(textBoxname, "");
            if (string.IsNullOrEmpty(textBoxsurname.Text))
                errorProvider1.SetError(textBoxsurname, "заполните поле");
            else
                errorProvider1.SetError(textBoxsurname, "");
            if (textBoxpassword.Text.Length >= 8 && textBoxlogin.Text.Length >= 6 && textBoxrepeatpas.Text == textBoxpassword.Text
                && !string.IsNullOrEmpty(textBoxsurname.Text) && !string.IsNullOrEmpty(textBoxname.Text))
            {
                int stop = 0;
                using (StreamReader reader = new StreamReader("logins.txt"))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(' ');
                        if (arr[0] == textBoxlogin.Text)
                        {
                            errorProvider1.SetError(textBoxlogin, "пользователь с таким логином уже существует");
                            stop++;
                        }
                    }
                }
                if (stop == 0)
                    using (StreamWriter stream = new StreamWriter("logins.txt", true))
                    {
                        stream.WriteLine($"{textBoxlogin.Text} {textBoxpassword.Text}");
                        MessageBox.Show("Аккаунт успешно создан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Form f = Application.OpenForms[0];
                        f.Show();
                    }
            }
        }

        private void textBoxlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "show")
            {
                if (button.Name == "button1")
                    textBoxpassword.UseSystemPasswordChar = false;
                else
                    textBoxrepeatpas.UseSystemPasswordChar = false;
                button.Text = "hide";
                
                button.BackColor = Color.Gray;
            }
            else
            {
                if (button.Name == "button1")
                    textBoxpassword.UseSystemPasswordChar = true;
                else
                    textBoxrepeatpas.UseSystemPasswordChar = true;
                button.Text = "show";
                button.BackColor = Color.DarkBlue;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text != "hide")
                button.BackColor = Color.SteelBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text != "hide")
                button.BackColor = Color.DarkBlue;
        }

     
    }
}
