//Cuantos dias tiene cada mes, Condicional 3 (Switch)

int dia;
string conf, res = "";

Console.WriteLine("Calculo de cantidad de días por mes ");
Console.WriteLine("Este año es bisiesto  (y/n)");
conf = Console.ReadLine();

if (conf == "y" || conf == "Y")
{
    Console.WriteLine("Introduce el número del mes (1-12):");
    dia = int.Parse(Console.ReadLine());

    switch (dia)
    {
        case 1:
            res = "Enero tiene 31 días "; //Enero
            break;
        case 2:
            res = "Febrero tiene 28 días"; //Febrero (bisiesto)
            break;
        case 3:
            res = "Marzo tiene 31 días"; //Marzo
            break;
        case 4:
            res = "Abril tiene 30 días"; //Abril
            break;
        case 5:
            res = "Mayo tiene 31 días"; //Mayo
            break;
        case 6:
            res = "Junio tiene 30 días"; //Junio
            break;
        case 7:
            res = "Julio tiene 31 días"; //Julio
            break;
        case 8:
            res = "Agosto tiene 31 días"; //Agosto
            break;
        case 9:
            res = "Septiembre tiene 30 días"; //Septiembre
            break;
        case 10:
            res = "Octubre tiene 31 días"; //Octubre
            break;
        case 11:
            res = "Noviembre tiene 30 días"; //Noviembre
            break;
        case 12:
            res = "Diciembre tiene 31 días"; //Diciembre
            break;
        default:
            res = "Mes invalido";
            break;
    }
    Console.WriteLine(res);
}
else if (conf == "n" || conf == "N")
{
    Console.WriteLine("Introduce el número del mes (1-12):");
    dia = int.Parse(Console.ReadLine());

    switch (dia)
    {
        case 1:
            res = "Enero tiene 31 días "; //Enero
            break;
        case 2:
            res = "Febrero tiene 28 días"; //Febrero (no bisiesto)
            break;
        case 3:
            res = "Marzo tiene 31 días"; //Marzo
            break;
        case 4:
            res = "Abril tiene 30 días"; //Abril
            break;
        case 5:
            res = "Mayo tiene 31 días"; //Mayo
            break;
        case 6:
            res = "Junio tiene 30 días"; //Junio
            break;
        case 7:
            res = "Julio tiene 31 días"; //Julio
            break;
        case 8:
            res = "Agosto tiene 31 días"; //Agosto
            break;
        case 9:
            res = "Septiembre tiene 30 días"; //Septiembre
            break;
        case 10:
            res = "Octubre tiene 31 días"; //Octubre
            break;
        case 11:
            res = "Noviembre tiene 30 días"; //Noviembre
            break;
        case 12:
            res = "Diciembre tiene 31 días"; //Diciembre
            break;
        default:
            res = "Mes invalido";
            break;
    }
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Respuesta no válida. Debe ser 'y' o 'n'.");
}