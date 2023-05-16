using Solucion_Objetos.Clases;
using System;

namespace Solucion_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Persona persona = new();

            persona.Nombre = "Maria";
            persona.Apellido = "Sosa";
            persona.Edad = 25;
            persona.Salario = 12313.313;

            persona.ImprimirDatos();

            Console.WriteLine("__________________________");

            Persona persona2 = new Persona();

            persona2.Nombre = "Alberto";
            persona2.Apellido = "Castrejon";
            persona2.Edad = 99;
            persona2.Salario = 69;

            persona2.ImprimirDatos();
        }
    }
}
