namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput =Console.ReadLine();
            int age =Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is "+ name+ " and your  age is "+age);

            Console.ReadLine();
        }
    }
}
