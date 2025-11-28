namespace Demoboucle07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbre;
            string input;
            //Version do while
            do { 
                Console.WriteLine("Donnez un nombre(entre 1 et 100): ");
                input = Console.ReadLine()!;


            } while (!int.TryParse(input, out numbre )|| numbre < 1 || numbre > 100);
            //Console.WriteLine(numbre);

            bool isPerfectSquare = false;

            //Version while
            int i = 1;
            while (i <= 10 && !isPerfectSquare)
            {
                if (i * i == numbre)
                {
                    isPerfectSquare = true;
                }
                i++;
            }

            //Version for
            //for (i=1; i <= 10 && !isPerfectSquare; i++)
            //{
            //    if (i * i == numbre)
            //    {
            //        isPerfectSquare = true;
            //    }
            //}
            if (isPerfectSquare)
            {
                Console.WriteLine($"Le nombre {numbre} est un carré parfait.");
            }
            else
            {
                Console.WriteLine($"Le nombre {numbre} n'est pas un carré parfait.");
            }
        }

    }
}
