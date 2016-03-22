using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        /// <summary>
        /// Calcula el area del cuadrado.
        /// </summary>
        /// <param name="lado">
        /// Lado del cuadrado.
        /// </param>
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        /// <summary>
        /// Calcula el area del triangulo.
        /// </summary>
        /// <param name="b">
        /// Base del triangulo.
        /// </param>
        /// Altura del triangulo.
        /// <param name="h"></param>
        public static double CalcularTriangulo(double b, double h)
        {
            return b * h / 2;
        }

        /// <summary>
        /// Calcula el area del circulo.
        /// </summary>
        /// <param name="radio">
        /// Radio del circulo.
        /// </param>
        public static double CalcularCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
