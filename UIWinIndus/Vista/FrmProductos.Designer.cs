namespace UIWinIndus.Vista
{
    partial class FrmProductos
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
            panelContenedorProducto = new Panel();
            groupBox4 = new GroupBox();
            dgvListarProductos = new DataGridView();
            groupBox3 = new GroupBox();
            btnNProducto = new Button();
            btnNuevaMedida = new Button();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnIngresar = new Button();
            groupBox1 = new GroupBox();
            cbUnidadMedida = new ComboBox();
            cbProducto = new ComboBox();
            txPrecio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelContenedorProducto.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarProductos).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedorProducto
            // 
            panelContenedorProducto.BackColor = SystemColors.ButtonHighlight;
            panelContenedorProducto.Controls.Add(groupBox4);
            panelContenedorProducto.Controls.Add(groupBox3);
            panelContenedorProducto.Controls.Add(groupBox2);
            panelContenedorProducto.Controls.Add(groupBox1);
            panelContenedorProducto.Controls.Add(label3);
            panelContenedorProducto.Location = new Point(1, 0);
            panelContenedorProducto.Name = "panelContenedorProducto";
            panelContenedorProducto.Size = new Size(1080, 612);
            panelContenedorProducto.TabIndex = 17;
            panelContenedorProducto.Paint += panel1_Paint;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvListarProductos);
            groupBox4.Location = new Point(67, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(917, 341);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Listado Productos";
            // 
            // dgvListarProductos
            // 
            dgvListarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarProductos.Location = new Point(21, 42);
            dgvListarProductos.Name = "dgvListarProductos";
            dgvListarProductos.RowHeadersWidth = 51;
            dgvListarProductos.Size = new Size(878, 287);
            dgvListarProductos.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNProducto);
            groupBox3.Controls.Add(btnNuevaMedida);
            groupBox3.Location = new Point(706, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(225, 114);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // btnNProducto
            // 
            btnNProducto.Location = new Point(29, 30);
            btnNProducto.Name = "btnNProducto";
            btnNProducto.Size = new Size(154, 29);
            btnNProducto.TabIndex = 15;
            btnNProducto.Text = "NuevoProducto";
            btnNProducto.UseVisualStyleBackColor = true;
            btnNProducto.Click += btnNProducto_Click_1;
            // 
            // btnNuevaMedida
            // 
            btnNuevaMedida.Location = new Point(29, 68);
            btnNuevaMedida.Name = "btnNuevaMedida";
            btnNuevaMedida.Size = new Size(154, 29);
            btnNuevaMedida.TabIndex = 14;
            btnNuevaMedida.Text = "Nueva Medida";
            btnNuevaMedida.UseVisualStyleBackColor = true;
            btnNuevaMedida.Click += btnNuevaMedida_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnIngresar);
            groupBox2.Location = new Point(510, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 179);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(37, 73);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(37, 38);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbUnidadMedida);
            groupBox1.Controls.Add(cbProducto);
            groupBox1.Controls.Add(txPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(67, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 159);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // cbUnidadMedida
            // 
            cbUnidadMedida.FormattingEnabled = true;
            cbUnidadMedida.Location = new Point(184, 68);
            cbUnidadMedida.Name = "cbUnidadMedida";
            cbUnidadMedida.Size = new Size(210, 28);
            cbUnidadMedida.TabIndex = 8;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(184, 34);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(210, 28);
            cbProducto.TabIndex = 7;
            // 
            // txPrecio
            // 
            txPrecio.Location = new Point(184, 106);
            txPrecio.Name = "txPrecio";
            txPrecio.Size = new Size(210, 27);
            txPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 76);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "Unidad De Medida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 109);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 2;
            label5.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 16);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 1;
            label3.Text = "Seccion Productos";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1080, 612);
            Controls.Add(panelContenedorProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            Text = "FrmProductos";
            panelContenedorProducto.ResumeLayout(false);
            panelContenedorProducto.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarProductos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txNombreProducto;
        private TextBox txUnidadMedida;
        private Button button1;
        private Panel panelContenedorProducto;
        private GroupBox groupBox4;
        private DataGridView dgvListarProductos;
        private GroupBox groupBox3;
        private Button btnNProducto;
        private Button btnNuevaMedida;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnIngresar;
        private GroupBox groupBox1;
        private ComboBox cbUnidadMedida;
        private ComboBox cbProducto;
        private TextBox txPrecio;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}