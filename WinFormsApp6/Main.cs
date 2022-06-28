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
    public partial class Main : Form
    {
        Label label5 = new Label();
        ListBox listBoxclientName = new ListBox();
        ListBox listBoxclientSurname = new ListBox();
        ListBox listBoxclientEmail = new ListBox();
        ListBox listBoxclientPhone = new ListBox();
        ListBox listBoxclientAdress = new ListBox();

        ListBox listBoxproductName = new ListBox();
        ListBox listBoxproductPrice = new ListBox();
        ListBox listBoxproductQuantity = new ListBox();
        ListBox listBoxproductDescription = new ListBox();
        public Main()
        {
            InitializeComponent();
            listBoxproductName.Visible = false;
            listBoxproductDescription.Visible = false;
            listBoxproductPrice.Visible = false;
            listBoxproductQuantity.Visible = false;
            StreamWriter writer = new StreamWriter($"{Settings1.Default.Login}orders.txt", true);
            writer.Close();
            StreamWriter writer1 = new StreamWriter($"{Settings1.Default.Login}clients.txt", true);
            writer1.Close();
            StreamWriter writer2 = new StreamWriter("products.txt", true);
            writer2.Close();
            listBoxclientName.Visible = false;

            listBoxclientName.Size = new Size(listBoxname.Width - 100,listBoxname.Height);
            listBoxclientName.Location = listBoxname.Location;

            listBoxclientSurname.Size = new Size(listBoxproduct.Width - 70, listBoxproduct.Height);
            listBoxclientSurname.Location = new Point(listBoxproduct.Left - 98, listBoxproduct.Top);
            listBoxclientSurname.SelectionMode = SelectionMode.None;

            listBoxclientEmail.Size = new Size(listBoxquantity.Width - 25, listBoxquantity.Height);
            listBoxclientEmail.Location = new Point(listBoxquantity.Left - 170, listBoxquantity.Top);
            listBoxclientEmail.SelectionMode = SelectionMode.None;

            listBoxclientPhone.Size = new Size(listBoxarrivedate.Width - 100, listBoxarrivedate.Height);
            listBoxclientPhone.Location = new Point(listBoxarrivedate.Left - 195, listBoxarrivedate.Top);
            listBoxclientPhone.SelectionMode = SelectionMode.None;

            listBoxclientAdress.Size = new Size(listBoxarrivedate.Width, listBoxarrivedate.Height);
            listBoxclientAdress.Location = new Point(listBoxarrivedate.Left - 20, listBoxarrivedate.Top);
            listBoxclientAdress.SelectionMode = SelectionMode.None;

            listBoxproductName.Size = listBoxname.Size;
            listBoxproductName.Location = listBoxname.Location;
            listBoxproductPrice.Size = listBoxproduct.Size;
            listBoxproductPrice.Location = listBoxproduct.Location;
            listBoxproductPrice.SelectionMode = SelectionMode.None;
            listBoxproductQuantity.Size = listBoxquantity.Size;
            listBoxproductQuantity.Location = listBoxquantity.Location;
            listBoxproductQuantity.SelectionMode = SelectionMode.None;
            listBoxproductDescription.Size = listBoxarrivedate.Size;
            listBoxproductDescription.Location = listBoxarrivedate.Location;
            listBoxproductDescription.SelectionMode = SelectionMode.None;
            using (StreamReader reader = new StreamReader("products.txt"))
            {
                listBoxproductDescription.Items.Clear();
                listBoxproductName.Items.Clear();
                listBoxproductPrice.Items.Clear();
                listBoxproductQuantity.Items.Clear();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> vs = new List<string>();
                    string[] arr = line.Split(' ');
                    foreach (var item in arr)
                    {
                        vs.Add(item);
                    }
                    if (vs.Count < 5)
                    {
                        listBoxproductName.Items.Add(arr[0]);
                        listBoxproductPrice.Items.Add(arr[1]);
                        listBoxproductQuantity.Items.Add(arr[2]);
                        listBoxproductDescription.Items.Add(arr[3]);
                    }
                    else
                    {
                        string text = "";
                        listBoxproductName.Items.Add(vs[0]);
                        listBoxproductPrice.Items.Add(vs[1]);
                        listBoxproductQuantity.Items.Add(vs[2]);
                        for (int i = 3; i < vs.Count; i++)
                        {
                            text += vs[i] + " ";
                        }
                        listBoxproductDescription.Items.Add(text);
                    }
                }
            }

            Controls.Add(listBoxproductName);
            Controls.Add(listBoxproductPrice);
            Controls.Add(listBoxproductDescription);
            Controls.Add(listBoxproductQuantity);

            Controls.Add(label5);
            Controls.Add(listBoxclientName);
            Controls.Add(listBoxclientSurname);
            Controls.Add(listBoxclientEmail);
            Controls.Add(listBoxclientPhone);
            Controls.Add(listBoxclientAdress);
            using (StreamReader stream = new StreamReader($"{Settings1.Default.Login}orders.txt"))
            {
                listBoxname.Items.Clear();
                listBoxproduct.Items.Clear();
                listBoxquantity.Items.Clear();
                listBoxarrivedate.Items.Clear();
                string? line;
                while((line = stream.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    listBoxname.Items.Add(arr[0]);
                    listBoxproduct.Items.Add(arr[1]);
                    listBoxquantity.Items.Add(arr[2]);
                    listBoxarrivedate.Items.Add(arr[3].ToString());
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form f = Application.OpenForms[0];
            f.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog(this);
            using (StreamReader reader = new StreamReader($"{Settings1.Default.Login}clients.txt"))
            {
                listBoxclientName.Items.Clear();
                listBoxclientSurname.Items.Clear();
                listBoxclientEmail.Items.Clear();
                listBoxclientPhone.Items.Clear();
                listBoxclientAdress.Items.Clear();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> vs = new List<string>();
                    string[] arr = line.Split(' ');
                    foreach (var item in arr)
                    {
                        vs.Add(item);
                    }
                    if (vs.Count < 6)
                    {
                        listBoxclientName.Items.Add(arr[0]);
                        listBoxclientSurname.Items.Add(arr[1]);
                        listBoxclientEmail.Items.Add(arr[2]);
                        listBoxclientPhone.Items.Add(arr[3]);
                        listBoxclientAdress.Items.Add(arr[4]);
                    }
                    else
                    {
                        string text = "";
                        listBoxclientName.Items.Add(vs[0]);
                        listBoxclientSurname.Items.Add(vs[1]);
                        listBoxclientEmail.Items.Add(vs[2]);
                        listBoxclientPhone.Items.Add(vs[3]);
                        for (int i = 4; i < vs.Count; i++)
                        {
                            text += vs[i] + " ";
                        }
                        listBoxclientAdress.Items.Add(text);
                    }
                }
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (listBoxname.Visible == true)
            {
                label2.Text = "Surname";
                label2.Location = new Point(190, label2.Top);
                label3.Text = "Email";
                label3.Location = new Point(350, label3.Top);
                label4.Text = "Phone";
                label4.Location = new Point(540, label4.Top);
                label5.Font = label4.Font;
                label5.Text = "Adress";
                label5.Location = new Point(720, label4.Top);
                label5.Visible = true;
                listBoxclientName.Visible = true;
                listBoxclientSurname.Visible = true;
                listBoxclientEmail.Visible = true;
                listBoxclientPhone.Visible = true;
                listBoxclientAdress.Visible = true;
                listBoxname.Visible = false;
                listBoxproduct.Visible = false;
                listBoxquantity.Visible = false;
                listBoxarrivedate.Visible = false;
            }
            else if (listBoxproductName.Visible == true)
            {
                label2.Text = "Surname";
                label2.Location = new Point(190, label2.Top);
                label3.Text = "Email";
                label3.Location = new Point(350, label3.Top);
                label4.Text = "Phone";
                label4.Location = new Point(540, label4.Top);
                label5.Font = label4.Font;
                label5.Text = "Adress";
                label5.Location = new Point(720, label4.Top);
                label5.Visible = true;
                listBoxclientName.Visible = true;
                listBoxclientSurname.Visible = true;
                listBoxclientEmail.Visible = true;
                listBoxclientPhone.Visible = true;
                listBoxclientAdress.Visible = true;
                listBoxproductName.Visible = false;
                listBoxproductDescription.Visible = false;
                listBoxproductPrice.Visible = false;
                listBoxproductQuantity.Visible = false;
            }
            using (StreamReader reader = new StreamReader($"{Settings1.Default.Login}clients.txt"))
            {
                listBoxclientName.Items.Clear();
                listBoxclientSurname.Items.Clear();
                listBoxclientEmail.Items.Clear();
                listBoxclientPhone.Items.Clear();
                listBoxclientAdress.Items.Clear();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> vs = new List<string>();
                    string[] arr = line.Split(' ');
                    foreach (var item in arr)
                    {
                        vs.Add(item);
                    }
                    if (vs.Count < 6)
                    {
                        listBoxclientName.Items.Add(arr[0]);
                        listBoxclientSurname.Items.Add(arr[1]);
                        listBoxclientEmail.Items.Add(arr[2]);
                        listBoxclientPhone.Items.Add(arr[3]);
                        listBoxclientAdress.Items.Add(arr[4]);
                    }
                    else
                    {
                        string text = "";
                        listBoxclientName.Items.Add(vs[0]);
                        listBoxclientSurname.Items.Add(vs[1]);
                        listBoxclientEmail.Items.Add(vs[2]);
                        listBoxclientPhone.Items.Add(vs[3]);
                        for (int i = 4; i < vs.Count; i++)
                        {
                            text += vs[i] + " ";
                        }
                        listBoxclientAdress.Items.Add(text);
                    }
                }
            }
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listBoxclientName.Visible == true)
            {
                label2.Text = "Product";
                label2.Location = new Point(291,28);
                label3.Text = "Quantity";
                label3.Location = new Point(526, label3.Top);
                label4.Text = "Arrive Date";
                label4.Location = new Point(748, label4.Top);
                label5.Visible = false;
                listBoxclientName.Visible = false;
                listBoxclientSurname.Visible = false;
                listBoxclientEmail.Visible = false;
                listBoxclientPhone.Visible = false;
                listBoxclientAdress.Visible = false;
                listBoxname.Visible = true;
                listBoxproduct.Visible = true;
                listBoxquantity.Visible = true;
                listBoxarrivedate.Visible = true;
            }
            else if (listBoxproductName.Visible == true)
            {
                label2.Text = "Product";
                label2.Location = new Point(291, 28);
                label3.Text = "Quantity";
                label3.Location = new Point(526, label3.Top);
                label4.Text = "Arrive Date";
                label4.Location = new Point(748, label4.Top);
                listBoxproductName.Visible = false;
                listBoxproductDescription.Visible = false;
                listBoxproductPrice.Visible = false;
                listBoxproductQuantity.Visible = false;
                listBoxname.Visible = true;
                listBoxproduct.Visible = true;
                listBoxquantity.Visible = true;
                listBoxarrivedate.Visible = true;
            }
        }
        private void acceptToolStripMenuItem_Click(object send1er, EventArgs e)
        {
            Form form = new AcceptOrder();
            form.ShowDialog();
            listBoxproduct.Items.Clear();
            listBoxname.Items.Clear();
            listBoxquantity.Items.Clear();
            listBoxarrivedate.Items.Clear();
            using (StreamReader reader = new StreamReader($"{Settings1.Default.Login}orders.txt"))
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    listBoxname.Items.Add(arr[0]);
                    listBoxproduct.Items.Add(arr[1]);
                    listBoxquantity.Items.Add(arr[2]);
                    listBoxarrivedate.Items.Add(arr[3].ToString());
                }
            }
            try
            {
                for (int i = 0; i < listBoxproductQuantity.Items.Count; i++)
                {
                    if (listBoxproductName.Items[i].ToString() == Settings1.Default.productaccept)
                    {
                        listBoxproductQuantity.Items[i] = (int.Parse(listBoxproductQuantity.Items[i].ToString()) - Settings1.Default.productquant).ToString();
                    }
                }
                using (StreamWriter stream = new StreamWriter("products.txt", false))
                {
                    for (int i = 0; i < listBoxproductName.Items.Count; i++)
                    {
                        stream.WriteLine($"{listBoxproductName.Items[i]} {listBoxproductPrice.Items[i]} {listBoxproductQuantity.Items[i]} {listBoxproductDescription.Items[i]}");
                    }
                }
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddProduct();
            form.ShowDialog();
            listBoxproductName.Items.Clear();
            listBoxproductDescription.Items.Clear();
            listBoxproductPrice.Items.Clear();
            listBoxproductQuantity.Items.Clear();
            using (StreamReader reader = new StreamReader("products.txt"))
            {
                listBoxproductDescription.Items.Clear();
                listBoxproductName.Items.Clear();
                listBoxproductPrice.Items.Clear();
                listBoxproductQuantity.Items.Clear();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> vs = new List<string>();
                    string[] arr = line.Split(' ');
                    foreach (var item in arr)
                    {
                        vs.Add(item);
                    }
                    if (vs.Count < 5)
                    {
                        listBoxproductName.Items.Add(arr[0]);
                        listBoxproductPrice.Items.Add(arr[1]);
                        listBoxproductQuantity.Items.Add(arr[2]);
                        listBoxproductDescription.Items.Add(arr[3]);
                    }
                    else
                    {
                        string text = "";
                        listBoxproductName.Items.Add(vs[0]);
                        listBoxproductPrice.Items.Add(vs[1]);
                        listBoxproductQuantity.Items.Add(vs[2]);
                        for (int i = 3; i < vs.Count; i++)
                        {
                            text += vs[i] + " ";
                        }
                        listBoxproductDescription.Items.Add(text);
                    }
                }
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (listBoxclientName.Visible == true)
            {
                label2.Text = "Price";
                label2.Location = new Point(291, 28);
                label3.Text = "Quantity";
                label3.Location = new Point(526, label3.Top);
                label4.Text = "Description";
                label4.Location = new Point(748, label4.Top);
                label5.Visible = false;
                listBoxclientName.Visible = false;
                listBoxclientSurname.Visible = false;
                listBoxclientEmail.Visible = false;
                listBoxclientPhone.Visible = false;
                listBoxclientAdress.Visible = false;
                listBoxproductName.Visible = true;
                listBoxproductPrice.Visible = true;
                listBoxproductDescription.Visible = true;
                listBoxproductQuantity.Visible = true;
            }
            else if (listBoxname.Visible == true)
            {
                label2.Text = "Price";
                label2.Location = new Point(291, 28);
                label3.Text = "Quantity";
                label3.Location = new Point(526, label3.Top);
                label4.Text = "Description";
                label4.Location = new Point(748, label4.Top);
                listBoxname.Visible = false;
                listBoxquantity.Visible = false;
                listBoxproduct.Visible = false;
                listBoxarrivedate.Visible = false;
                listBoxproductName.Visible = true;
                listBoxproductPrice.Visible = true;
                listBoxproductDescription.Visible = true;
                listBoxproductQuantity.Visible = true;
            }
            using (StreamReader reader = new StreamReader("products.txt"))
            {
                listBoxproductDescription.Items.Clear();
                listBoxproductName.Items.Clear();
                listBoxproductPrice.Items.Clear();
                listBoxproductQuantity.Items.Clear();
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> vs = new List<string>();
                    string[] arr = line.Split(' ');
                    foreach (var item in arr)
                    {
                        vs.Add(item);
                    }
                    if (vs.Count < 5)
                    {
                        listBoxproductName.Items.Add(arr[0]);
                        listBoxproductPrice.Items.Add(arr[1]);
                        listBoxproductQuantity.Items.Add(arr[2]);
                        listBoxproductDescription.Items.Add(arr[3]);
                    }
                    else
                    {
                        string text = "";
                        listBoxproductName.Items.Add(vs[0]);
                        listBoxproductPrice.Items.Add(vs[1]);
                        listBoxproductQuantity.Items.Add(vs[2]);
                        for (int i = 3; i < vs.Count; i++)
                        {
                            text += vs[i] + " ";
                        }
                        listBoxproductDescription.Items.Add(text);
                    }
                }
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.SteelBlue;
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.DarkBlue;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxname.Visible == true)
            {
                if (listBoxname.SelectedIndex != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить заказ для {listBoxname.SelectedItem}?", "Подтвердите удаление",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Settings1.Default.productaccept = listBoxproduct.Items[listBoxname.SelectedIndex].ToString();
                        Settings1.Default.productquant = int.Parse((string)listBoxquantity.Items[listBoxname.SelectedIndex]);
                        MessageBox.Show("Заказ удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxproduct.Items.RemoveAt(listBoxname.SelectedIndex);
                        listBoxquantity.Items.RemoveAt(listBoxname.SelectedIndex);
                        listBoxarrivedate.Items.RemoveAt(listBoxname.SelectedIndex);
                        listBoxname.Items.RemoveAt(listBoxname.SelectedIndex);
                        using (StreamWriter stream = new StreamWriter($"{Settings1.Default.Login}orders.txt", false))
                        {
                            for (int i = 0; i < listBoxname.Items.Count; i++)
                            {
                                stream.WriteLine($"{listBoxname.Items[i]} {listBoxproduct.Items[i]} {listBoxquantity.Items[i]} {listBoxarrivedate.Items[i]}");
                            }
                        }
                        try
                        {
                            for (int i = 0; i < listBoxproductQuantity.Items.Count; i++)
                            {
                                if (listBoxproductName.Items[i].ToString() == Settings1.Default.productaccept)
                                {
                                    listBoxproductQuantity.Items[i] = (int.Parse(listBoxproductQuantity.Items[i].ToString()) + Settings1.Default.productquant).ToString();
                                }
                            }
                            using (StreamWriter stream = new StreamWriter("products.txt", false))
                            {
                                for (int i = 0; i < listBoxproductName.Items.Count; i++)
                                {
                                    stream.WriteLine($"{listBoxproductName.Items[i]} {listBoxproductPrice.Items[i]} {listBoxproductQuantity.Items[i]} {listBoxproductDescription.Items[i]}");
                                }
                            }
                        }
                        catch (Exception ed)
                        {
                            MessageBox.Show(ed.Message);
                        }
                    }
                }
            }
            else if (listBoxproductName.Visible == true)
            {
                if (listBoxproductName.SelectedIndex != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить продукт {listBoxproductName.SelectedItem}?", "Подтвердите удаление",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Продукт удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxproductQuantity.Items.RemoveAt(listBoxproductName.SelectedIndex);
                        listBoxproductPrice.Items.RemoveAt(listBoxproductName.SelectedIndex);
                        listBoxproductDescription.Items.RemoveAt(listBoxproductName.SelectedIndex);
                        listBoxproductName.Items.RemoveAt(listBoxproductName.SelectedIndex);
                    }
                    using (StreamWriter stream = new StreamWriter("products.txt", false))
                    {
                        for (int i = 0; i < listBoxproductName.Items.Count; i++)
                        {
                            stream.WriteLine($"{listBoxproductName.Items[i]} {listBoxproductPrice.Items[i]} {listBoxproductQuantity.Items[i]} {listBoxproductDescription.Items[i]}");
                        }
                    }
                }
            }
            else if (listBoxclientName.Visible == true)
            {
                if (listBoxclientName.SelectedIndex != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить клиента {listBoxclientName.SelectedItem}?", "Подтвердите удаление",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Клиент удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxclientAdress.Items.RemoveAt(listBoxclientName.SelectedIndex);
                        listBoxclientEmail.Items.RemoveAt(listBoxclientName.SelectedIndex);
                        listBoxclientSurname.Items.RemoveAt(listBoxclientName.SelectedIndex);
                        listBoxclientPhone.Items.RemoveAt(listBoxclientName.SelectedIndex);
                        listBoxclientName.Items.RemoveAt(listBoxclientName.SelectedIndex);
                    }
                    using (StreamWriter stream = new StreamWriter($"{Settings1.Default.Login}clients.txt", false))
                    {
                        for (int i = 0; i < listBoxclientName.Items.Count; i++)
                        {
                            stream.WriteLine($"{listBoxclientName.Items[i]} {listBoxclientSurname.Items[i]} {listBoxclientEmail.Items[i]} {listBoxclientPhone.Items[i]} {listBoxclientAdress.Items[i]}");
                        }
                    }
                }
            }
        }
    }
}
