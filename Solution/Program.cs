using System;

namespace Solution
{
    class Program
    {
        /*
        cw + 2xTab autofills Console.WriteLine();
        ctrl + l deletes a line of code
        ctrl + k, d autoformats a code
        ctrl + k, c comments a line of code
        ctrl + k, u uncomments a line of code
        f5 builds and starts a program
        */
        public static int max(int[] t)
        {
            //returns a max element in array
            int max = int.MinValue;
            foreach (int element in t)
            {
                if (max < element)
                {
                    max = element;
                }
            }
            return max;
        }//max

        public static int passByValue(int x)
        {
            /*
            The function changes a value of a parameter in the function,but not in place,
            where the function is called(in this case Main).
            */
            x++;
            return x;
        }//passByValue

        public static int passByInitializedReference(ref int x)
        {
            /*
             1) The parameter x must be initialized, when passed into a function
             2)The function changes a value of the parameter x in the function and in a place,
               where the function is called.
            */
            x++;
            return x;
        }//passByInitializedReference

        public static int passByUninitializedReference(out int x)
        {
            //the function works the same as passByInitializedReference function, however,
            //the parameter does not have to be initialized, when passed to the function.
            x = 0;
            x++;
            return x;
        }//passByUninitializedReference

        public static int passByReferenceUnmodified(in int x)
        {
            // the function works as pass by reference function, but ensures that
            // the argument is not modified
            int y = x + 1;
            return y;
        }//passByReferenceUnmodified

        static void Main(string[] args)
        {
            int[] t = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            string s1 = "This is a first string";
            string s2 =
                @"This is
a second string";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            int val1 = 10;
            int val2;
            Console.WriteLine("original value: {0}", val1);
            passByValue(val1);
            Console.WriteLine("val1 after passByValue function: {0}",val1);
            passByInitializedReference(ref val1);
            Console.WriteLine("val1 after passByInitilizedValue: {0}", val1);
            passByUninitializedReference(out val2);
            Console.WriteLine("val2 after passByUninitializedReference: {0}", val2);


        }
    }
}
