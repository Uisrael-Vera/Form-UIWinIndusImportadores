namespace UIWinIndus.Vista
{
    partial class FrmUnidadMedida
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
            txNomreMedida = new TextBox();
            txUnidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txTipo = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            dgvMedidas = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 58);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Medida";
            // 
            // txNomreMedida
            // 
            txNomreMedida.Location = new Point(233, 51);
            txNomreMedida.Name = "txNomreMedida";
            txNomreMedida.Size = new Size(141, 27);
            txNomreMedida.TabIndex = 1;
            // 
            // txUnidad
            // 
            txUnidad.Location = new Point(233, 84);
            txUnidad.Name = "txUnidad";
            txUnidad.Size = new Size(141, 27);
            txUnidad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Unidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // txTipo
            // 
            txTipo.Location = new Point(233, 117);
            txTipo.Name = "txTipo";
            txTipo.Size = new Size(141, 27);
            txTipo.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(422, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txTipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txUnidad);
            groupBox1.Controls.Add(txNomreMedida);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(312, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 166);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Nueva Medida";
            // 
            // dgvMedidas
            // 
            dgvMedidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedidas.Location = new Point(17, 26);
            dgvMedidas.Name = "dgvMedidas";
            dgvMedidas.RowHeadersWidth = 51;
            dgvMedidas.Size = new Size(406, 237);
            dgvMedidas.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMedidas);
            groupBox2.Location = new Point(388, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 280);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Medidas";
            // 
            // FrmUnidadMedida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1080, 612);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUnidadMedida";
            Text = "FrmUnidadMedida";
            Load += FrmUnidadMedida_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txNomreMedida;
        private TextBox txUnidad;
        private Label label2;
        private Label label3;
        private TextBox txTipo;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dgvMedidas;
        private GroupBox groupBox2;
    }
}