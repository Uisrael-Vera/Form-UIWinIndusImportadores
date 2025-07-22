using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public class DetalleVentaDTO
    {
        public int ID_DETALLE { get; set; }

        public int? ID_VENTA { get; set; }

        public int? ID_PRECIO { get; set; }

        public int? CANTIDAD { get; set; }

        public decimal? SUBTOTALPRODUCTO { get; set; }

        public decimal? IVATOTAL { get; set; }

        public decimal? TOTALPRODUCTO { get; set; }

        public decimal? UTILIDAD { get; set; }
    }
}
