using MerlinDuarte17032023.Models;

using AlmacenContext db = new AlmacenContext();

Producto prod = new Producto();

Console.WriteLine("Ingrese el nombre del producto: ");
prod.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese la descripción del producto: ");
prod.Descripción= Console.ReadLine();   

Console.WriteLine("Ingrese el precio del producto: $"); 
prod.Precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de productos existente: ");
prod.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(prod);
db.SaveChanges();

var ListProductos = db.Productos.ToList();

foreach (var i in ListProductos)
{
    Console.WriteLine($"\nNombre: {i.Nombre}");
    Console.WriteLine($"Descripción: {i.Descripción}");
    Console.WriteLine($"Precio: ${i.Precio}");
    Console.WriteLine($"Stock: {i.Stock}");
}






