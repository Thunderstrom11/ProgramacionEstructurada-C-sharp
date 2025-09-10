//Desarrolle un programa que calcule la cantidad total de baldes de leche producida en un día en una lechería de Estelí,
//utilizando como entradas el volumen promedio por vaca en litros y el número total de vacas ordeñadas,
//ambos proporcionados por el usuario (1 balde = 20 litros).

namespace Programa_basico__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volumen_promedio_por_vaca, total_baldes ;
            int numero_total_de_vacas;

            Console.WriteLine("Programa de calculo de cantidad total de baldes de leche producida en un día en una lechería de Estelí\n");

            Console.Write("Ingrese el volumen promedio por vaca en litros:");
            volumen_promedio_por_vaca = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Ingrese el número total de vacas ordeñadas:");
            numero_total_de_vacas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            total_baldes = (volumen_promedio_por_vaca * numero_total_de_vacas) / 20; // 1 balde = 20 litros

            Console.WriteLine($"La cantidad total de baldes de leche producida en un día en la lechería con un volumen promedio por vaca de {volumen_promedio_por_vaca} litros y un número total de {numero_total_de_vacas} vacas ordeñadas es de {Math.Round(total_baldes, 2)} baldes.");
        }
    }
}
