//Verificar si es mayor de edad

int edad;

Console.Write("Dime tu edad: ");
edad = int.Parse(Console.ReadLine());

if (edad >= 18) 
{
    Console.WriteLine("Eres mayor de edad.");
}
else
{
    Console.WriteLine("Usted es menor de edad.");
}