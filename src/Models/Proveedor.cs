using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioAPP.src.Models
{
    public record Proveedor
    (
            int Id,
            string Nombre,
            string Email,
            string Telefono
    );
}