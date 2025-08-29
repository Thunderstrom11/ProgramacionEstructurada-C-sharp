//Pedir un número entre 1 y 7 y mostrar el día de la semana con switch.
//(Práctica | Uso de if y switch en C# eje 2) 

int num;
string resp;

Console.WriteLine("Ingrese un numero del 1 al 7 ");

num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        resp = "Lunes";
        break;
    case 2:
        resp = "Martes";
        break;
    case 3:
        resp = "Miércoles";
        break; 
    case 4:
        resp = "Jueves";
        break;
    case 5:
        resp = "Viernes";
        break;
    case 6:
        resp = "Sábado";
        break;
    case 7:
        resp = "Domingo";
        break;
    default:
        resp = "Día no válido";
        break;
}
Console.WriteLine($"Tu día seleccionado es {resp}");