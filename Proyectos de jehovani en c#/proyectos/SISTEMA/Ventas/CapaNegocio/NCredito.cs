﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCredito
    {
        public static DataTable ListarVentaCredito()
        {
            DCredito c = new DCredito();

            return c.SP_ListarVentaCredito();
        }
    }
}
