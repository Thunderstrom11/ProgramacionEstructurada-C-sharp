//Crea un programa que use un bucle for para imprimir los números del 1 al 10 en consola.

namespace Ejercicio__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            for (n = 1; n <= 10; n++) // n es la variable de control y n++ significa que se incrementa en 1 cada vez que se ejecuta el bucle
            {
                Console.WriteLine(n);
            }
        }
    }
}
