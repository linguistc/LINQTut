namespace LUNQTut05.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango",
                "apple", "grape", "strawberry" };

            IEnumerable<string> orderedFruits = fruits.OrderBy(f => f);

            var orderedFruitsQ = from f in fruits
                                 orderby f ascending
                                 select f;

            var orderedFruitsDesc = fruits.OrderByDescending(f => f);

            var orderedFruitsDescQ = from f in fruits
                                     orderby f descending
                                     select f;

            var orderedFruitsAscLength = fruits.OrderBy(f => f.Length);

            var orderedFruitsDescLengthQ = from f in fruits
                                          orderby f.Length descending
                                          select f;



            Console.ReadKey();
        }
    }
}
