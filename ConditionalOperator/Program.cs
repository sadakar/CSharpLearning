namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter your age:"+age);
            string result = (age > 0) ? "Valid" : "Invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
