using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public class ContactoDTO
    {
        public int ID_CONTACTO { get; set; }

        public int? ID_EMPRESA { get; set; }

        public string NOMBRE { get; set; }

        public string APELLIDO { get; set; }

        public string TELEFONO { get; set; }

        public string CEDULA { get; set; }

        public string CARGO { get; set; }

        public string CORREO { get; set; }

        public bool? ESTADO { get; set; }


    }
}
