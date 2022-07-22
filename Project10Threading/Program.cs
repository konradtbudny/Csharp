using System;
using System.Collections.Concurrent;
using System.Threading;
using System.IO;

namespace Solution
{
    public class Program
    {
        private static BlockingCollection<int> intQueue = new BlockingCollection<int>();
        private static volatile bool work = true;
        private static volatile bool running = true;
        public static void ProcessOne()
        {
            while (work)
            {
                Console.WriteLine("ProcessOne");
                Thread.Sleep(2000);
            }
        }
        public static void ProcessTwo()
        {
            while (work)
            {
                Console.WriteLine("ProcessTwo");
                Thread.Sleep(3000);
            }
        }
        public static void Producer()
        {
            Random random = new Random();
            int integer = 0;
            while (running)
            {
                var timeMS = random.Next(1000, 3000);
                Thread.Sleep(timeMS);
                Console.WriteLine("Adding to a queue");
                intQueue.Add(integer);
                Console.WriteLine("After adding to collection");
                integer++;
            }
            intQueue.CompleteAdding();
        }
        public static void Consumer()
        {
            while (intQueue.Count > 0 || !intQueue.IsCompleted)
            {
                Console.WriteLine("Loading from the intQueue");
                File.AppendAllText("out.txt",intQueue.Take().ToString());
                Console.WriteLine("Loaded from the intQueue");
            }
        }
        public static void Main(string[] args)
        {
            BlockingCollection<string> stringQueue = new BlockingCollection<string>(1);
            Thread thread1 = new Thread(ProcessOne);
            Thread thread2 = new Thread(ProcessTwo);
            Thread thread3= new Thread(Producer);
            Thread thread4 = new Thread(Consumer);
            thread1.Start();
            thread2.Start();
            stringQueue.Add("text"); //Add function adds an element to a collection, when it is empty. Otherwise, it waits till the collection is emptied
            Console.WriteLine(stringQueue.Take());//Process and, then, delete an object from a collection, or it waits, if collections is empty and process an object added to the collection later on
            stringQueue.CompleteAdding();
            Console.WriteLine(stringQueue.IsCompleted && stringQueue.Count == 0);
            Console.ReadKey();
            work = false;
            thread3.Start();
            thread4.Start();
            Console.ReadKey();
            running = false;
        }
    }
}
