namespace UIWinIndus.Vista
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panelFondo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelFondo = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            txtCorreo = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblResultado = new Label();
            panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(245, 247, 250);
            panelFondo.Controls.Add(pictureBox1);
            panelFondo.Controls.Add(lblTitulo);
            panelFondo.Controls.Add(txtCorreo);
            panelFondo.Controls.Add(txtPassword);
            panelFondo.Controls.Add(btnLogin);
            panelFondo.Controls.Add(lblResultado);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(400, 400);
            panelFondo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_INDUS;
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(110, 124);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.Location = new Point(60, 190);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(280, 32);
            txtCorreo.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(60, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(280, 32);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F);
            lblResultado.ForeColor = Color.FromArgb(52, 58, 64);
            lblResultado.Location = new Point(12, 359);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 23);
            lblResultado.TabIndex = 4;
            // 
            // LoginForm
            // 
            ClientSize = new Size(400, 400);
            Controls.Add(panelFondo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}