using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikke numbreid 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikke numbreid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Arva ära number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õnnitlused! See on õige number!");
                    break;
                }
                else
                {
                    Console.WriteLine("Arva uuesti!");
                }
            }
        }
    }
}
