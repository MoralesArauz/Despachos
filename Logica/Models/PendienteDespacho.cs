﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class PendienteDespacho : ICrudBase
    {

        // Atributos de la clase
        public int IDProducto { get; set; }
        public float Cantidad { get; set; }
        public int IDSucursal { get; set; }
        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Consultar()
        {
            bool R = false;

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarPorSucursal(int sucursal)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
