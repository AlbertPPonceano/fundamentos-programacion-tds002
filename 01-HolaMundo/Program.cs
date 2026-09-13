/* 
 * Nombre: Albert Adrian Peña Ponceano
 * Fecha: 13/09/2026
 * Descripción: Tarjeta de presentación impresa en la consola con marco decorativo. A
 */

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos de la tarjeta de presentación
            string nombre = "Albert Peña Ponceano";
            string matricula = "2026-0769";
            string carrera = "Ciberseguridad";
            string frase = " Perfectoo.";

            // Marco superior
            Console.WriteLine("**************************************************");
            Console.WriteLine("==================================================");

            // Contenido enmarcado
            Console.WriteLine("| Nombre:    " + nombre);
            Console.WriteLine("| Matrícula: " + matricula);
            Console.WriteLine("| Carrera:   " + carrera);
            Console.WriteLine("| Frase:     " + frase);

            // Marco inferior
            Console.WriteLine("==================================================");
            Console.WriteLine("**************************************************");
        }
    }
}
