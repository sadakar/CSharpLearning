namespace ConstKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = 20 / 100D;

            int balance = 1000;
            Console.WriteLine(balance * (20 / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";
            Console.WriteLine(version);
            Console.WriteLine(20);
            Console.ReadLine();

        }
    }
}
