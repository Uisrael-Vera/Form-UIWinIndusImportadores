using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWinIndus.Controlador;
using UIWinIndus.Modelo.DTOs;

namespace UIWinIndus.Vista
{
    public partial class FrmProductos : Form
    {
        private FrmGeneral _formGeneral;
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;



        public FrmProductos(FrmGeneral frmGeneral)
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmProductos_Load;
            _formGeneral = frmGeneral;


        }

        private async Task cargarListaProducto()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<ProductoDTO>>("Producto/listarProducto");
                cbProducto.DataSource = listado;
                cbProducto.ValueMember = "ID_PRODUCTO";
                cbProducto.DisplayMember = "NOMBRE";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar productos: {ex.Message}");
            }
        }
        private async Task cargarListaMedida()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<UnidadMedidaDTO>>("UnidadMedida/listarUnidadesMedida");
                cbUnidadMedida.DataSource = listado;
                cbUnidadMedida.ValueMember = "ID_UNIDADMEDIDA";
                cbUnidadMedida.DisplayMember = "NOMBRE";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar medidas: {ex.Message}");
            }
        }

        private async Task cargarPrecioProducto()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<VistaPrecioProductoDTO>>("PrecioProducto/listarPreciosPorProducto");
                dgvListarProductos.DataSource = listado;
                dgvListarProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar productos: {ex.Message}");
            }
        }

        private async void FrmProductos_Load(object sender, EventArgs e)
        {
            await cargarPrecioProducto();
            await cargarListaProducto();
            await cargarListaMedida();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AbrirFormularioEnPanelInterno(Form formulario)
        {
            panelContenedorProducto.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedorProducto.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnNProducto_Click(object sender, EventArgs e)
        {



        }

        private void btnNProducto_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelInterno(new FrmProdutos_Ingreso(this));
        }

        private void btnNuevaMedida_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelInterno(new FrmUnidadMedida(this));
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var nuevoProucto = new PrecioProductoDTO
            {
                ID_PRODUCTO = Convert.ToInt32(cbProducto.SelectedValue),
                ID_UNIDADMEDIDA = Convert.ToInt32(cbUnidadMedida.SelectedValue),
                PRECIO = Convert.ToDecimal(txPrecio.Text),
                ESTADO = true,
                FECHAINICIO = DateOnly.FromDateTime(DateTime.Today),
                FECHAFIN= null
            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoProucto, "PrecioProducto/CrearPrecioProducto", "PRECIOPRODUCTO");
                await cargarPrecioProducto();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al insertar es: {ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            // Limpiar TextBox
            txPrecio.Text = "";

            // Restablecer ComboBox
            cbProducto.SelectedIndex = -1;
            cbUnidadMedida.SelectedIndex = -1;

        }
    }
}
