using System;
using System.Text.RegularExpressions;

namespace Solution
{
    class Program
    {
        public enum CardType
        {
            Clubs, Diamonds, Spades, Hearts
        }
        public class Card
        {
            public CardType CardType { get; set; }
            public Card(CardType cardType)
            {
                CardType = cardType;
            }
        }
        public static void m(int val)
        {
            Console.WriteLine("m()");
        }

        public static void m(params int[] val)
        {
            Console.WriteLine("m(params)");
        }

        static void Main(string[] args)
        {
            m(10);
            m(10, 5, 20);
            m(new int[] { 10, 42, 421 });
            Card card = new Card(CardType.Clubs);
            string s = "12";
            string pattern = @"^-?(\d+)*(?:\.\d+)$";
            if (Regex.IsMatch(s, pattern))
            {
                Console.WriteLine("MATCH");
            }
            MatchCollection matches = Regex.Matches(s, pattern);
            if (matches.Count > 0)
            {
                Match match = matches[0];
                Console.WriteLine(value: match.Groups[0]);
                Console.WriteLine(match.Groups[1]);
                Console.WriteLine(match.Groups[2]);
                Console.WriteLine(match.Groups[3]);
                Console.WriteLine(match.Groups[4]);
                Console.WriteLine(match.Groups[5]);
            }
            Console.ReadKey();
        }
    }

}
