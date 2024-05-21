namespace Car
{
    class Car
    {
        string color = "Red";
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Console.WriteLine(car.color);
            Console.WriteLine(car2.color);
            Console.ReadLine();
        }
    }
}
