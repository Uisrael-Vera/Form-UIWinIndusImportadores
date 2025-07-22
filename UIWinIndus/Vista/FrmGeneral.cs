using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UIWinIndus.Vista
{
    public partial class FrmGeneral : Form
    {

        public FrmGeneral()
        {
            InitializeComponent();
            this.Load += FrmGeneral_Load;
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmProductos(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessange(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessange(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHijo(Form formulario)
        {
            panelContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmInicio());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmUsuarios());
        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmEmpresa());
        }

        private void bntContacto_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmContacto());
        }

        private void btnVenta_Proforma_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmVenta_Proforma());
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de ventas históricas
            FrmVentasHistoricas frmHistorico = new FrmVentasHistoricas();
            frmHistorico.ShowDialog(); // ShowDialog para que se abra como ventana modal
        }
    }
}
