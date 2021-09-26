using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikke numbreid 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikke numbreid ühe korra.

            Random rnd = new Random();
            {
                int i = 0;
                while (i < 3)
                {
                    {
                        int cpuNumber = rnd.Next(1, 11);
                        Console.WriteLine("Arva ära number 1 kuni 10:");

                        int userNumber = Convert.ToInt32(Console.ReadLine());
                        if (userNumber == cpuNumber)
                        {
                            Console.WriteLine("Õnnitlused! See on õige number!");
                            break;
                        }
                        else
                        {
                            i++;
                            Console.WriteLine($"Vale number. Palun proovi uuesti. Alles on veel {3 - i} katset.");
                        }
                    }
                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
