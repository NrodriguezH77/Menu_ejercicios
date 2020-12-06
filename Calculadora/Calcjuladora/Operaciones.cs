using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcjuladora
{
    class Operaciones
    {
        public double suma(double num1, double num2)
        {
             double suma = (num1 + num2);
            return suma;

        }

        public double resta(double num1, double num2)
        {
            double resta = (num1 - num2);
            return resta;

        }

        public double multiplicacion(double num1, double num2)
        {
            double multiplicacion = (num1 * num2);
            return multiplicacion;

        }

        public double division(double num1, double num2)
        {
            double division = (num1 / num2);
            return division;

        }

        public double porcentaje(double num1, double num2)
        {
            double porcentaje = (num1 * (num2 / 100));
            return porcentaje;

        }

        public double factorial(double num1)
        {
            double factorial = 0;

            for (double i = num1-1; i >= 1; i--)
            {
                 num1 *= i;
                factorial = num1;

            }

            return factorial;
        }
    }
}
