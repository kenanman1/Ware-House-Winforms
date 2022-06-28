namespace WinFormsApp6
{
    partial class AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxsurname = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxadress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxphone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(183, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(183, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adress";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(378, 50);
            this.textBoxname.MaxLength = 16;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(181, 27);
            this.textBoxname.TabIndex = 6;
            this.textBoxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxemail_KeyPress);
            // 
            // textBoxsurname
            // 
            this.textBoxsurname.Location = new System.Drawing.Point(378, 122);
            this.textBoxsurname.MaxLength = 16;
            this.textBoxsurname.Name = "textBoxsurname";
            this.textBoxsurname.Size = new System.Drawing.Size(181, 27);
            this.textBoxsurname.TabIndex = 7;
            this.textBoxsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxemail_KeyPress);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(378, 190);
            this.textBoxemail.MaxLength = 30;
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.PlaceholderText = "mail@mail.com";
            this.textBoxemail.Size = new System.Drawing.Size(181, 27);
            this.textBoxemail.TabIndex = 8;
            this.textBoxemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxemail_KeyPress);
            // 
            // textBoxadress
            // 
            this.textBoxadress.Location = new System.Drawing.Point(378, 332);
            this.textBoxadress.MaxLength = 40;
            this.textBoxadress.Name = "textBoxadress";
            this.textBoxadress.Size = new System.Drawing.Size(181, 27);
            this.textBoxadress.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(443, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(378, 257);
            this.textBoxphone.MaxLength = 12;
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.PlaceholderText = "994505555555";
            this.textBoxphone.Size = new System.Drawing.Size(181, 27);
            this.textBoxphone.TabIndex = 11;
            this.textBoxphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxphone_KeyPress);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxadress);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxsurname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add client";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxname;
        private TextBox textBoxsurname;
        private TextBox textBoxemail;
        private TextBox textBoxadress;
        private Button button1;
        private ErrorProvider errorProvider1;
        private TextBox textBoxphone;
    }
}