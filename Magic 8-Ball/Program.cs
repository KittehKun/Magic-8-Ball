using Magic_8_Ball;

internal class Program
{
    private static void Main(string[] args)
    {
        MagicBall magicBall = new();

        Console.WriteLine("Welcome to the Magic 8 Ball!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        while (true)
        {
            Console.WriteLine("Ask me a question and I will tell you the future!");
            Console.Write("Question: ");
            Console.ReadLine();

            Console.WriteLine(magicBall.GetRandomPhrase());

            Console.WriteLine("Do you have another question for the Magic 8 Ball? (y/n)");
            string answer = Console.ReadLine()!;

            while (true)
            {
                if (answer!.ToLower() == "y" || answer.ToLower() == "n") break;
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                answer = Console.ReadLine()!;
            }

            if (answer.ToLower() != "y") break;

            Console.Clear();
        }

        Console.Clear();

        Console.WriteLine("Thank you for playing with the magic 8-Ball!");
    }
}