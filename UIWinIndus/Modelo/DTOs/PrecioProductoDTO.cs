using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public class PrecioProductoDTO
    {
        public int ID_PRECIO { get; set; }

        public int? ID_PRODUCTO { get; set; }

        public int? ID_UNIDADMEDIDA { get; set; }

        public decimal? PRECIO { get; set; }

        public DateOnly? FECHAINICIO { get; set; }

        public DateOnly? FECHAFIN { get; set; }

        public bool? ESTADO { get; set; }

       

    }
}
