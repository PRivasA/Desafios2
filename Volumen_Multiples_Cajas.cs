// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Caja[] cajas = new Caja[10];
        double totalVolumen = 0;
        double volumenPromedio = 0;

        for (int i = 0; i < cajas.Length; i++)
        {
            cajas[i] = new Caja();
            cajas[i].Alto = 3.0;
            cajas[i].Ancho = 5.0;
            cajas[i].Largo = 2.0;
            totalVolumen += cajas[i].Volumen();
        }

        volumenPromedio = totalVolumen / cajas.Length;
        Console.WriteLine("Volumen total: " + totalVolumen);
        Console.WriteLine("Volumen promedio: " + volumenPromedio);
    }
}

//1. En primer lugar, se crea una clase Caja que contiene los atributos Alto, Ancho y Largo. Esta clase también contiene un metdo llamado Volumen que devuelve el volumen de la caja.
//2.Se declara una matriz de Cajas de 10 elementos.
//3. Se usa un bucle for para recorrer la matriz y asignar los valores Alto, Ancho y Largo a cada caja.
//4. Se usa otro bucle for para calcular el volumen total de las cajas y el volumen promedio.
//5. Finalmente, se imprime el volumen total y el volumen promedio en la consola.