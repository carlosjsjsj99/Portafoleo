using System;

public class AgregarPrecio
{
    private int PrecioBase;
    public int precioBase
    {
        get { return PrecioBase; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0");
            }
            else
            {
                PrecioBase = value;
            }
        }
    }

    public decimal PrecioConIVA
    {
        get
        {
            return PrecioBase * 1.13m;
        }
    }

}