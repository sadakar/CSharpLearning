namespace ExcerciseStroingUserData
{
    internal class Program
    {
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line-by-line to the screen
         * Extra: define variables using the var keyword
         */
        static void Main(string[] args)
        {
            /* string name = "Aba";
             string number = "0123456789";
             int age = 23;*/

            var name = "Aba";
            var number = "0123456789";
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
