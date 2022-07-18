using System;

namespace Solution
{
    public class A
    {
        public static A INSTANCE { get; private set; } = new A();
        private A() { }
    }

    //laziness vs thread save
    public class Pricelist1 //thread unsafe
    {
        private static Pricelist1 instance = null;
        private Pricelist1() { }

        public static Pricelist1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Pricelist1();
                return instance;
            }
        }
    }

    public sealed class Pricelist2
    {
        private static Pricelist2 instance = null;
        private static readonly object padlock = new object();

        Pricelist2()
        {
        }
        public static Pricelist2 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Pricelist2();
                    return instance;
                }
            }
        }
    }

    public sealed class Pricelist3 // fully lazy
    {
        private Pricelist3() { }
        public static Pricelist3 Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested() { }
            internal static readonly Pricelist3 instance = new Pricelist3();
        }
    }

    public sealed class PriceList4
    {
        private static readonly Lazy<PriceList4> lazy = new Lazy<PriceList4>(() => new PriceList4());
        public static PriceList4 Instance { get { return lazy.Value; } }
        private PriceList4() { }
    }

    class Program
    {
        public Program A()
        {
            return this;
        }

        public Program B()
        {
            return this;
        }

        public Program C()
        {
            return this;
        }

        static void Main(string[] args)
        {
            //CHAIN API
            new Program().A().B().C();
            Program p = new Program();
            p.A(); p.B(); p.C();
        }
    }
}
