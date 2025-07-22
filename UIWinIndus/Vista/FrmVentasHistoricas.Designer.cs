namespace UIWinIndus.Vista
{
    partial class FrmVentasHistoricas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAbrirPowerBI;

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
            lblTitulo = new Label();
            btnCargar = new Button();
            btnExportarExcel = new Button();
            dgvVentas = new DataGridView();
            btnAbrirPowerBI = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ventas Históricas";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(20, 70);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(150, 40);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Ventas";

            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(180, 70);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(150, 40);
            btnExportarExcel.TabIndex = 2;
            btnExportarExcel.Text = "Exportar a Excel";
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeight = 29;
            dgvVentas.Location = new Point(20, 130);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(950, 400);
            dgvVentas.TabIndex = 3;
            // 
            // btnAbrirPowerBI
            // 
            btnAbrirPowerBI.BackColor = Color.FromArgb(40, 167, 69);
            btnAbrirPowerBI.Cursor = Cursors.Hand;
            btnAbrirPowerBI.FlatAppearance.BorderSize = 0;
            btnAbrirPowerBI.FlatStyle = FlatStyle.Flat;
            btnAbrirPowerBI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAbrirPowerBI.ForeColor = Color.White;
            btnAbrirPowerBI.Location = new Point(340, 70);
            btnAbrirPowerBI.Name = "btnAbrirPowerBI";
            btnAbrirPowerBI.Size = new Size(150, 40);
            btnAbrirPowerBI.TabIndex = 4;
            btnAbrirPowerBI.Text = "Abrir en Power BI";
            btnAbrirPowerBI.UseVisualStyleBackColor = false;
            btnAbrirPowerBI.Click += btnAbrirPowerBI_Click;
            // 
            // FrmVentasHistoricas
            // 
            ClientSize = new Size(984, 561);
            Controls.Add(lblTitulo);
            Controls.Add(btnCargar);
            Controls.Add(btnExportarExcel);
            Controls.Add(dgvVentas);
            Controls.Add(btnAbrirPowerBI);
            Name = "FrmVentasHistoricas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas Históricas";
            Load += FrmVentasHistoricas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();





        }
    }
}