namespace UIWinIndus.Vista
{
    partial class FrmContacto
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
            groupBox3 = new GroupBox();
            txCedula = new TextBox();
            txPhone = new TextBox();
            txApellido = new TextBox();
            txNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            bntCrearContacto = new Button();
            groupBox1 = new GroupBox();
            dgvListarContacto = new DataGridView();
            txCorreo = new TextBox();
            txCargo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbEmpresas = new ComboBox();
            groupBox4 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarContacto).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txCedula);
            groupBox3.Controls.Add(txPhone);
            groupBox3.Controls.Add(txApellido);
            groupBox3.Controls.Add(txNombre);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(46, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 158);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // txCedula
            // 
            txCedula.Location = new Point(109, 123);
            txCedula.Name = "txCedula";
            txCedula.Size = new Size(254, 27);
            txCedula.TabIndex = 8;
            // 
            // txPhone
            // 
            txPhone.Location = new Point(109, 87);
            txPhone.Name = "txPhone";
            txPhone.Size = new Size(254, 27);
            txPhone.TabIndex = 7;
            // 
            // txApellido
            // 
            txApellido.Location = new Point(109, 53);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(254, 27);
            txApellido.TabIndex = 6;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(109, 18);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(254, 27);
            txNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 126);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 90);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(bntCrearContacto);
            groupBox2.Location = new Point(841, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 160);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(17, 108);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 63);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // bntCrearContacto
            // 
            bntCrearContacto.Location = new Point(17, 19);
            bntCrearContacto.Name = "bntCrearContacto";
            bntCrearContacto.Size = new Size(94, 29);
            bntCrearContacto.TabIndex = 9;
            bntCrearContacto.Text = "Crear";
            bntCrearContacto.UseVisualStyleBackColor = true;
            bntCrearContacto.Click += bntCrearContacto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvListarContacto);
            groupBox1.Location = new Point(117, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 380);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Contactos";
            // 
            // dgvListarContacto
            // 
            dgvListarContacto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarContacto.Location = new Point(28, 26);
            dgvListarContacto.Name = "dgvListarContacto";
            dgvListarContacto.RowHeadersWidth = 51;
            dgvListarContacto.Size = new Size(782, 345);
            dgvListarContacto.TabIndex = 0;
            // 
            // txCorreo
            // 
            txCorreo.Location = new Point(114, 62);
            txCorreo.Name = "txCorreo";
            txCorreo.Size = new Size(229, 27);
            txCorreo.TabIndex = 21;
            // 
            // txCargo
            // 
            txCargo.Location = new Point(114, 26);
            txCargo.Name = "txCargo";
            txCargo.Size = new Size(229, 27);
            txCargo.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 65);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 19;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 29);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 18;
            label6.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 102);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 22;
            label7.Text = "Empresa";
            // 
            // cbEmpresas
            // 
            cbEmpresas.FormattingEnabled = true;
            cbEmpresas.Location = new Point(114, 99);
            cbEmpresas.Name = "cbEmpresas";
            cbEmpresas.Size = new Size(229, 28);
            cbEmpresas.TabIndex = 23;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbEmpresas);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txCorreo);
            groupBox4.Controls.Add(txCargo);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(448, 29);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(361, 158);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            // 
            // FrmContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 612);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContacto";
            Text = "FrmContacto";
            Load += FrmContacto_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarContacto).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txCedula;
        private TextBox txPhone;
        private TextBox txApellido;
        private TextBox txNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button bntCrearContacto;
        private GroupBox groupBox1;
        private DataGridView dgvListarContacto;
        private TextBox txCorreo;
        private TextBox txCargo;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbEmpresas;
        private GroupBox groupBox4;
    }
}