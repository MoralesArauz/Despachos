using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    interface ICrudBase
    {

        // Tiene los mantenimientos básicos de la base de datos.
        bool Agregar();
        bool Editar();
        bool Eliminar();
        bool Consultar();
    }
}
