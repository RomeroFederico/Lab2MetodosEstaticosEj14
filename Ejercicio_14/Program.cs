using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    /*
    14.  Realizar una clase llamada 'CalculoDeArea' que posea 3 métodos de 
    clase (estáticos), double CalcularCuadrado(double), double 
    CalcularTriangulo(double, double) y double 
    CalcularCirculo(double), que realicen el cálculo del área que 
    corresponda.  
    El ingreso de los datos como la visualización se deberán realizar 
    desde el método Main().
    */

    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 14";

            Console.WriteLine("El area de un cuadrado de lado 4 es de {0}.", CalculoDeArea.CalcularCuadrado(4));
            Console.WriteLine("El area de un triangulo de base 5 y altura 5.8 es de {0,0:#,###.00}.", CalculoDeArea.CalcularTriangulo(5, 5.8));
            Console.WriteLine("El area de un circulo de radio 2 es de {0,0:#,###.00}.", CalculoDeArea.CalcularCirculo(2));

            Console.ReadKey();
        }
    }
}
