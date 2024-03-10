using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public int X;
    public int Y;

    public static double operator +(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Abs(p1.X - p2.X)* Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) * Math.Abs(p1.Y - p2.Y));
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1.X == p2.X && p1.Y == p2.Y);
    }

    public override string ToString()
    {
        return $"(X={this.X} Y={this.Y})";
    }
}

namespace AlgLabs.Laba2
{
    public class Task3
    {
        /// <summary>
        /// Функция, определяющая с какой стороны находятся точки относительно друг друга
        /// </summary>
        public static double Rotate(Point a, Point b, Point c)
        {
            return (b.X - a.X) * (c.Y - b.Y) - (b.Y - a.Y) * (c.X - b.X);
        }
        public static List<Point> MinPerimeter(List<Point> points)
        {
            List<Point> list = new List<Point>();
            Point left = new Point()
            {
                X = int.MaxValue
            }; 
            foreach (var p in points)
                if (p.X < left.X) left = p;
            list.Add(left);
            while (true)
            {
                var right = new Point() { X = 0, Y = 0};

                for (int i = 0; i < points.Count; i++)
                {
                    if (right.X == 0 && right.Y == 0) right = points[i];
                    if (Rotate(list.Last(), right, points[i]) < 0)
                        right = points[i];
                }
                    
                if (right == left) break;
                else
                {
                    list.Add(right);
                    points.Remove(right);
                }
            }

            return list;
        }

        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for(var i = 0; i < n; i++)
            {
                string[] coordinates = (Console.ReadLine()).Split(' ');
                points.Add(new Point()
                {
                    X = int.Parse(coordinates[0]),
                    Y = int.Parse(coordinates[1])
                });
            }
            double result = 0;
            points = MinPerimeter(points);
            for(var i = 0; i < points.Count - 1; i++)
            {
                result += points[i] + points[i + 1];
            }
            result += points[0] + points.Last();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(Math.Round(result, 1));
        }
    }
}
