namespace MinumumTablicy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Etap 1 to standardowe wejście do projektu
            int[] tablica = { 7, 3, 9, 2, 6 };
            int min = tablica[0];

            //Etap 2 to operacje
            for(int i = 1; i < tablica.Length; i++)
            {
                if(tablica[i] < min)
                {
                    min = tablica[i];
                }
                //krok1 - czy 3 jest mniejsza od 7? -- Tak
                //to min jest równe 3
                //krok2 - czy 9 jest mniejsza od 3? -- Nie
                //to min jest równe 3
                //krok3 - czy 2 jest mniejsza od 3? -- Tak
                //to min jest równe 2
                //krok4 - czy jest 6 mniejsza od 2? -- Nie
                //to min jest równe 2
                
            }

            //Etap 3 to standardowe wyjście - warswtwa prezentacji danch

            Console.WriteLine(min);
        }
    }
}

