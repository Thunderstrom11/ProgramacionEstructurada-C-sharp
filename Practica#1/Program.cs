//Determinar si un número ingresado es positivo, negativo o cero usando if. 
//(Práctica | Uso de if y switch en C# eje 1)

int num;

Console.WriteLine("Ingresa un numero");
num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Este numero es Cero");
}

else if (num < 0)
{
    Console.WriteLine("Este numero es Negativo");
}
else
{
    Console.WriteLine("Este numero es Positivo");
}