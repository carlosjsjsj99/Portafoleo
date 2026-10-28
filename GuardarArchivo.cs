using System.IO;

public class GuardarArchivo
{
    public void Guardar(Producto producto, AgregarPrecio precio)
    {
        string datos = $"Código: {producto.CodigoUnico}\n" +
                       $"Id: {producto.Id}\n" +
                       $"Nombre: {producto.nombre}\n" +
                       $"Precio: {precio.precioBase}\n" +
                       $"Stock: {producto.stock}";

        File.WriteAllText("producto.txt", datos);
    }
}
