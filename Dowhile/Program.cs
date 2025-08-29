// Muestra un menu que diga 1. Bienvenido, 2. Saludo 3. Salir

string opcion;

do
{
    Console.WriteLine("1. Bienvenido.");
    Console.WriteLine("2. Saluda.");
    Console.WriteLine("3. Salir.");
    Console.WriteLine("Digite su opcion: ");
    opcion = Console.ReadLine();
    
} while (opcion != "3");