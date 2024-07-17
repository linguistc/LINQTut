using LINQTut05.Shared;

namespace LINQTut05.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

            var reversedOrder = fruits.Reverse();

            reversedOrder.Print("Fruits in reversed order.");

            Console.ReadKey();
        }
    }
}
