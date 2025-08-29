//Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), recuperación (50–69) o reprobó (<50) con if.
//(Práctica | Uso de if y switch en C# eje 3)

int calificacion;

Console.WriteLine("Evaluador de Calificaciónes");
Console.WriteLine("Ingresa tu Calificación:");

calificacion = int.Parse(Console.ReadLine());

if (calificacion >= 70 && calificacion <= 100)
{
    Console.WriteLine($"Usted a aprobado con {calificacion}pts");
}
else if (calificacion >= 50 && calificacion <= 69)
{
    Console.WriteLine($"Usted a entrado a recuperación con {calificacion}pts");
}
else if (calificacion < 50 && calificacion >= 0)
{
    Console.WriteLine($"Usted a reprobado con {calificacion}pts");
}
else
{
    Console.WriteLine("Valor inválido");
 }