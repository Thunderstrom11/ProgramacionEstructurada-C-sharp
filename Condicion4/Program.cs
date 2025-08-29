//Verificar si es mayor de edad, Condicional 4 (Operador ternario (forma corta del if-else)

int edad;
string mensaje;

Console.Write("Dime tu edad: ");
edad = int.Parse(Console.ReadLine());

if (edad > 0)
{
    mensaje = edad >= 18 ? "mayor de edad" : "menor de edad";

    Console.WriteLine($"Usted es {mensaje}");
}
else
{
    Console.WriteLine("Edad no valida");
}