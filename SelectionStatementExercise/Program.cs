namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumber();
        }

        public static int GuessTheNumber()
        {
            Random r = new Random();
            int favNumber = r.Next(1, 21);
            
            Console.WriteLine("Guess my favorite number between 1 & 20:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber) 
            {
                Console.WriteLine("Too low");
            }
            
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            
            else
            {
                Console.Write("You guessed correctly!!!");
            }

            return userInput;
        }
    }
}
