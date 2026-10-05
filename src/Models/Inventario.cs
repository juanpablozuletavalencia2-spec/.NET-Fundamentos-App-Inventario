using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Inventario
    {
        public int Id {get; private set;}

        public string nombre {get;  set;}
        public int Cantidad {get;  set;}
        public decimal Precio {get; set;}

     
        
                    
            // Genera un ID aleatorio entre 1 y 1000
        
        
        public Inventario( string nombre, int cantidad, decimal precio)
        {
            Id = Guid.NewGuid().GetHashCode() % 1000; // Genera un ID aleatorio entre 1 y 1000
            this.nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Inventario: {nombre}, Cantidad: {Cantidad}, Precio: {Precio}";
        }
    }
}