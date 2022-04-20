namespace Project4
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            result = prime * result + Age;
            result = prime * result + ((Name == null) ? 0 : Name.GetHashCode());
            return result;
        }
        public override bool Equals(Object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Person other = (Person)obj;
            if (Age != other.Age)
                return false;
            if (Name == null)
            {
                if (other.Name != null)
                    return false;
            }
            else if (!Name.Equals(other.Name))
                return false;
            return true;
        }
        public override string ToString()
        {
            return String.Format("The name is {0} and the age is {1}", Name, Age);
        }
        public int CompareTo(Person other)
        {
            /*
             * Returns value
             * positive, when this>other
             * negative, when this<other
             * 0, when they are the same
             */
            return Age - other.Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                IList<int> list = new List<int>() { 10, 5, 4, 2, 3, 5, 19, 6, 1, 2 };
                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }
            }
            {
                List<Person> listOfPeople = new List<Person>()
            {
                new Person("Tom",43),
                new Person("Agnes",26),
                new Person("John",64),
                new Person("Isabelle",12)
            };
                Console.WriteLine(String.Join(Environment.NewLine, listOfPeople));
                Console.WriteLine("Contains Tom,43?" + listOfPeople.Contains(new Person("Tom", 43)));
                Console.WriteLine("----------------------------------------");
                listOfPeople.Sort();//uses compareTo() to sort elements
                Console.WriteLine("Sorted list of people:");
                Console.WriteLine(String.Join(Environment.NewLine, listOfPeople));
                Console.WriteLine("-------------------------------------------");
                listOfPeople.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));//lambda expression, similar to anonymous function (difference in a number of expressions)
                Console.WriteLine(String.Join(Environment.NewLine, listOfPeople));
                Operation o = Math.Max;
                Console.WriteLine(o(10, 5));
            }
            Console.ReadKey();
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
    }
    delegate int Operation(int a, int b);//Delegate, works like pointers(refers functions as well), but it is more accurate/specific
}