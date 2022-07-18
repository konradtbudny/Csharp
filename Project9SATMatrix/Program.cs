using System;

namespace Project9SATMatrix
{
    class Program
    {
        public static int[][] generateMatrix(int numberofRows, int numberOfColumns)
        {
            int[][] matrix = new int[numberOfColumns][];
            Random random = new Random();
            for (int i = 0; i < numberofRows; i++)
            {
                matrix[i] = new int[numberOfColumns];
                for (int j = 0; j < numberOfColumns; j++)
                {
                    matrix[i][j] = random.Next(0, 10);
                }
            }
            return matrix;
        }
        public static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("\t", matrix[i]));
            }
        }
        public static int[][] generateSAT(int[][] matrix)
        {
            int[][] sat = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                sat[i] = new int[matrix[i].Length];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sat[i][j] = matrix[i][j];
                    if (i > 0)
                    {
                        sat[i][j] += sat[i - 1][j];
                    }
                    if (j > 0)
                    {
                        sat[i][j] += sat[i][j - 1];
                    }
                    if (i > 0 && j > 0)
                    {
                        sat[i][j] += sat[i - 1][j - 1];
                    }
                }
            }

            return sat;
        }
        public static int calculateSum(int[][] sat, int row1, int column1, int row2, int column2)
        {
            int sum = sat[row2][column2];
            if (row1 > 0)
            {
                sum += sat[row1 - 1][column2];
            }
            if (column1 > 0)
            {
                sum += sat[row2][column1 - 1];
            }
            if (column1 > 0 && row1 > 0)
            {
                sum -= sat[row1 - 1][column1 - 1];
            }
            return sum;
        }
        public static int calculateSumByIteration(int[][] matrix, int row1, int column1, int row2, int column2)
        {
            int sum = 0;
            for (int i = row1; i <= row2; i++)
            {
                for (int j = column1; j <= column2; j++)
                {
                    sum += matrix[i][j];
                }
            }
            return sum;
        }
        public static Tuple<Point, Point>[] generateCoordinates()
        {
            Random random = new Random();
            Tuple<Point, Point>[] coordinates = new Tuple<Point, Point>[100000];
            for (int i = 0; i < coordinates.Length; i++)
            {
                Point point1 = new Point(random.Next(0, 980), random.Next(0, 980));
                Point point2 = new Point(random.Next(point1.x + 20, 1000), random.Next(point1.y + 20, 1000));
                coordinates[i] = new Tuple<Point, Point>(point1, point2);
            }
            return coordinates;
        }
        public static string calculateSATTime(int[][] sat, Tuple<Point, Point>[] Coordinates)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var pair in Coordinates)
            {
                calculateSum(sat, pair.Item1.x, pair.Item1.y, pair.Item2.x, pair.Item2.y);
            }
            watch.Stop();
            return watch.Elapsed.ToString();
        }
        public static string calculateIterationTime(int[][] matrix, Tuple<Point, Point>[] Coordinates)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var pair in Coordinates)
            {
                calculateSumByIteration(matrix, pair.Item1.x, pair.Item1.y, pair.Item2.x, pair.Item2.y);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds.ToString();
        }
        static void Main(string[] args)
        {
            int[][] matrix = generateMatrix(1000, 1000);
            //printMatrix(matrix);
            int[][] sat = generateSAT(matrix);
            int sum = calculateSum(sat, 0, 0, 6, 8);
            Console.WriteLine("Sum of elements in submatrix (0,0,6,8) is: " + sum);
            //dividing 1000x1000 matrix into 100 matrixes of size at least 20x20, and, calculating and printing them afterwards.
            Tuple<Point, Point>[] coordinates = generateCoordinates();
            //calculating and timing SAT algorithm
            Console.WriteLine("Time to calculate matrixes using SAT is " + calculateSATTime(matrix, coordinates) + "ms");
            //Timing the stadard calculation
            Console.WriteLine("Time to calculate matrixes using iteration is " + calculateIterationTime(matrix, coordinates) + "ms");
            Console.ReadKey();
        }
    }
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
