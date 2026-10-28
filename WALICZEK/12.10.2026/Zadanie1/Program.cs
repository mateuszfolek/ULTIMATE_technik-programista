namespace Zadanie1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] tablica = new int[5];

            for (int i = 0; i < tablica.Length; i++)
            {
                int wylosowano = random.Next(1, 49 + 1);
                tablica[i] = wylosowano;
            }

            Console.WriteLine(string.Join(",",tablica));

            Console.WriteLine($"MAX = {maks(tablica)} ");
            Console.WriteLine($"MINIMUM = {mini(tablica)} ");
            Console.WriteLine($"SUMA = {suma(tablica)} ");
            Console.WriteLine($"SREDNIA = {avg(tablica)} ");



        }
        public static int maks(int[] t)
        {
            int mx = t[0];

            for (int i = 1; i < t.Length; i++)
            {
                if(t[i] > mx)
                {
                    mx = t[i];
                }
            }
            return mx;
        }

        public static int mini(int[] t)
        {
            int mini = t[0];

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < mini)
                {
                    mini = t[i];
                }
            }
            return mini;
        }

        public static int suma(int[] t)
        {
            int suma = 0;

            for (int i = 0; i < t.Length; i++)
            {
             suma += t[i];   
            }
            return suma;
        }

        public static double avg(int[] t)
        {
            double avg = 0;

            for (int i = 0; i < t.Length; i++)
            {
                avg += t[i];
            }
            avg = avg / t.Length;
            return avg;
        }

        public static int[] sortowanieTablicy(int[] t)

        {
            Array.Sort(t);
            return t;
        }
    }
}