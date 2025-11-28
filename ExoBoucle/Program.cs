using System.Formats.Asn1;

namespace ExoBoucle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Les premiers nombres
            Console.WriteLine("Combien des premier nombre calculer? :");
            string texte = Console.ReadLine()!;
            int length = int.Parse(texte);
            int count = 0;
            while (count < length)
            {   
                count++;
                for (int i = 1; i <= length; i++)
                {
                    Console.WriteLine("Le premier nombre est :" + i);
                }
                Console.WriteLine("Le premier nombre est :" + (length));
                length++;
            }

            //for (int i = 2; i * i < length; i++)
            //{
            //    Console.WriteLine("Le premier nombre est :" + i);
            //}



            // Nombres à virgule flottante
            //for (double i = 0.0; i < 20.0; i+=0.1)
            //{
            //    Console.WriteLine(i);
            //} ne marche pas exactement à cause des imprécisions des nombres à virgule flottante
            //for (decimal j = 0.0m; j < 20.0m; j += 0.1m)
            //{
            //    Console.WriteLine(j);
            //}



            // Factorielle
            //Console.WriteLine("Donnez une chiffre: ");
            //uint number;
            //bool isConverted;
            //string message = "Veuillez entrer un nombre entier positif supérieur à zéro: ";

            //do
            //{
            //    Console.WriteLine(message);
            //    message = "Entrée invalide. " + message;
            //    isConverted = uint.TryParse(Console.ReadLine()!, out number);
            //}
            //while (!isConverted || number <= 0);

            //ulong fact = 1;

            //for (uint i = 1; i <= number; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine($"La factorielle de {number} est {fact}");




            // Suite de Fibonacci
            //int fib = 25;
            //uint a = 0;
            //uint b = 1;

            //Console.WriteLine("Suite de Fibonacci jusqu'à " + fib + ":");
            //for (int i = 0; i <= fib; i++)
            //{
            //    Console.Write(a + " ");
            //    uint next = a + b;
            //    a = b;
            //    b = next;
            //}



            //table de multiplication
            //Console.WriteLine("Table de multiplication:");

            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {

            //        string mult = $"{i}*{j}={(i * j),4} ";

            //        Console.Write($"{mult}\t ");
            //    }
            //    Console.WriteLine();
            //}



            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write($"{i * j,4}");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
    }
