namespace WalidowanieKalkulator
{
    public class Program
    {
        public static double ReadNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out var value  ))
                    return value;
                Console.WriteLine("Błędna liczba, Spróbój ponownie");

            }
        }

        public static void Main()
        {
            //etap 1
            double a = ReadNumber("Podaj a:");
            double b = ReadNumber("Podaj b:");
            //etap2 - operacje
            Console.WriteLine("Operator ( +, -, *, / )");
            string op = Console.ReadLine() ?? "";

            double? wynik = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" when b != 0 => a / b,
                _ => null
            };

            //etap 3
            Console.WriteLine(wynik is null ? "Niepoprawna opercja" : $"wynik: {wynik}" );
        }
    }
}