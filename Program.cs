using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
             AgregarPrecio precio = new AgregarPrecio { precioBase = 1500 };
             Producto producto = new Producto { Id = 1, nombre = "", stock = 10 }; 
            
            Console.WriteLine($"Código Único: {producto.CodigoUnico}"); 
            Console.WriteLine($"Id: {producto.Id}"); 
            
            producto.AgregarStock(5);
            producto.Vender(10);
           
            Console.WriteLine($"Nombre: {producto.nombre}"); 
            Console.WriteLine($"Precio base: {precio.precioBase}"); 
            Console.WriteLine($"Stock: {producto.stock}");
            Console.WriteLine($"Estado del Stock: {producto.EstadoStock}");
            Console.WriteLine($"Precio con IVA: {precio.PrecioConIVA}"); 

            GuardarArchivo guardador = new GuardarArchivo();
            guardador.Guardar(producto, precio);
        }
        catch(ArgumentException e)
        {
            System.Console.WriteLine($"error:  {e.Message}");
        }
    }
}
