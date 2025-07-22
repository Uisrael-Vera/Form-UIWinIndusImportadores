namespace UIWinIndus.Vista
{
    partial class FrmVenta_Proforma
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
            panel1 = new Panel();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dgvDetalleVenta = new DataGridView();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(-2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 564);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(493, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 32);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo Venta/Proforma";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(274, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Empresa";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(9, 23);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(944, 329);
            dgvDetalleVenta.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDetalleVenta);
            groupBox1.Location = new Point(32, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(980, 367);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FrmVenta_Proforma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1062, 565);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVenta_Proforma";
            Text = "FrmVenta_Proforma";
            Load += FrmVenta_Proforma_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dgvDetalleVenta;
    }
}