// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Pantalones se pede convertir en una prenda, ya que hereda de esta clase
//Prendas prenda = new Pantalones();
var prenda = new Prendas(); 
prenda.Id = 1;
prenda.Nombre = "Carmen";
prenda.tipo = new Tipos() { Id = 1, Nombre = "Jean" };
prenda.Valor = 120000.0m;
prenda.FechaCompra = DateTime.Now;
prenda.Existe = true;
prenda.Tallas = new List<Tallas>();
prenda.Tallas.Add(new Tallas() { Id = 1, Talla = 14 });
prenda.Tallas.Add(new Tallas() { Id = 2, Talla = 16});

Console.WriteLine(prenda.Nombre);
Console.WriteLine(prenda.tipo.Nombre);

foreach (var elemento in prenda.Tallas)
{
    Console.WriteLine(elemento.Talla); 
}

public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";
}

public class Tallas
{
    public int Id = 0;
    public int Talla;
}

public class Prendas
{
    public int Id = 0;
    public String? Nombre = "";
    public decimal Valor = 0.0m;
    public DateTime FechaCompra = DateTime.Now;
    public bool Existe = true;
    public Tipos tipo = new Tipos(); //singular un solo dato
    public List<Tallas> Tallas = new List<Tallas>(); //plural lista de arreglos
}

public class Pantalones : Prendas
{
    //public int Id = 0;
    public bool Destroyer = false;
}