using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWinIndus.Modelo.DTOs
{
   public class EmpresasDTO
    {
        public int ID_EMPRESA { get; set; }

        public string CEDULA_RUC { get; set; }

        public string NOMBRE { get; set; }

        public string DIRECCION { get; set; }

        public string PAGINA_WEB { get; set; }

        public bool? ESTADO { get; set; }
    }
}
