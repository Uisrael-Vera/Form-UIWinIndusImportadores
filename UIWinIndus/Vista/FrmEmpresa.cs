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
    public partial class FrmEmpresa : Form
    {
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;
        public FrmEmpresa()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmEmpresa_Load;
        }


        public async Task CargarEmpresa()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<EmpresasDTO>>("Empresa/listaempresa");
                dgvListarEmpresa.DataSource = listado;
                dgvListarEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar empresas: {ex.Message}");
            }
        }

        private async void FrmEmpresa_Load(object sender, EventArgs e)
        {
            await CargarEmpresa();
        }

        private  void bntCrearEmpresa_Click(object sender, EventArgs e)
        {
            
        }

        private async void bntCrearEmpresa_Click_1(object sender, EventArgs e)
        {
            var nuevoEmpresa = new EmpresasDTO
            {
                CEDULA_RUC = txRuc.Text,
                NOMBRE = txNombre.Text,
                DIRECCION = txDireccion.Text,
                PAGINA_WEB = txPaginaWeb.Text,
                ESTADO = true
            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoEmpresa, "Empresa/CrearEmpresa", "EMPRESA");
                await CargarEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al insertar eMPRESA: {ex.Message}");
            }
        }
    }
}
