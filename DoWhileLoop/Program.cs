using System.Threading.Channels;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i < 10);
            Console.ReadLine();
        }
    }
}
