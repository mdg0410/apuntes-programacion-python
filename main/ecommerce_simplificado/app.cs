using System;
using System.Collections.Generic;

class Producto
{
    public int IdProducto { get; }
    public string Nombre { get; }
    public decimal Precio { get; }
    public string Descripcion { get; }
    public string Categoria { get; }

    public Producto(int idProducto, string nombre, decimal precio, string descripcion, string categoria)
    {
        IdProducto = idProducto;
        Nombre = nombre;
        Precio = precio;
        Descripcion = descripcion;
        Categoria = categoria;
    }
}

class GestionProductos
{
    private Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

    public void AgregarProducto(Producto producto)
    {
        productos[producto.IdProducto] = producto;
    }

    public void VerDetallesProducto(int idProducto)
    {
        if (productos.TryGetValue(idProducto, out Producto producto))
        {
            Console.WriteLine($"ID: {producto.IdProducto}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Descripción: {producto.Descripcion}, Categoría: {producto.Categoria}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public void ListarProductosPorCategoria(string categoria)
    {
        foreach (var producto in productos.Values)
        {
            if (producto.Categoria == categoria)
            {
                Console.WriteLine($"ID: {producto.IdProducto}, Nombre: {producto.Nombre}, Precio: {producto.Precio}");
            }
        }
    }
}

class CarritoDeCompras
{
    private Dictionary<int, int> items = new Dictionary<int, int>();

    public void AgregarProducto(Producto producto, int cantidad)
    {
        if (items.ContainsKey(producto.IdProducto))
        {
            items[producto.IdProducto] += cantidad;
        }
        else
        {
            items[producto.IdProducto] = cantidad;
        }
    }

    public void EliminarProducto(Producto producto)
    {
        items.Remove(producto.IdProducto);
    }

    public void VerCarrito()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"Producto ID: {item.Key}, Cantidad: {item.Value}");
        }
    }

    public decimal CalcularTotal(Dictionary<int, Producto> productos)
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Value * productos[item.Key].Precio;
        }
        return total;
    }
}

class Orden
{
    public CarritoDeCompras Carrito { get; }
    public decimal Total { get; }

    public Orden(CarritoDeCompras carrito, Dictionary<int, Producto> productos)
    {
        Carrito = carrito;
        Total = carrito.CalcularTotal(productos);
    }

    public void GenerarConfirmacion()
    {
        Console.WriteLine("Orden confirmada. Detalles de la orden:");
        Carrito.VerCarrito();
        Console.WriteLine($"Total: {Total}");
    }
}

interface IEstrategiaPago
{
    void RealizarPago(decimal cantidad);
}

class PagoTarjetaCredito : IEstrategiaPago
{
    public void RealizarPago(decimal cantidad)
    {
        Console.WriteLine($"Pago de {cantidad} realizado con tarjeta de crédito.");
    }
}

class PagoPayPal : IEstrategiaPago
{
    public void RealizarPago(decimal cantidad)
    {
        Console.WriteLine($"Pago de {cantidad} realizado con PayPal.");
    }
}

class PagoTransferenciaBancaria : IEstrategiaPago
{
    public void RealizarPago(decimal cantidad)
    {
        Console.WriteLine($"Pago de {cantidad} realizado con transferencia bancaria.");
    }
}

class Program
{
    static void Main()
    {
        GestionProductos gestionProductos = new GestionProductos();

        // Crear algunos productos
        Producto producto1 = new Producto(1, "Laptop", 1500, "Laptop de alta gama", "Electrónica");
        Producto producto2 = new Producto(2, "Libro de Python", 40, "Libro para aprender Python", "Libros");
        Producto producto3 = new Producto(3, "Camiseta", 20, "Camiseta de algodón", "Ropa");

        // Agregar productos al sistema
        gestionProductos.AgregarProducto(producto1);
        gestionProductos.AgregarProducto(producto2);
        gestionProductos.AgregarProducto(producto3);

        // Ver detalles de un producto específico
        gestionProductos.VerDetallesProducto(1);

        // Listar productos por categoría
        Console.WriteLine("Productos en la categoría 'Libros':");
        gestionProductos.ListarProductosPorCategoria("Libros");
    }
}
