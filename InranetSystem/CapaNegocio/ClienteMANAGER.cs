using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class ClienteMANAGER
    {
        ClienteDATA data = new ClienteDATA();
        public IEnumerable<Cliente> listarCliente()
        {
            return data.listarCliente();
        }
        public Boolean RegistrarCliente(string nombre, string apepat, string apemat, string telef, string dni)
        {
            return data.RegistrarCliente(nombre,apepat,apemat,telef,dni);
        }
        public Cliente BuqquedaXDni(int dni)
        {
            return data.BuqquedaXDni(dni);
        }
    }
}
