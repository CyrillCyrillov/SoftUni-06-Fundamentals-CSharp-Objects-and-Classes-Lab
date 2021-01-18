using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace Task06_Store_Boxes_another_solution
{
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public Box(Point UpperLeft, Point UpperRight, Point BottomLeft, Point BottomRight)
        {
            this.UpperLeft = UpperLeft;
            this.UpperRight = UpperRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }

        public double Width
        {
            get
            {
                return Point.CalcDsitance(this.UpperLeft, this.UpperRight);
            }
        }

        public double Height
        {
            get
            {
                return Point.CalcDsitance(this.UpperLeft, this.BottomLeft);
            }
        }

        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * (width + height);
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double CalcDsitance(Point p1, Point p2)
        {
            double x = p2.X - p1.X;
            double y = p2.Y - p1.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
    }
    class Program
    {
        static void Main()
        {
            var boxes = new List<Box>();

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                    break;

                string[] inputArr = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                boxes.Add(ReadBox(inputArr));
            }

            foreach (Box box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)box.Width, (int)box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)box.Width, (int)box.Height)}");
            }


            Console.ReadLine();
        }

        public static Box ReadBox(string[] inputArr)
        {

            return new Box(ReadPoint(inputArr[0]), ReadPoint(inputArr[1]), ReadPoint(inputArr[2]), ReadPoint(inputArr[3]));
        }

        public static Point ReadPoint(string input)
        {
            string[] inputArr = input.Split(':');
            return new Point(int.Parse(inputArr[0]), int.Parse(inputArr[1]));
        }
    }

}