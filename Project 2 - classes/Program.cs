using System;
namespace Project2
{
    public class Employee
    {
        private string name;
        private double hourlyRate;
        public int HoursPerMonth { get; set; }
        /*
         * This is auto property with getter and setter.
         * Property allows to declare accessors (getter and setter) and use them indirectly.
         * It creates a private anonymous field that can only be accessed by get and set accessors.
         */
        public double HourlyRate
        {
            get
            {
                Console.WriteLine("Calling getter");
                return hourlyRate;
            }
            set
            {
                Console.WriteLine("Calling setter");
                hourlyRate = value;
                //value in setter is a value of expression on RHS
            }
        }
        public Employee(string name, double hourlyRate, int hoursPerMonth)
        {
            this.name = name;
            HourlyRate = hourlyRate;
            HoursPerMonth = hoursPerMonth;
        }//constructor

        public Employee() : this("John Smith", 10, 10)
        {

        }//indicates to call constructor in the current class

        public void IntroduceYourself()
        {
            Console.WriteLine("Hi, {0}", name);
        }
    }//Employee

    public class Product
    {
        public double PriceWithoutTax { get; set; }
        public const double TAX = 0.105;//Static constant. all constant, that are field, are also automatically static.
        public double PriceWithTax //Custom attribute. Its value is based on a value from another attribute
        {
            get { return PriceWithoutTax * (1 + TAX); }
            set { PriceWithoutTax = value / (1 + TAX); }
        }
        public override string ToString()
        {
            return "Price with tax: " + PriceWithTax + ", price without tax: " + PriceWithoutTax;
        }
    }//Product

    public class A
    {
        public A() { }
    }//A

    public class B : A //class inheritance
    {
        public B(/*List of args*/) : base(/*List of args*/) { } // base calls a constructor in the base function, since both functions needs the same constructor
    }//B

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double PricePerDay { get; set; }
        public Car(string make, string model, double pricePerDay)
        {
            Make = make;
            Model = model;
            PricePerDay = pricePerDay;
        }
    }//Car

    public class Rental
    {
        public Car RentedCar { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public double RentCost => (EndingDate - StartingDate).Days * RentedCar.PricePerDay;
        public override string ToString()
        {
            return String.Format("Cost of renting {0} {1} is {2} dollars", RentedCar.Make, RentedCar.Model, RentCost);
        }
    }//Rental

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("roman", 100, 160);
            e.HourlyRate = 10;
            Console.WriteLine(e.HourlyRate);
            e.IntroduceYourself();

            Product product = new Product { PriceWithoutTax = 5 };
            Console.WriteLine(product);
            product.PriceWithTax = 10;
            Console.WriteLine(product);
            Car c = new Car("Audi", "A8", 250);
            Rental rental = new Rental { RentedCar = c, StartingDate = new DateTime(2017, 04, 02), EndingDate = new DateTime(2017, 04, 10) };
            Console.WriteLine(rental.RentCost);
            Console.WriteLine(c.Model);
            Console.WriteLine(rental);
            Console.ReadKey();
        }
    }
}
