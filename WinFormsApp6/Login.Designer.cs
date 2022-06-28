namespace WinFormsApp6
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpas = new System.Windows.Forms.TextBox();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonregistr = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // textBoxpas
            // 
            this.textBoxpas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxpas.Location = new System.Drawing.Point(320, 205);
            this.textBoxpas.MaxLength = 14;
            this.textBoxpas.Name = "textBoxpas";
            this.textBoxpas.Size = new System.Drawing.Size(197, 27);
            this.textBoxpas.TabIndex = 1;
            this.textBoxpas.UseSystemPasswordChar = true;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxlogin.Location = new System.Drawing.Point(320, 113);
            this.textBoxlogin.MaxLength = 14;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(197, 27);
            this.textBoxlogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(184, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Нет аккаунта?";
            // 
            // buttonregistr
            // 
            this.buttonregistr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonregistr.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonregistr.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonregistr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonregistr.ForeColor = System.Drawing.Color.White;
            this.buttonregistr.Location = new System.Drawing.Point(602, 373);
            this.buttonregistr.Name = "buttonregistr";
            this.buttonregistr.Size = new System.Drawing.Size(114, 39);
            this.buttonregistr.TabIndex = 5;
            this.buttonregistr.Text = "Registration";
            this.buttonregistr.UseVisualStyleBackColor = false;
            this.buttonregistr.Click += new System.EventHandler(this.button1_Click);
            this.buttonregistr.MouseEnter += new System.EventHandler(this.buttonlogin_MouseEnter);
            this.buttonregistr.MouseLeave += new System.EventHandler(this.buttonregistr_MouseLeave);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonlogin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(358, 278);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(107, 37);
            this.buttonlogin.TabIndex = 6;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            this.buttonlogin.MouseEnter += new System.EventHandler(this.buttonlogin_MouseEnter);
            this.buttonlogin.MouseLeave += new System.EventHandler(this.buttonregistr_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(794, 454);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonregistr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.textBoxpas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(770, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxpas;
        private TextBox textBoxlogin;
        private Label label2;
        private Label label3;
        private Button buttonregistr;
        private Button buttonlogin;
        private ErrorProvider errorProvider1;
    }
}