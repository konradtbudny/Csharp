//case where functions have the same name, but different parameters
namespace Project3
{
    class Program
    {
        public static void m(int val)
        {
            Console.WriteLine("m()");
        }

        public static void m(params int[] val)
        {
            Console.WriteLine("m(params)") ;
        }

        static void Main(string[] args)
        {
            m(10);
            m(10, 5, 20);
            m(new int[] { 10, 42, 421 });
            Console.ReadKey();
        }
    }
}