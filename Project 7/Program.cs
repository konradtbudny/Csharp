using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Solution;

namespace Project_7
{
    class Program
    {
        //method reading number from a file, that are divisible by 5
        static void divisibleByFive(string path)
        {
            IEnumerable<int> list = new List<string>(File.ReadAllLines(path)).Select(number => Convert.ToInt32(number)).Where(number => number % 5 == 0);
            Console.WriteLine(string.Join(", ", list));
        }

        //method writing all numbers from the file numbers1.txt without repetition and sorted
        static void noRepetitionWriting(string path)
        {
            IEnumerable<int> list = new List<string>(File.ReadAllLines(path)).Distinct().Select(number => Convert.ToInt32(number)).OrderBy(e => e);
        }
        // method writing length of digit included in a file
        static void numberLength(string path)
        {
            IEnumerable<int> list = new List<int>(File.ReadAllLines(path).Select(number => number.Length));
            Console.WriteLine(string.Join(" ", list));
        }
        //method writing numbers from file1 that also appears in file2
        static void sameNumbers(string path1, string path2)
        {
            IEnumerable<int> list1 = new List<int>(File.ReadAllLines(path1).Select(number => Convert.ToInt32(number)));
            IEnumerable<int> list2 = new List<int>(File.ReadAllLines(path2).Select(number => Convert.ToInt32(number)));
            IEnumerable<int> result = list1.Intersect(list2);
            Console.WriteLine(String.Join(" ", result));
        }
        //method writing numbers from file1 but does not appear in file2
        static void differentNumbers(string path1, string path2)
        {
            IEnumerable<int> list1 = new List<int>(File.ReadAllLines(path1).Select(number => Convert.ToInt32(number)));
            IEnumerable<int> list2 = new List<int>(File.ReadAllLines(path2).Select(number => Convert.ToInt32(number)));
            IEnumerable<int> result = list1.Except(list2);
            Console.WriteLine(String.Join(" ", result));
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            using (StreamWriter sw1 = new StreamWriter("numbers1.txt"), sw2 = new StreamWriter("numbers2.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw1.WriteLine(r.Next(1000));
                    sw2.WriteLine(r.Next(1000));
                }
            }
            divisibleByFive("numbers1.txt");
            noRepetitionWriting("numbers1.txt");
            numberLength("numbers1.txt");
            sameNumbers("numbers1.txt", "numbers2.txt");
            differentNumbers("numbers1.txt", "numbers2.txt");
            List<Person> listOfPeople = new List<Person>()
            {
                new Person("Andrzej", 43),
                new Person("Agnieszka",  26),
                new Person("Janusz",41),
                new Person("Izabela", 52),
                new Person("Izabela", 14),
                new Person("Izabela", 20)
            };
            Console.WriteLine(String.Join(", ",listOfPeople.Where(person=>person.Age<50)));
            Console.WriteLine(String.Join(", ", listOfPeople.Select(person => person.Name.Length)));
            Console.WriteLine(String.Join(", ", listOfPeople.OrderBy(person=>person.Name).ThenBy(person => person.Age)));
            Console.ReadKey();
        }
    }
}
