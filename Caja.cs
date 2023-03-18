using System;

public class Caja
{
    public double Alto;
    public double Ancho;
    public double Largo;

    public double Volumen()
    {
        return Alto * Ancho * Largo;
    }
}
