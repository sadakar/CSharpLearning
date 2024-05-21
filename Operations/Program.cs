namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            // + - * /

            // + and ++
            age += 10;
            Console.WriteLine(age);
        
            age = age + 10;
            Console.WriteLine(age);

            age++;
            Console.WriteLine(age);

            Console.WriteLine(age++);
            Console.WriteLine(age);

            ++age;
            Console.WriteLine(age);

            Console.WriteLine(++age);
            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming!"; // Concatinating of strings
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            Console.ReadLine();
        }
    }
}
