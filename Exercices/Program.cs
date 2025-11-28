namespace Exercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Donnez une nombre: ");
            //int nombre1 = int.Parse(Console.ReadLine()!);
            //Console.Write("Donnez une autre nombre: ");
            //int nombre2 = int.Parse(Console.ReadLine()!);
            //int div= nombre1 / nombre2;
            //int mod = nombre1 % nombre2;
            //double division = (double)nombre1 / nombre2;
            //Console.WriteLine($"Division entière:  {div }, " +
            //    $"Modulo:  {mod}, " +
            //    $"Division: {division}");


            //Console.Write("Donnez un numéro de compte bancaire (12 chiffres): ");
            //string compte = Console.ReadLine()!;

            //string compte = "732038207644";
            //if (compte.Length != 12 || !long.TryParse(compte, out _))
            //{
            //    Console.WriteLine("Le numéro de compte doit contenir 12 chiffres.");
            //    return;
            //}
            //else { 
            //        string nombreCompte = compte.Substring(0, 10);
            //        string prefixCompte = compte.Substring(10, 2);
            //        long nCompte = long.Parse(nombreCompte);
            //        short nPrefix = short.Parse(prefixCompte);
            //    short modulo = (short)(nCompte % 97);

            //    if ((modulo==0 && nPrefix== 97) || (modulo == nPrefix)
            //    {
            //        Console.WriteLine($"OK ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"KO ");
            //    }

            //}


            //Console.Write("Donnez un numéro de compte bancaire (12 chiffres): ");
            //string nombre = Console.ReadLine()!;
            string nombre = "732038207644";
            if (nombre.Length != 12 || !long.TryParse(nombre, out _))
            {
                Console.WriteLine("Le numéro de compte doit contenir 12 chiffres.");
                return;
            }
            else
            {
                string deuxDerniers = nombre.Substring(10, 2);
                string code = "111400";
                string concat = (deuxDerniers + deuxDerniers + code);
                Console.WriteLine(concat);
                long valeur = 98 - ((long.Parse(concat)) % 97);
                Console.WriteLine(valeur);
                string compte = "BE" + ((valeur <10)? "0" : "" )+ nombre;
                Console.WriteLine( "Votre IBAN est: "+compte);
            }
        }
    }
}
 
