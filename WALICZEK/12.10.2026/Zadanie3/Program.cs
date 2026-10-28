using System;

namespace Zadanie3
{
    public class Program
    {
        public static string letters = "qwertyuiopasdfghjklzxcvbnm";
        public static string lettersBIG = "QWERTYUIOPASDFGHJKLZXCVBNM";
        public static string numers = "1234567890";

        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość hasła");

            if (!int.TryParse(Console.ReadLine(), out int dlugosc)
                || dlugosc < 4)
            {
                Console.WriteLine("Błąd cyfry lub zakresu");
                return;
            }

            string pass = Generate(dlugosc);

            Console.WriteLine(pass);
            File.WriteAllText("haslo.txt", pass);
        }

        public static string Generate(int dlugosc)
        {
            string pass = "";
            Random random = new Random();

            for (int i = 0; i < dlugosc; i++)
            {
                int op = random.Next(1, 4);

                if (op == 1)
                {
                    pass += letters[random.Next(0, letters.Length)];
                }
                else if (op == 2)
                {
                    pass += lettersBIG[random.Next(0, lettersBIG.Length)];
                }
                else if (op == 3)
                {
                    pass += numers[random.Next(0, numers.Length)];
                }
            }

            return pass;
        }
    }
}