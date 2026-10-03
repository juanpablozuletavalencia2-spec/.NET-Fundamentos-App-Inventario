using System;
using ENTIDADES;
using static System.Console;
namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("♠||••••••••••••••••••••••••••••••••••||♠");
            WriteLine(" || Sistema de Gestion de Inveentario|| ");
            WriteLine("♣||♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠||♣");
            WriteLine("");
            WriteLine("☻ Version 1.0");
            WriteLine($"System Info: {Environment.OSVersion}");
            WriteLine($"System Name: {Environment.MachineName}");
            WriteLine($"User Name: {Environment.UserName}");
            WriteLine($".NET Version: {Environment.Version}");
            WriteLine("");
            WriteLine("Estado Proyecto Inicializado DEV.State");


            var inventario = new List<Inventario>()
            {
                new Inventario("Producto A", 10, 15.99m),
            };
            WriteLine("Para agregar un nuevo producto al inventario, Ingrese 1 , para mostrar el inventario Ingrese 2");
            if (int.TryParse(ReadLine(), out int opcion))
            {
                if (opcion == 1)
                {
                    WriteLine("Agregando un nuevo producto al inventario...");
                    WriteLine("Ingrese los detalles del producto:");

                    WriteLine("Ingrese el nombre del producto: ");
                    var nombre = ReadLine();
                    WriteLine($"Nombre del producto: {nombre}");

                    WriteLine("Ingrese la cantidad del producto: ");
                    int.TryParse(ReadLine(), out int cantidad);
                    WriteLine($"Cantidad del producto: {cantidad}");
                    WriteLine("Ingrese el precio del producto: ");
                    decimal.TryParse(ReadLine(), out decimal precio);
                    var AdInv = new Inventario(nombre, cantidad, precio);
                    imprimirInv(inventario);
                }
                else if (opcion == 2)
                {
                    WriteLine("Mostrando el inventario...");
                    imprimirInv(inventario);
                }
                else
                {
                    WriteLine("Opción inválida. Saliendo del programa.");
                }

                WriteLine("Presione cualquier tecla para salir...");
                ReadKey();
            }


        }

        private static void imprimirInv(List<Inventario> inventario)
        {
            foreach (var item in inventario)
            {
                WriteLine(item.ToString());
            }
        }
    }
}
