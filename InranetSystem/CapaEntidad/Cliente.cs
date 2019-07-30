using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Cliente
    {
        public int idCliente { set; get; }
        public string nombres { set; get; }
        public string apePaterno { set; get; }
        public string apeMaterno { set; get; }
        public string telefono { set; get; }
        public int dni { set; get; }
        public Boolean activo { set; get; }
        public string nomCom { set; get; }
    }
}
