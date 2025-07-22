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
    public partial class FrmContacto : Form
    {
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;
        public FrmContacto()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmContacto_Load;
        }

        private async void FrmContacto_Load(object sender, EventArgs e)
        {
            await cargarContactos();
            await cargarListaEmpresas();
        }

        private async Task cargarContactos()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<ContactoDTO>>("Contacto/listarContacto");
                dgvListarContacto.DataSource = listado;
                dgvListarContacto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar contactos: {ex.Message}");
            }
        }
        private async Task cargarListaEmpresas()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<EmpresasDTO>>("Empresa/listaempresa");
                cbEmpresas.DataSource = listado;
                cbEmpresas.ValueMember = "ID_EMPRESA";
                cbEmpresas.DisplayMember = "NOMBRE";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar medidas: {ex.Message}");
            }
        }

        private async void bntCrearContacto_Click(object sender, EventArgs e)
        {

            var nuevoContacto = new ContactoDTO
            {
                NOMBRE= txNombre.Text,
                APELLIDO= txApellido.Text,
                TELEFONO = txPhone.Text,
                CEDULA = txCedula.Text,
                CARGO = txCargo.Text,
                CORREO = txCorreo.Text,
                ID_EMPRESA = Convert.ToInt32(cbEmpresas.SelectedValue),
                ESTADO = true

            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoContacto, "Contacto/CrearContacto", "CONTACTO");
                await cargarContactos();
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
            txNombre.Text = "";
            txApellido.Text = "";
            txPhone.Text = "";
            txCedula.Text = "";
            txCargo.Text = "";
            txCorreo.Text = "";

            // Restablecer ComboBox
            cbEmpresas.SelectedIndex = -1;

            
        }
    }
}
