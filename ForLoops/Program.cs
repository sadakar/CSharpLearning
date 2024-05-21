namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.Write("What do you want to repeat?: ");
           string message =Console.ReadLine();

           Console.Write("And how many times do you want to repeat it ?: ");
           int loopCounter = Convert.ToInt32(Console.ReadLine());

           if(loopCounter <= 0) {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                    Console.WriteLine(message);
            }
         
           Console.ReadLine();
        }
    }
}
