namespace KlasyfikacjaEgzaminu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //etap 1
            Console.WriteLine("Wynik 0-100: ");

            //etap 2
            if(!int.TryParse(Console.ReadLine(), out int score) || score < 0)
            {
                Console.WriteLine("Błędny wynik");
                return;
            }

            string wynik = score switch
            {
                < 50 => "niezdany",
                < 70 => "dostateczny",
                < 85 => "dobry",
                _ => "bardzo dobry"
            };

            Console.WriteLine($"Ocena wyniku: {wynik}");
        }
    }
}