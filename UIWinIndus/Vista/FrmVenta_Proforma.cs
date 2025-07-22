using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWinIndus.Modelo.DTOs;

namespace UIWinIndus.Vista
{
    public partial class FrmVenta_Proforma : Form
    {
        public FrmVenta_Proforma()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVenta_Proforma_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarGrid()
        {
            dgvDetalleVenta.AllowUserToAddRows = true;  // Permite agregar filas nuevas
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvDetalleVenta.Columns.Clear();

            // Columna ComboBox para Producto (puedes asignar el DataSource después)
            var colProducto = new DataGridViewComboBoxColumn
            {
                HeaderText = "Producto",
                Name = "Producto",
                ValueMember = "ID_PRODUCTO",
                DisplayMember = "NOMBRE",
                //DataSource = ,  // Aquí asignas tu lista de productos
                DropDownWidth = 200,
                Width = 150
            };
            dgvDetalleVenta.Columns.Add(colProducto);

            // Cantidad editable (numérica)
            var colCantidad = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                Name = "Cantidad",
                Width = 80
            };
            dgvDetalleVenta.Columns.Add(colCantidad);

            // Precio editable (decimal)
            var colPrecio = new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                Name = "Precio",
                Width = 100
            };
            dgvDetalleVenta.Columns.Add(colPrecio);

            // Subtotal (readonly)
            var colSubtotal = new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                Name = "Subtotal",
                ReadOnly = true,
                Width = 100
            };
            dgvDetalleVenta.Columns.Add(colSubtotal);
        }
    }
}
