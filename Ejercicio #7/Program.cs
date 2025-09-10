//Calcular el promedio de N calificaciones
//Solicita al usuario cuántas calificaciones desea ingresar. Luego usa un bucle while para capturarlas y calcula el promedio final.

namespace Ejercicio__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_calificaciones, contador = 0;
            double calificacion, suma_total = 0;

            Console.WriteLine("Calculadora de promedio de calificaciones\n");

            Console.Write("¿Cuántas calificaciones desea ingresar?: ");

            try
            {
                n_calificaciones = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número entero.");
                return;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error:{ex.Message}");
                return;
            }
            if (n_calificaciones <= 0)
            {

                Console.Clear();
                Console.WriteLine("Error:El número de calificaciones debe ser mayor que cero.");
                return;
            }

            Console.Clear();

            while (contador < n_calificaciones)
            {
                Console.Write($"Ingrese el puntaje de la {contador} calificación: ");

                try
                {
                    calificacion = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error:Entrada no válida. Por favor, ingrese un número válido.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Error:{ex.Message}");
                    continue;
                }
                if (calificacion > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Error:El puntaje no puede ser superior a 100.");
                    continue;
                }

                suma_total += calificacion;
                contador++;
                Console.Clear();
            }

            Console.WriteLine($"El promedio de las {n_calificaciones} calificaciones es de : {Math.Round(suma_total / n_calificaciones, 2)} pts");

        }
    }
}
