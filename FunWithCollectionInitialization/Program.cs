using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace FunWithCollectionInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArrayOfInts = { 1, 2, 3, 4, 5, 6 };

            List<int> myGenericList = new List<int> {1, 3, 4 , 5 };

            ArrayList myList = new ArrayList { 23, 2, 4, 24, 24 };

            List<Point> myListPoint = new List<Point>
            { 
                new Point{X = 2, Y  =4 },
                new Point{X = 3, Y  =5 },
                new Point{X = 4, Y  =6 }
            };

            foreach (var pt in myListPoint)
            {
                Console.WriteLine($"Point: {pt}");
            }

            Console.WriteLine(Environment.NewLine);

            List<Rectangle> myListOfRects = new List<Rectangle>
            {
                new Rectangle
                {
                    Height = 90, Width = 90,
                    Location = new Point {X = 10, Y = 10}
                },
                new Rectangle
                {
                    Height = 50, Width = 50,
                    Location = new Point {X = 2, Y = 2}
                }
            };

            foreach (var r in myListOfRects)
            {
                Console.WriteLine($"Point rectangle: {r}");
            }
        }
    }
}
