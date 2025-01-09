
namespace StringManipulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manipulator = new StringManipulator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välj en av följande funktioner:");
                Console.WriteLine("1. Vänd en sträng (ReverseString)");
                Console.WriteLine("2, Ta bort mellanslag (RemoveWhitespace)");
                Console.WriteLine("3, Slå ihop 2 strängar (ConcatenateStrings)");
                Console.WriteLine("4, Avsluta");
                Console.Write("Ange ditt val (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Ange en sträng att vända: ");
                        string inputToReverse = Console.ReadLine();
                        string reversed = manipulator.ReverseString(inputToReverse);
                        Console.WriteLine($"Resultat: {reversed}");
                        Pause();
                        break;

                    case "2":
                        Console.Write("Ange en sträng där mellanslag ska tas bort: ");
                        string inputToRemoveSpace = Console.ReadLine();
                        string noSpace = manipulator.RemoveWhitespace(inputToRemoveSpace);
                        Console.WriteLine($"Resultat: {noSpace}");
                        Pause();
                        break;

                    case "3":
                        Console.Write("Ange den första strängen: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Ange den andra stängen: ");
                        string str2 = Console.ReadLine();
                        string concatenated = manipulator.ConcatenateStrings(str1, str2);
                        Console.WriteLine($"Resultat: {concatenated}");
                        Pause();
                        break;

                    case "4":
                        Console.WriteLine("Avslutar programmet. Hej då!");
                        return;

                    default:
                        Console.WriteLine("Felaktigt val. Försök igen.");
                        Pause();
                        break;
                }
            }

        }

        private static void Pause()
        {
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}