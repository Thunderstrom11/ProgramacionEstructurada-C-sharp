// Suma de dos numeros


// cd  Nombre de la carpeta del programa  +TAB  =mueve la terminal al proyecto


// dotnet run  =Corre el programa

//dotnet new console -n  Nombre = crea un nuevo proyecto




//declaracion de variables


//primitiva : int = entero , float =flotante , double = doble precicion , string = cadena de caracteres , bolean = boleano
// Es necesario declarar siempre las variables, puede ser en una sola linea y tambien inicializarlas aplicandoles un valor.
int num1 = 0;
int num2 = 0;
int suma = 0;


//Console se usa siempre para determinar que se ejecute en la consola, .Write = solo lo escribe y .Writeline = lo escribe y salta de linea.


Console.Write("Dime el primer valor: ");
num1 = int.Parse(Console.ReadLine());  //Readline = guarda la line y int.Parse se encarga de castear lo que se guarde en es tipo de dato, en este caso int
Console.Write("Dime el segundo valor: ");
num2 = int.Parse(Console.ReadLine());
suma = num1 + num2;

Console.Write("La suma es " + suma);