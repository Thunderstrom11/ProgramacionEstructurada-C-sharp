/* lectura de numero hasta que sea negativo , mostrar la suma de todos hasta que sea
negativo*/

int num,suma = 0;
string entrada;
Console.Write("Dime un #: ");
entrada = Console.ReadLine();
num = Convert.ToInt32(entrada);

while (num >= 0 && suma <= 100)
{
    suma += num;
    if (suma >= 100)
        break;
    Console.Write("Dime un #: ");
    entrada = Console.ReadLine();
    num = Convert.ToInt32(entrada);
}

Console.WriteLine($"La suma total es {suma}");
