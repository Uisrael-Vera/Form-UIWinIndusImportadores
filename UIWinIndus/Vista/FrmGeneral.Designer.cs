namespace UIWinIndus.Vista
{
    partial class FrmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneral));
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel7 = new Panel();
            btnHistorico = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            bntContacto = new Button();
            btnVenta_Proforma = new Button();
            panel4 = new Panel();
            bntNotificaciones = new Button();
            panel3 = new Panel();
            bntCliente = new Button();
            panel2 = new Panel();
            bntUsuarios = new Button();
            panel1 = new Panel();
            btnProductos = new Button();
            btnInicio = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(29, 112, 183);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 38);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1232, 7);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1201, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1232, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1263, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = SystemColors.ControlLight;
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(btnHistorico);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(bntContacto);
            MenuVertical.Controls.Add(btnVenta_Proforma);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(bntNotificaciones);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(bntCliente);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(bntUsuarios);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(btnInicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 612);
            MenuVertical.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 52, 138);
            panel7.Location = new Point(3, 416);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 35);
            panel7.TabIndex = 14;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = SystemColors.ControlLight;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Location = new Point(6, 416);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(211, 35);
            btnHistorico.TabIndex = 13;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(40, 52, 138);
            panel6.Location = new Point(3, 375);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 35);
            panel6.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(40, 52, 138);
            panel5.Location = new Point(3, 334);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 35);
            panel5.TabIndex = 10;
            // 
            // bntContacto
            // 
            bntContacto.BackColor = SystemColors.ControlLight;
            bntContacto.FlatAppearance.BorderSize = 0;
            bntContacto.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            bntContacto.FlatStyle = FlatStyle.Flat;
            bntContacto.Location = new Point(6, 375);
            bntContacto.Name = "bntContacto";
            bntContacto.Size = new Size(211, 35);
            bntContacto.TabIndex = 11;
            bntContacto.Text = "Contactos";
            bntContacto.UseVisualStyleBackColor = false;
            bntContacto.Click += bntContacto_Click;
            // 
            // btnVenta_Proforma
            // 
            btnVenta_Proforma.BackColor = SystemColors.ControlLight;
            btnVenta_Proforma.FlatAppearance.BorderSize = 0;
            btnVenta_Proforma.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            btnVenta_Proforma.FlatStyle = FlatStyle.Flat;
            btnVenta_Proforma.Location = new Point(6, 334);
            btnVenta_Proforma.Name = "btnVenta_Proforma";
            btnVenta_Proforma.Size = new Size(211, 35);
            btnVenta_Proforma.TabIndex = 9;
            btnVenta_Proforma.Text = "Ventas/Proformas";
            btnVenta_Proforma.UseVisualStyleBackColor = false;
            btnVenta_Proforma.Click += btnVenta_Proforma_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 52, 138);
            panel4.Location = new Point(3, 293);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 35);
            panel4.TabIndex = 8;
            // 
            // bntNotificaciones
            // 
            bntNotificaciones.BackColor = SystemColors.ControlLight;
            bntNotificaciones.FlatAppearance.BorderSize = 0;
            bntNotificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            bntNotificaciones.FlatStyle = FlatStyle.Flat;
            bntNotificaciones.Location = new Point(6, 293);
            bntNotificaciones.Name = "bntNotificaciones";
            bntNotificaciones.Size = new Size(211, 35);
            bntNotificaciones.TabIndex = 7;
            bntNotificaciones.Text = "Notificaciones";
            bntNotificaciones.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 52, 138);
            panel3.Location = new Point(3, 252);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 35);
            panel3.TabIndex = 6;
            // 
            // bntCliente
            // 
            bntCliente.BackColor = SystemColors.ControlLight;
            bntCliente.FlatAppearance.BorderSize = 0;
            bntCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            bntCliente.FlatStyle = FlatStyle.Flat;
            bntCliente.Location = new Point(6, 252);
            bntCliente.Name = "bntCliente";
            bntCliente.Size = new Size(211, 35);
            bntCliente.TabIndex = 5;
            bntCliente.Text = "Clientes/Empresas";
            bntCliente.UseVisualStyleBackColor = false;
            bntCliente.Click += bntCliente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 52, 138);
            panel2.Location = new Point(3, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 35);
            panel2.TabIndex = 4;
            // 
            // bntUsuarios
            // 
            bntUsuarios.BackColor = SystemColors.ControlLight;
            bntUsuarios.FlatAppearance.BorderSize = 0;
            bntUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            bntUsuarios.FlatStyle = FlatStyle.Flat;
            bntUsuarios.Location = new Point(6, 211);
            bntUsuarios.Name = "bntUsuarios";
            bntUsuarios.Size = new Size(211, 35);
            bntUsuarios.TabIndex = 3;
            bntUsuarios.Text = "Usuarios";
            bntUsuarios.UseVisualStyleBackColor = false;
            bntUsuarios.Click += bntUsuarios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 52, 138);
            panel1.Location = new Point(3, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 35);
            panel1.TabIndex = 2;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ControlLight;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 27, 114);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Location = new Point(6, 170);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(211, 35);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += button1_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(214, 98);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Window;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 38);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1080, 612);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FrmGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGeneral";
            Text = "FrmGeneral";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnInicio;
        private Button btnProductos;
        private Panel panel1;
        private Panel panel4;
        private Button bntNotificaciones;
        private Panel panel3;
        private Button bntCliente;
        private Panel panel5;
        private Button btnVenta_Proforma;
        private Panel panel2;
        private Button bntUsuarios;
        private Panel panel7;
        private Button btnHistorico;
        private Panel panel6;
        private Button bntContacto;
    }
}