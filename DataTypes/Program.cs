namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x=10, y=20,z=30;


            int age = -23; // Declaring and initializing
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


            Console.ReadLine();
        }
    }
}
