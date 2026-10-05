using System;
using System.Reflection;
using System.Collections.Generic;
using static System.Console;
using ENTIDADES;
using ENTIDADES.Categoria;
using ENTIDADES.Estado;
using System.Collections;
using System.Security.Cryptography;
using System.Linq;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version;

            WriteLine("♠||••••••••••••••••••••••••••••••••••||♠");
            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "--help":
                        MostrarAyuda();
                        Environment.Exit(0);
                        break;
                    case "--version":
                        WriteLine($"Version: {version}");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Error desconocido Argumento: No reconocido");
                        Environment.Exit(0);
                        break;
                }
            }
                        var inventario = new List<Inventario>
            {
                new Inventario
                (
                    nombre:"Carro",
                    cantidad:100,
                    precio:10000000
                ),
                new Inventario
                (
                    nombre:"Moto",
                    cantidad:100,
                    precio:10000000
                )
            };

            int cantidadProductos = inventario.Count;
            decimal ValorTotalInventario = total() * cantidadProductos ;
            bool sistemaActivo = true;
            total();
            Environment.ExitCode = 0;
            string nombresistema = "Sistema de Gestion de Inventario";

            decimal total()
            {
                decimal tot=0;
                foreach(var i in inventario)
                {
                    WriteLine($"ID:{i.Id} Nombre: {i.nombre} Cantidad:{i.Cantidad} Precio: {i.Precio}");
                    tot+=i.Precio;
                }
                return tot;
            }
            WriteLine("♠||•••••••••••••••••••••••••••••••••||♠");
            WriteLine($"Bienvenido al {nombresistema}");
            WriteLine("Prodctos en inventario: " + cantidadProductos);
            WriteLine($"Productos en inventario : {cantidadProductos:n2}");
            WriteLine($"Sistema Activo: {(sistemaActivo ? "Si" : "No")}");
            WriteLine($"Valor total del inventario: {ValorTotalInventario:n2}");


            MostrarBannerVers();
            bool continuar=true;
            while (continuar)
            {
                MostrarMenu();
                string coMando = LeerEntrada("Inventario ");
                WriteLine($"Comando ingresado{coMando}");;
                continuar= false;
            }
               void MostrarMenu()
            {
                WriteLine($"Sistema de Inventario");
                WriteLine($"Selecciona un comando");
                WriteLine($"1. Agregar Productos");
                WriteLine($"2. Buscar Productos");
                WriteLine($"3. Listar Productos");
                WriteLine($"4. Salir o escribe salir");

            }


            //============Methods===========//

            bool ProcesarComando(string comando)
            {
                switch (comando)
                {
                    case "listar":
                        ListarProductos();
                        return true;
                    case "agregar":
                        AgregarProducto();
                        return true;
                    case "buscar":
                        BuscarProducto();
                        return true;
                    case "salir":
                        return false;
                    default:
                        WriteLine($"Comando '{comando}' no valido");
                        return true;


                }
            }

            void ListarProductos()
            {
                WriteLine($"Lista de Productos");
                foreach(var i in inventario)
                {
                    WriteLine($"ID: {i.Id} Nombre: {i.nombre} Cantidad: {i.Cantidad} Precio: {i.Precio}");
                    WriteLine($"Total de productos {cantidadProductos}");
                    WriteLine($"Total de precios {ValorTotalInventario}");
                
                
                }
            }

            void AgregarProducto()
            {
                WriteLine($"Agregar Producto");
                
            }


            void BuscarProducto()
            {
                WriteLine($"Buscar Modulo(4)");
            }
            WriteLine("♠||•••••••••••••••••••••••••••••••••||♠\nIngresa un comando o ingresa salir para terminar la app");
            string? comando = ReadLine();

            if (string.IsNullOrWhiteSpace(comando) || comando.ToLower() == "salir")
            {
                WriteLine("Saliendo de la aplicacion");
                Environment.Exit(0);
            }
         
                
            
            WriteLine("Comandos : Listar , Salir , Agregar , Buscar");


            while (sistemaActivo)
            {
                WriteLine("•◘ Inventario •◘");
                string ent = ReadLine();

                string limpio = ent?.Trim().ToLower() ?? "Salir";
                switch (limpio)
                {
                    case "salir":
                        sistemaActivo = false;
                        WriteLine("Hasta Luego");
                        break;

                    case "listar":
                        if (inventario.Count == 0)
                        {
                            WriteLine("La lista esta vacia");
                        }
                            foreach(var i in inventario)
                        {
                            ImprimirINV(inventario);
                        }
                        break;
                    case "buscar":
                        WriteLine($"Escribe 1 para buscar por nombre 2 por cantidades 3 por precio");
                        string os = ReadLine();
                        if (int.TryParse(os, out int oso))
                        {
                            if (oso == 1)
                            {
                                string na = ReadLine();
                                
                                var resultado = inventario.Where(p => p.nombre.Contains(na, StringComparison.OrdinalIgnoreCase)).ToList();
                                ImprimirINV(resultado);
                                
                            }
                            else if (oso == 2)
                            {
                                WriteLine("Digita una cantidad");
                                string p = ReadLine();
                                if (int.TryParse(p, out int pc))
                                {
                                    var resultado = inventario.Where(p => p.Cantidad == pc).ToList();
                                     ImprimirINV(resultado);
           
                                }
                            }
                            else if (oso == 3)
                            {
                                WriteLine($"Buscar por el Precio");
                                string? pr = ReadLine();
                                if (decimal.TryParse(pr, out decimal prr))
                                {
                                    var resultado = inventario.FindAll(p => p.Precio == prr).ToList();
                                     ImprimirINV(resultado);
                                
                            }
                            else
                            {
                                WriteLine("Numero invalido");
                                break;
                            }
                            WriteLine($"Opción no valida");

                        }
                        }
                        break;

                    case "agregar":
                        WriteLine($"Agregar un producto");
                        WriteLine("Ingresa un nombre");
                        var m = ReadLine();
                        WriteLine("Ingresa una cantidad");
                        int.TryParse(ReadLine(), out int cn);
                        WriteLine("Ingresa un precio");
                        decimal.TryParse(ReadLine(), out decimal dn);
                        
                        var item =  new Inventario( nombre: m, cantidad: cn, precio: dn );
                        inventario.Add(item);
                        break;


                        }



            }}

        private static string LeerEntrada(string prompt)
        {
                string salida = "el prompt ingresado es" + prompt;
                return salida;
        }

        private static void ImprimirINV(List<Inventario> resultado)
        {
            foreach(var i in resultado)
            {
                WriteLine($"ID :{i.Id} Nombre: {i.nombre} Cantidad: {i.Cantidad} Precio: {i.Precio}");
            }
        }


        private static void MostrarBannerVers()
{
    var assembly = Assembly.GetExecutingAssembly();
    var version = assembly.GetName().Version;
    WriteLine(" || Sistema de Gestion de Inveentario|| ");
    WriteLine("♣||♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠||♣");
    WriteLine("");
    WriteLine("☻ Version 1.0");
    WriteLine($"Version: {version}");
    WriteLine($"System Info: {Environment.OSVersion}");
    WriteLine($"System Name: {Environment.MachineName}");
    WriteLine($"User Name: {Environment.UserName}");
    WriteLine($".NET Version: {Environment.Version}");
    WriteLine("");
    WriteLine("Estado Proyecto Inicializado DEV.State");
}
private static void MostrarAyuda()
{
    WriteLine("Uso: AppTest [opciones]");
    WriteLine("Opciones:");
    WriteLine("  --help      Muestra esta ayuda");
    WriteLine("  --version   Muestra la versión del programa");
}
}
}