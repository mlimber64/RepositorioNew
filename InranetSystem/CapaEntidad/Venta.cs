﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idVenta { set; get; }
        public int idCliente { set; get; }
        public string total { set; get; }
        public Boolean activo { set; get; }
    }
}
