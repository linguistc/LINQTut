namespace CADelegate
{
    // delegate void MDelegate();


    internal class Program
    {
        static void Main(string[] args)
        {
            //Method2(Method1);

            Action action = Method1;

            Method2(action);

            Console.ReadKey();
        }


        static void Method1()
        {
            Console.WriteLine("Method1");
        }

        static void Method2(Action action)
        {
            action();

            Console.WriteLine("Method2");
        }
    }
}
