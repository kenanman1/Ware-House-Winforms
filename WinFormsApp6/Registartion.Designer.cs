namespace WinFormsApp6
{
    partial class Registartion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registartion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonconfirm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxrepeatpas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your password";
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxlogin.Location = new System.Drawing.Point(361, 192);
            this.textBoxlogin.MaxLength = 16;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(201, 27);
            this.textBoxlogin.TabIndex = 2;
            this.textBoxlogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlogin_KeyPress);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxpassword.Location = new System.Drawing.Point(361, 256);
            this.textBoxpassword.MaxLength = 16;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(201, 27);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(602, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonconfirm
            // 
            this.buttonconfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonconfirm.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonconfirm.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonconfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonconfirm.ForeColor = System.Drawing.Color.White;
            this.buttonconfirm.Location = new System.Drawing.Point(361, 403);
            this.buttonconfirm.Name = "buttonconfirm";
            this.buttonconfirm.Size = new System.Drawing.Size(94, 50);
            this.buttonconfirm.TabIndex = 5;
            this.buttonconfirm.Text = "confirm";
            this.buttonconfirm.UseVisualStyleBackColor = false;
            this.buttonconfirm.Click += new System.EventHandler(this.buttonconfirm_Click);
            this.buttonconfirm.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.buttonconfirm.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxrepeatpas
            // 
            this.textBoxrepeatpas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxrepeatpas.Location = new System.Drawing.Point(361, 328);
            this.textBoxrepeatpas.Name = "textBoxrepeatpas";
            this.textBoxrepeatpas.Size = new System.Drawing.Size(201, 27);
            this.textBoxrepeatpas.TabIndex = 6;
            this.textBoxrepeatpas.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(602, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter your name";
            // 
            // textBoxname
            // 
            this.textBoxname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxname.Location = new System.Drawing.Point(361, 46);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(201, 27);
            this.textBoxname.TabIndex = 10;
            this.textBoxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlogin_KeyPress);
            // 
            // textBoxsurname
            // 
            this.textBoxsurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxsurname.Location = new System.Drawing.Point(361, 120);
            this.textBoxsurname.Name = "textBoxsurname";
            this.textBoxsurname.Size = new System.Drawing.Size(201, 27);
            this.textBoxsurname.TabIndex = 12;
            this.textBoxsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlogin_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(112, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter your surname";
            // 
            // Registartion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(772, 492);
            this.Controls.Add(this.textBoxsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxrepeatpas);
            this.Controls.Add(this.buttonconfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Registartion";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxlogin;
        private TextBox textBoxpassword;
        private Button button1;
        private ToolTip toolTip1;
        private Button buttonconfirm;
        private ErrorProvider errorProvider1;
        private TextBox textBoxrepeatpas;
        private Label label3;
        private Button button2;
        private TextBox textBoxsurname;
        private Label label5;
        private TextBox textBoxname;
        private Label label4;
    }
}