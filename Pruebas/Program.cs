
string opcion;  //Es int = solo cuando se hacen operaciones con el caracter | string = cualquier caracter a usar

Console.WriteLine("Selector de Carreras:");
Console.WriteLine(" 1 = Medicina\n 2 = Ingenieria \n 3 = Dejar de Estudiar");

opcion = Console.ReadLine(); //Convert.ToInt32 = int.Parse de 32 bits o Int64

switch (opcion)
{
    case "1": //Añadir comillas al case al ser string
        Console.WriteLine("Usted ha seleccionado Medicina");
        break; 
    case "2":
        Console.WriteLine("Usted ha seleccionado Ingenieria");
        break;
    case "3":
        Console.WriteLine("Usted es un vago");
        break;
    default:
        Console.WriteLine("Opcion No Valida, Ingrese un valor en el rango 1-3");
        break;

}