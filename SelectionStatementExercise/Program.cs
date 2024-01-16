using System.Diagnostics.CodeAnalysis;

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


            Console.WriteLine("what is your favorite subject: ");

            string subject = Console.ReadLine();
           

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("great choice math is very importent");            
                    break;

                case "english":
                    Console.WriteLine("good choice very useful in many jobs");
                    break;
                case "science":
                    Console.WriteLine("very good choice");
                    break;
                case "hisstory":
                    Console.WriteLine("very interesting ");
                    break;
                case "art":
                    Console.WriteLine("good choice");
                    break;
                default:
                    Console.WriteLine("i dont know about that onn..");
                    break;             

            }


        }
    


    }
}
