// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Por favor ingrese un número entero positivo");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("El número ingresado no es un número primo");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("El número ingresado es un número primo");
        }
        else
        {
            Console.WriteLine("El número ingresado no es un número primo");
        }
    }
}