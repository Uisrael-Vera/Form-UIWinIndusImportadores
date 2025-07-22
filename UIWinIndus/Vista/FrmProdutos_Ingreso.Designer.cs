namespace UIWinIndus.Vista
{
    partial class FrmProdutos_Ingreso
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
            label1 = new Label();
            txIngresoProducto = new TextBox();
            groupBox1 = new GroupBox();
            dgvProducto = new DataGridView();
            groupBox2 = new GroupBox();
            btnCrearProducto = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Producto";
            // 
            // txIngresoProducto
            // 
            txIngresoProducto.Location = new Point(194, 37);
            txIngresoProducto.Name = "txIngresoProducto";
            txIngresoProducto.Size = new Size(178, 27);
            txIngresoProducto.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txIngresoProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(311, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 83);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(27, 26);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(632, 230);
            dgvProducto.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvProducto);
            groupBox2.Location = new Point(269, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 263);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(12, 26);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(94, 29);
            btnCrearProducto.TabIndex = 6;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCrearProducto);
            groupBox3.Location = new Point(718, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 82);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // FrmProdutos_Ingreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1080, 612);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProdutos_Ingreso";
            Text = "FrmProdutos_Ingreso";
            Load += FrmProdutos_Ingreso_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txIngresoProducto;
        private GroupBox groupBox1;
        private DataGridView dgvProducto;
        private GroupBox groupBox2;
        private Button btnCrearProducto;
        private GroupBox groupBox3;
    }
}