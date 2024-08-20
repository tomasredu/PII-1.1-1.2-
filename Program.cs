// See https://aka.ms/new-console-template for more information
using Ejs1_2;
Console.WriteLine("Hello, World!");

//Lista de colecciones (para probar el polimorfismo mas adelante)
List<IColeccion> colecciones = new List<IColeccion>();

// Instanciamos colecciones
var p1 = new Pila();
var c1 = new Cola();


// LLenamos las colecciones

foreach (var c in colecciones)
{
	for (int i = 1; i < 13; i++)
	{
		c.agregar(i);
	}
}
/*
p1.agregar(1);
p1.agregar(2);
p1.agregar(3);
p1.agregar(4);
p1.agregar(5);
p1.agregar(6);
p1.agregar(7);
p1.agregar(8);
p1.agregar(9);
p1.agregar(10);
p1.agregar(11);
p1.agregar(12);

c1.agregar(1);
c1.agregar(2);
c1.agregar(3);
c1.agregar(4);
c1.agregar(5);
c1.agregar(6);
c1.agregar(7);
c1.agregar(8);
c1.agregar(9);
c1.agregar(10);
c1.agregar(11);
c1.agregar(12);
*/

// Chequear contenidos de colecciones
foreach (IColeccion c in colecciones)
{
    Console.WriteLine(c.TypeOf() +": "+ c.ToString());
}

// Extraemos unos elementos

foreach (IColeccion c in colecciones)
{
	for (int i = 0; i < 4; i++)
	{
		Console.WriteLine(c.TypeOf() + ": " + c.extraer());
	}
}

// Chequear contenidos de colecciones despues de eliminar elementos
foreach (IColeccion c in colecciones)
{
    Console.WriteLine(c.TypeOf() + ": " + c.ToString());
}



//
Console.ReadLine();
