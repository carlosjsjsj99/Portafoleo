using System;

public class Producto
{
    public string CodigoUnico { get; } = "PROD-" + Guid.NewGuid().ToString().Substring(0, 6).ToUpper();

    public int Id { get; set; }

    public string? Nombre;
    public string? nombre
    {
        get { return Nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Nombre = "Producto sin nombre";
            }
            else
            {
                Nombre = value;
            }
        }
    }
    
    
    private int Stock;
    public int stock
    {
        get { return Stock; }
        set 
        {
            if(value < 0)
            {
                 throw new ArgumentException("El stock no puede ser negativo");
            }
            else
            {
                 Stock = value;
            }
        }
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser positiva");
        }

        Stock += cantidad;
    }

    public void Vender(int cantidad)
    {
        if (cantidad > stock)
        {
            throw new ArgumentException("No hay stock suficiente");
        }

        Stock -= cantidad;
    }

    public string EstadoStock
    {
        get
        {
            if (Stock == 0)
            return "Agotado";

            if (Stock < 5)
            return "Critico";
            
            return "Disponible";
        }
    }

}

