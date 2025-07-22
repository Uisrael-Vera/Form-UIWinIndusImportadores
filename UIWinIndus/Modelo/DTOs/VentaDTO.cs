using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public  class VentaDTO
    {
        public int ID_VENTA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_TIPOVENTA { get; set; }

        public int? ID_USUARIO { get; set; }

        public DateOnly? FECHA { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public decimal? SUBTOTALIVA { get; set; }

        public decimal? TOTALVENTA { get; set; }

        public string FORMAPAGO { get; set; }
    }
}
