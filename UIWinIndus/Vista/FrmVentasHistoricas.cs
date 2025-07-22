using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWinIndus.Controlador;

namespace UIWinIndus.Vista
{
    public partial class FrmVentasHistoricas : Form
    {
        private readonly HttpClient _httpClient;

        private readonly APIIndusServicio _apiIndusServicio;
        private string ApiUrl;

        public FrmVentasHistoricas()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _apiIndusServicio = new APIIndusServicio(ApiUrl);
            Load += FrmVentasHistoricas_Load;
        }


        //Boton para exportar a excel
       

        private void btnAbrirPowerBI_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del ejecutable de Power BI Desktop (ajústala según tu instalación)
                string powerBiPath = @"C:\Program Files\WindowsApps\Microsoft.MicrosoftPowerBIDesktop_2.145.1105.0_x64__8wekyb3d8bbwe\bin\PBIDesktop.exe";

                // Ruta local del archivo PBIX en OneDrive (ajústala según tu PC)
                string pbixPath = @"C:\ProyectoDesarrollo\IndusUIWin\UIWinIndus\Resources\Reportes\VentasHistoricas.pbix";

                if (!System.IO.File.Exists(pbixPath))
                {
                    MessageBox.Show("No se encontró el archivo del reporte. Verifica la ruta.", "Error");
                    return;
                }

                // Abrir Power BI con el archivo
                System.Diagnostics.Process.Start(powerBiPath, $"\"{pbixPath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir Power BI: {ex.Message}", "Error");
            }
        }

        private async  void FrmVentasHistoricas_Load(object sender, EventArgs e)
        {
            await CargarVentasHistoricas();
        }

        private async Task CargarVentasHistoricas()
        {
            try
            {
                var ventas = await _apiIndusServicio.GetAsync<List<UIWinIndus.Modelos.VentaHistoricoDTO>>("ReporteVentas/ventas-historicas");

                dgvVentas.DataSource = ventas;

                // Personalización visual (la puedes mover a un método separado si prefieres)
                dgvVentas.EnableHeadersVisualStyles = false;
                dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
                dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvVentas.RowsDefaultCellStyle.BackColor = Color.White;
                dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

                dgvVentas.BorderStyle = BorderStyle.None;
                dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgvVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 192, 128);
                dgvVentas.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Encabezados personalizados
                CambiarEncabezadosColumnas();

                // Formatos
                FormatearColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error");
            }
        }

        private void CambiarEncabezadosColumnas()
        {
            Dictionary<string, string> encabezados = new()
        {
            { "ID_VENTA", "ID Venta" },
            { "FECHA", "Fecha" },
            { "FORMAPAGO", "Forma de Pago" },
            { "SUBTOTAL", "Subtotal" },
            { "SUBTOTALIVA", "Subtotal IVA" },
            { "TOTALVENTA", "Total Venta" },
            { "EMPRESA", "Empresa" },
            { "CEDULA_RUC", "RUC/Cédula" },
            { "CONTACTO", "Contacto" },
            { "USUARIO", "Usuario" },
            { "PRODUCTO", "Producto" },
            { "UNIDAD_MEDIDA", "Unidad" },
            { "CANTIDAD", "Cantidad" },
            { "PRECIO", "Precio Unitario" },
            { "SUBTOTALPRODUCTO", "Subtotal Producto" },
            { "IVATOTAL", "IVA Total" },
            { "TOTALPRODUCTO", "Total Producto" },
            { "UTILIDAD", "Utilidad" }
        };

            foreach (var kvp in encabezados)
            {
                if (dgvVentas.Columns.Contains(kvp.Key))
                    dgvVentas.Columns[kvp.Key].HeaderText = kvp.Value;
            }
        }
        private void FormatearColumnas()
        {
            // Formato moneda
            foreach (DataGridViewColumn col in dgvVentas.Columns)
            {
                if (col.Name.Contains("SUBTOTAL") || col.Name.Contains("TOTAL") || col.Name.Contains("PRECIO") || col.Name.Contains("UTILIDAD"))
                {
                    col.DefaultCellStyle.Format = "C2";
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            // Fecha
            if (dgvVentas.Columns.Contains("FECHA"))
            {
                dgvVentas.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvVentas.Columns["FECHA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private async void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excelBytes = await _apiIndusServicio.GetBytesAsync("ReporteVentas/ventas-historicas/excel");

                using SaveFileDialog sfd = new()
                {
                    Filter = "Archivos Excel (.xlsx)|.xlsx",
                    FileName = $"Ventas_Historicas_{DateTime.Now:yyyyMMdd}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, excelBytes);
                    MessageBox.Show("Archivo exportado correctamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error");
            }
        }
    }
}