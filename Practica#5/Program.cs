//Crear un programa que determine si un año es bisiesto usando if y operadores lógicos.
//(Práctica | Uso de if y switch en C# eje 5)

int año;

Console.WriteLine("Determinador de años bisiestos");
Console.Write("Ingrese el año deseado segun el calendario Gregoriano >");
año = int.Parse(Console.ReadLine());

if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
    Console.WriteLine($"{año} Es un año bisiesto");

else
    Console.WriteLine($"{año} No es un año bisiesto");
