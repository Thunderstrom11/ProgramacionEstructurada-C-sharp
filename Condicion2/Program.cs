//Numero mayor o inferior a 10, Condicional 2 (if-else, else-if)
int numero;

Console.WriteLine("Ingrese un numero cuyo valor superior o inferior a 10");
numero = int.Parse(Console.ReadLine());

if (numero == 10)
{
    Console.WriteLine("Este numero no es valido");
}
else if (numero < 10)
{
    Console.WriteLine("Este valor es Inferior a 10");
}
else
{
    Console.WriteLine("Este valor es Superior a 10");
}
