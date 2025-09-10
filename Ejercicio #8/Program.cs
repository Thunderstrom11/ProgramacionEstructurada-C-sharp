//Validación de contraseña (do-while)
//Crea un programa que pida al usuario una contraseña y repita la solicitud hasta que ingrese la correcta. Usa un bucle do while

namespace Ejercicio__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena_correcta = "C#1201", contrasena_ingresada;

            Console.WriteLine("Validador de contraseña\n");

            do
            {
                Console.Write("Ingrese la contraseña :");
                contrasena_ingresada = Console.ReadLine();

                if (contrasena_ingresada != contrasena_correcta)
                {
                    Console.Clear();
                    Console.WriteLine("Contraseña incorrecta. Intente de nuevo.\n");
                }

            }
            while (contrasena_ingresada != contrasena_correcta);

            Console.WriteLine("Contraseña correcta. Acceso concedido.\n");
        }
    }
}
