//Repetir el ejercicio anterior usando switch con rangos aproximados.
//(Práctica | Uso de if y switch en C# eje 4)

int calificacion;

Console.WriteLine("Evaluador de Calificaciónes");
Console.WriteLine("Ingresa tu Calificación:");

calificacion = int.Parse(Console.ReadLine());

switch (calificacion)
{
    case >= 70 and <= 100:
        Console.WriteLine($"Usted a aprobado con {calificacion}pts");
        break;
    case >= 50 and <= 69:
        Console.WriteLine($"Usted a entrado a recuperación con {calificacion}pts");
        break;
    case < 50 and >= 0:
        Console.WriteLine($"Usted a reprobado con {calificacion}pts");
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}