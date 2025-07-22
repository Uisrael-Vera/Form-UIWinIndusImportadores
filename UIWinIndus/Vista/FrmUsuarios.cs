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
    public partial class FrmUsuarios : Form
    {
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;
        public FrmUsuarios()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmUsuarios_Load;
        }

        private async void FrmUsuarios_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        public async Task CargarUsuarios()
        {
            try
            {
                var listado = await _apiIndusServicio.GetAsync<List<UsuariosDTO>>("Usuario/listausuariosactivos");
                dgvUsuarios.DataSource = listado;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Al listar usuarios: {ex.Message}");
            }
        }

        private async void bntCrearUser_Click(object sender, EventArgs e)
        {
            var nuevoUsuario = new UsuariosDTO
            {
                NOMBRE = txNombre.Text,
                CORREO = txCorreo.Text,
                PASSWORD = txPass.Text,
                ESTADO = true,

            };
            try
            {
                await _apiIndusServicio.CrearEntidad(nuevoUsuario, "usuario/CrearUsuario", "USUARIO");
                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al insertar esre suario: {ex.Message}");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no es el encabezado
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txId.Text = fila.Cells["ID_USUARIO"].Value?.ToString();
                txNombre.Text = fila.Cells["NOMBRE"].Value?.ToString();
                txCorreo.Text = fila.Cells["CORREO"].Value?.ToString();
                txPass.Text = fila.Cells["PASSWORD"].Value?.ToString();
            }
        }

        private async void bntEliminar_Click(object sender, EventArgs e)
        {
            var nuevoUsuario = new UsuariosDTO
            {
                ID_USUARIO = int.Parse(txId.Text),
                NOMBRE = txNombre.Text,
                CORREO = txCorreo.Text,
                PASSWORD = txPass.Text,
                ESTADO = false,

            };
            try
            {
                await _apiIndusServicio.EditarEntidad(nuevoUsuario, "usuario/actualizarUsuarios", "USUARIO");
                await CargarUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al eliminar esre suario: {ex.Message}");
            }

        }
        private void LimpiarFormulario()
        {
            // Limpiar TextBox
            txId.Text = "";
            txNombre.Text = "";
            txCorreo.Text = "";
            txPass.Text = "";

        }

        private async void bntEditar_Click(object sender, EventArgs e)
        {
            var nuevoUsuario = new UsuariosDTO
            {
                ID_USUARIO = int.Parse(txId.Text),
                NOMBRE = txNombre.Text,
                CORREO = txCorreo.Text,
                PASSWORD = txPass.Text,
                ESTADO = true,

            };
            try
            {
                await _apiIndusServicio.EditarEntidad(nuevoUsuario, "usuario/actualizarUsuarios", "USUARIO");
                await CargarUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:al editar este usuario: {ex.Message}");
            }
        }
    }
}
