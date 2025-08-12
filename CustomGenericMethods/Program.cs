namespace CustomGenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Custom Generic Methods*****\n");

            int a = 10, b = 90;

            Console.WriteLine($"Before swap: {a}, {b}");

            SwapFunctions.Swap<int>(ref a, ref b);

            Console.WriteLine($"After swap: {a}, {b}\n");

            string s1 = "Hello", s2 = "There";

            Console.WriteLine($"Before swap: {s1}, {s2}");

            SwapFunctions.Swap<string>(ref s1, ref s2);

            Console.WriteLine($"After swap: {s1}, {s2}\n");

            bool b1 = true, b2 = false;

            Console.WriteLine($"Before swap: {b1}, {b2}");

            SwapFunctions.Swap<bool>(ref b1, ref b2);

            Console.WriteLine($"After swap: {b1}, {b2}\n");

            DisplayBaseClass<int>();

            DisplayBaseClass<string>();
        }

        static void DisplayBaseClass<T>()
        {
            Console.WriteLine($"Base class of {typeof(T)} is: {typeof(T).BaseType}");
        }
    }
}
