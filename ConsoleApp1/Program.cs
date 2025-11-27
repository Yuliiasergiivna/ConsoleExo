// See https://aka.ms/new-console-template for more information
Console.WriteLine("Donnez un nombre: ");

//string input = Console.ReadLine()!;
//int nombre = int.Parse(input);

int nombre = int.Parse(Console.ReadLine()!); //creer une variable par une seule ligne

//int division = nombre / 2;
//if (division + division == nombre)

if ((nombre /2) + (nombre/2) == nombre)
    {
        Console.WriteLine("Le nombre est pair.");
    }
    else
    {
        Console.WriteLine("Le nombre est impair.");
    }


//bool isConverted = int.TryParse(input, out nombre);
//if (isConverted)
//{
//    int division = nombre / 2;
//    if (division + division == nombre)
//    {
//        Console.WriteLine("Le nombre est pair.");
//    }
//    else
//    {
//        Console.WriteLine("Le nombre est impair.");
//    }
//}else
//{
//    Console.WriteLine(§"La valeur \"{input}\" n'est pas un nombre);
