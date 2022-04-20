namespace Project5
{
    public delegate int Operation(int a, int b);
    class Program
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static void PerformOperation(Operation o, int a, int b)
        {
            Console.WriteLine(o(a, b));
        }
        static void Main(string[] args)
        {
            PerformOperation(Addition, 10, 5);
            PerformOperation((int d, int e) =>
            {
                Console.WriteLine("First multiplication");
                return d * e;
            }, 10, 5);
            PerformOperation((d, e) =>
            {
                Console.WriteLine("Second multiplication");
                return d * e;
            }, 10, 5);
            int x = 6, y = 8;
            Console.WriteLine("x: " + x + " y: " + y + ", " + (x > y ? "x is bigger than y" : "x is smaller than y"));//ternary operator
            PerformOperation((d, e) => d * e, 10, 5);
            Console.ReadKey();
        }

    }
}