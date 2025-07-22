using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIWinIndus.Modelos
{
    public class VentaHistoricoDTO
    {
        //public int ID_VENTA { get; set; }
        public DateTime? FECHA { get; set; }
        public string FORMAPAGO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal SUBTOTALIVA { get; set; }
        public decimal TOTALVENTA { get; set; }
        // public int ID_EMPRESA { get; set; }
        public string EMPRESA { get; set; }
        public string CEDULA_RUC { get; set; }
        public string CONTACTO { get; set; }
        public string USUARIO { get; set; }
        public string PRODUCTO { get; set; }
        public string UNIDAD_MEDIDA { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public decimal SUBTOTALPRODUCTO { get; set; }
        public decimal IVATOTAL { get; set; }
        public decimal TOTALPRODUCTO { get; set; }
        public decimal UTILIDAD { get; set; }
    }
}