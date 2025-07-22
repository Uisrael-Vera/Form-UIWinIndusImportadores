using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
    public class UsuariosDTO
    {
        public int ID_USUARIO { get; set; }

        public string NOMBRE { get; set; }

        public string CORREO { get; set; }

        public string PASSWORD { get; set; }

        public bool? ESTADO { get; set; }
    }
}
