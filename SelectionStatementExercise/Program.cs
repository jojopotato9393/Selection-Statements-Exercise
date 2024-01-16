namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
                var r = new Random();
            var faveNumber = r.Next(1,10);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < faveNumber)
            {
                Console.WriteLine("to low");
            }
            else if (userInput > faveNumber)
            {
                Console.WriteLine("to high");

            }
            if (userInput == faveNumber)
            {
                Console.WriteLine("Good job, you got it");
            }

            
          
        }
    }
}
