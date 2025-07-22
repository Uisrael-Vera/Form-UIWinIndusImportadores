using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWinIndus.Controlador;
using UIWinIndus.Modelo.DTOs;

namespace UIWinIndus.Vista
{
    public partial class FrmProdutos_Ingreso : Form
    {
        private FrmProductos _formProductoPadre;
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;
        public FrmProdutos_Ingreso(FrmProductos formProductoPadre)
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmProdutos_Ingreso_Load;
            _formProductoPadre = formProductoPadre;

        }

        public async Task CargarProducto()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<ProductoDTO>>("Producto/listarProducto");
                dgvProducto.DataSource = listado;
                dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar productos: {ex.Message}");
            }
        }

        private async void FrmProdutos_Ingreso_Load(object sender, EventArgs e)
        {
            await CargarProducto();
        }

  
        private async void btnCrearProducto_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new ProductoDTO
            {
                NOMBRE = txIngresoProducto.Text
            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoProducto, "Producto/CrearProducto", "PRODCUTO");
                await CargarProducto();
            }catch(Exception ex)
            {
                MessageBox.Show($"Error:al insertar Tipo Producto: {ex.Message}");
            }
        }
    }
}
