using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWinIndus.Controlador;

namespace UIWinIndus.Vista
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;

        public LoginForm()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += LoginForm_Load;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var correo = txtCorreo.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Debes ingresar correo y contraseña.";
                return;
            }

            var loginData = new
            {
                correo,
               password
            };

            try
            {
                var response = await _apiIndusServicio.PostAsync<object>("Usuario/login", loginData);

                if (response != null)
                {
                    lblResultado.ForeColor = System.Drawing.Color.Green;
                    lblResultado.Text = "¡Bienvenido!";

                    // Esperar un momento para mostrar el mensaje
                    await Task.Delay(800);

                    // Abrir FrmGeneral
                    var frm = new UIWinIndus.Vista.FrmGeneral();

                    // Manejar evento de cierre para volver al login si el usuario sale
                    frm.FormClosed += (s, args) =>
                    {
                        this.Show();   // Mostrar de nuevo el login
                        txtPassword.Clear();
                        lblResultado.Text = "";
                    };

                    frm.Show();
                    this.Hide(); // Ocultar login mientras FrmGeneral está abierto
                }
                else
                {
                    lblResultado.ForeColor = System.Drawing.Color.Red;
                    lblResultado.Text = "Correo o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = $"Error de conexión: {ex.Message}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}