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
    public partial class FrmUnidadMedida : Form
    {
        private FrmProductos _formProductoPadre;
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;
        public FrmUnidadMedida(FrmProductos formProductoPadre)
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmUnidadMedida_Load;
            _formProductoPadre = formProductoPadre;
        }

        public async Task CargarMedidas()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<UnidadMedidaDTO>>("UnidadMedida/listarUnidadesMedida");
                dgvMedidas.DataSource = listado;
                dgvMedidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar Medidas: {ex.Message}");
            }
        }

        private async void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            await CargarMedidas();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var nuevoMedida = new UnidadMedidaDTO
            {
                NOMBRE = txNomreMedida.Text,
                SIMBOLO = txUnidad.Text,
                TIPO= txTipo.Text,

            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoMedida, "UnidadMedida/CrearUnidadMedida", "UNIDADMEDIDA");
                await CargarMedidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al insertar Tipo Producto: {ex.Message}");
            }
        }
    }
}
