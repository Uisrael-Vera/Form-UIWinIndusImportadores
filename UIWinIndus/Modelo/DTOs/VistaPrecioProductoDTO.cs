using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public class VistaPrecioProductoDTO
    {

        public string NombreProducto { get; set; }

        public string UnidadMedida { get; set; }

        public decimal? PRECIO { get; set; }

        public DateOnly? FECHAINICIO { get; set; }

        public DateOnly? FECHAFIN { get; set; }

        public bool? ESTADO { get; set; }

       
    }
}
