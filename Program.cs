using System;
using System.Reflection;
using System.Collections.Generic;
using static System.Console;
using ENTIDADES;
namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly=Assembly.GetExecutingAssembly();
            var version=assembly.GetName().Version;
            WriteLine("♠||••••••••••••••••••••••••••••••••••||♠");
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
}
}
