using System.Drawing.Drawing2D;

namespace WinFormsApp6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StreamWriter stream = new StreamWriter("logins.txt", true);
            stream.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Registartion();
            form2.ShowDialog();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            int stop = 0;
            if (string.IsNullOrEmpty(textBoxpas.Text))
                errorProvider1.SetError(textBoxpas, "пароль не может быть пустым");
            else
                errorProvider1.SetError(textBoxpas, "");
            if (string.IsNullOrEmpty(textBoxlogin.Text))
                errorProvider1.SetError(textBoxlogin, "логин не может быть пустым");
            else
                errorProvider1.SetError(textBoxlogin, "");
            if (textBoxlogin.Text.Length > 0 && textBoxpas.Text.Length > 0)
            {
                using (StreamReader reader = new StreamReader("logins.txt"))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(' ');
                        if (arr[0] == textBoxlogin.Text && arr[1] == textBoxpas.Text)
                        {
                            stop++;
                            Hide();
                            Settings1.Default.Login = arr[0];
                            Form f3 = new Main();
                            f3.Show();
                            textBoxlogin.Text = "";
                            textBoxpas.Text = "";
                        }
                        else if (arr[0] == textBoxlogin.Text && arr[1] != textBoxpas.Text)
                        {
                            errorProvider1.SetError(textBoxpas, "неверный пароль");
                            stop++;
                        }
                    }
                }
                if (stop == 0)
                    errorProvider1.SetError(textBoxlogin, "пользователь не найден");
            }
            
            stop = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonlogin_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.SteelBlue;
        }

        private void buttonregistr_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkBlue;
        }
    }
}