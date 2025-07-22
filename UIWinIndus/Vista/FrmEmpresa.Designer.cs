namespace UIWinIndus.Vista
{
    partial class FrmEmpresa
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
            dgvListarEmpresa = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txRuc = new TextBox();
            txNombre = new TextBox();
            txDireccion = new TextBox();
            txPaginaWeb = new TextBox();
            bntCrearEmpresa = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvListarEmpresa).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListarEmpresa
            // 
            dgvListarEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarEmpresa.Location = new Point(28, 26);
            dgvListarEmpresa.Name = "dgvListarEmpresa";
            dgvListarEmpresa.RowHeadersWidth = 51;
            dgvListarEmpresa.Size = new Size(782, 345);
            dgvListarEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "RUC/CI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 90);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 126);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 4;
            label4.Text = "PaginaWeb";
            // 
            // txRuc
            // 
            txRuc.Location = new Point(109, 18);
            txRuc.Name = "txRuc";
            txRuc.Size = new Size(254, 27);
            txRuc.TabIndex = 5;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(109, 53);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(254, 27);
            txNombre.TabIndex = 6;
            // 
            // txDireccion
            // 
            txDireccion.Location = new Point(109, 87);
            txDireccion.Name = "txDireccion";
            txDireccion.Size = new Size(254, 27);
            txDireccion.TabIndex = 7;
            // 
            // txPaginaWeb
            // 
            txPaginaWeb.Location = new Point(109, 123);
            txPaginaWeb.Name = "txPaginaWeb";
            txPaginaWeb.Size = new Size(366, 27);
            txPaginaWeb.TabIndex = 8;
            // 
            // bntCrearEmpresa
            // 
            bntCrearEmpresa.Location = new Point(17, 19);
            bntCrearEmpresa.Name = "bntCrearEmpresa";
            bntCrearEmpresa.Size = new Size(94, 29);
            bntCrearEmpresa.TabIndex = 9;
            bntCrearEmpresa.Text = "Crear";
            bntCrearEmpresa.UseVisualStyleBackColor = true;
            bntCrearEmpresa.Click += bntCrearEmpresa_Click_1;
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
            // button3
            // 
            button3.Location = new Point(17, 108);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvListarEmpresa);
            groupBox1.Location = new Point(92, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 380);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Empresas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(bntCrearEmpresa);
            groupBox2.Location = new Point(719, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 160);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txPaginaWeb);
            groupBox3.Controls.Add(txDireccion);
            groupBox3.Controls.Add(txNombre);
            groupBox3.Controls.Add(txRuc);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(101, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 158);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 612);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmpresa";
            Text = "FrmEmpresa";
            Load += FrmEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarEmpresa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarEmpresa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txRuc;
        private TextBox txNombre;
        private TextBox txDireccion;
        private TextBox txPaginaWeb;
        private Button bntCrearEmpresa;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}