/*Menú de opciones (switch)
Crea un menú simple con opciones como:

Saludar

Mostrar la fecha actual

Salir
Usa switch para ejecutar la opción seleccionada por el usuario.*/


namespace Ejercicio__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n*Menú basico*");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar la fecha actual");
                Console.WriteLine("3. Salir");
                Console.ResetColor();

                Console.Write("Seleccione una opción (1-3):");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número entre 1 y 3.");
                    continue; // Vuelve al inicio del bucle
                }

                switch (opcion)
                    {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("¡Hola!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"La fecha actual es: {DateTime.Now}"); // Muestra la fecha y hora actual segun el sistema
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Cerrando programa");
                        return; // Sale del método Main y termina el programa
                    default:
                        Console.Clear();
                        Console.WriteLine("Error:Opción no válida. Por favor, seleccione una opción entre 1 y 3.");
                        break;
                }
            }
        }
    }
}
