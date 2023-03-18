// See https://aka.ms/new-console-template for more information
using System;

namespace PromedioPuntaje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            int Puntaje = 0;
            int sumaPuntaje = 0;
            int contadorPuntaje = 0;
            double promedio = 0.0;
            string entrada = "";

            //Instrucciones
            Console.WriteLine("Escribe el puntaje del estudiante (del 1 a 10) y escribe 'fin' para calcular el promedio:");

            //Ciclo para obtener el puntaje
            do
            {
                //Pedir al usuario que ingrese la puntaje
                entrada = Console.ReadLine();

                //Si el usuario escribe un número, entonces guardarlo en la variable calificación
                if (int.TryParse(entrada, out Puntaje))
                {
                    //Verificar que la calificación esté entre 1 y 10
                    if (Puntaje >= 1 && Puntaje <= 10)
                    {
                        //Agregar la calificación a la suma
                        sumaPuntaje += Puntaje;

                        //Aumentar el contador
                        contadorPuntaje++;
                    }
                    else
                    {
                        Console.WriteLine("El puntaje debe estar entre 1 y 10, por favor inténtalo de nuevo.");
                    }
                }
            } while (entrada != "fin");

            //Verificar que se hayan ingresado calificaciones
            if (contadorPuntaje > 0)
            {
                //Calcular el promedio
                promedio = (double)sumaPuntaje / contadorPuntaje;

                //Mostrar el promedio
                Console.WriteLine("El Puntaje promedio es: {0}", promedio);

                //Esperar que el usuario presione una tecla para cerrar
                Console.ReadKey();
            }
        }
    }
}