namespace Numbersgame2._0
{
    internal class Program
    {
        public static bool CheckGuess(int a, int b)
        {
            if (a == b)
            {
                return true;
            }

            else if (a > b)

            {
                Console.WriteLine("Du gissade för högt!");
                return false;
            }

            else
            {
                Console.WriteLine("Du gissade för lågt!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");
            int guess = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int random = rnd.Next(1, 21);
            bool victory = false;

            int counter;

            for (counter = 0; counter <= 4; counter++)
            {
                if (counter == 4)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                    break;
                }
                victory = CheckGuess(guess, random);

                if (victory)
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen:");
                    guess = int.Parse(Console.ReadLine());
                }

            }

            
        }
    }
}
