namespace UIWinIndus.Vista
{
    partial class FrmUsuarios
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
            txPass = new TextBox();
            txCorreo = new TextBox();
            txNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            bntEditar = new Button();
            bntEliminar = new Button();
            bntCrearUser = new Button();
            groupBox1 = new GroupBox();
            dgvUsuarios = new DataGridView();
            label4 = new Label();
            txId = new TextBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txPass);
            groupBox3.Controls.Add(txCorreo);
            groupBox3.Controls.Add(txNombre);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(202, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(398, 137);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // txPass
            // 
            txPass.Location = new Point(109, 87);
            txPass.Name = "txPass";
            txPass.Size = new Size(254, 27);
            txPass.TabIndex = 7;
            // 
            // txCorreo
            // 
            txCorreo.Location = new Point(109, 53);
            txCorreo.Name = "txCorreo";
            txCorreo.Size = new Size(254, 27);
            txCorreo.TabIndex = 6;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(109, 18);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(254, 27);
            txNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 90);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bntEditar);
            groupBox2.Controls.Add(bntEliminar);
            groupBox2.Controls.Add(bntCrearUser);
            groupBox2.Location = new Point(669, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 147);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(17, 108);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(94, 29);
            bntEditar.TabIndex = 11;
            bntEditar.Text = "Editar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(17, 63);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(94, 29);
            bntEliminar.TabIndex = 10;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // bntCrearUser
            // 
            bntCrearUser.Location = new Point(17, 19);
            bntCrearUser.Name = "bntCrearUser";
            bntCrearUser.Size = new Size(94, 29);
            bntCrearUser.TabIndex = 9;
            bntCrearUser.Text = "Crear";
            bntCrearUser.UseVisualStyleBackColor = true;
            bntCrearUser.Click += bntCrearUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Location = new Point(118, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 380);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(40, 35);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(748, 322);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 77);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 18;
            label4.Text = "ID";
            // 
            // txId
            // 
            txId.Location = new Point(83, 74);
            txId.Name = "txId";
            txId.ReadOnly = true;
            txId.Size = new Size(71, 27);
            txId.TabIndex = 19;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1062, 565);
            Controls.Add(txId);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txPass;
        private TextBox txCorreo;
        private TextBox txNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button bntEditar;
        private Button bntEliminar;
        private Button bntCrearUser;
        private GroupBox groupBox1;
        private DataGridView dgvUsuarios;
        private Label label4;
        private TextBox txId;
    }
}