using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Properties
{
    internal class Point
    {
        /*
        double x;
        double y;
        public double X
        {
            get 
            { 
                return x; 
            }
            set
            {
                if(value > 100) value = 100;
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if(value > 100) value = 100;
                y = value;
            }
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        { 
            this.x = x; 
        }

        public void SetY(double y)
        {
            this.y = y;
        }*/
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x=0, double y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        //                      Arithmetic operators
        public static Point operator+(Point left, Point right)
        {
            Point result = new Point(left.X + right.X, left.Y + right.Y);
            return result;
        }
        public static Point operator -(Point left, Point right)
        {
            Point result = new Point(left.X - right.X, left.Y - right.Y);
            return result;
        }
        public static Point operator *(Point left, Point right)
        {
            Point result = new Point(left.X * right.X, left.Y * right.Y);
            return result;
        }
        public static Point operator /(Point left, Point right)
        {
            Point result = new Point(left.X / right.X, left.Y / right.Y);
            return result;
        }

        //                  Unary operators
        public static Point operator ++(Point point)
        {
            Point result = new Point(point.X++,point.Y++);
            return result;
        }
        public static Point operator --(Point point)
        {
            Point result = new Point(point.X--, point.Y--);
            return result;
        }

        //                  Comparison operators
        public static bool operator !=(Point left, Point right)
        {
            return left.X != right.X & left.Y != right.Y;
        }
        public static bool operator ==(Point left, Point right)
        {
            return left.X == right.X & left.Y == right.Y;
        } 
        public static bool operator <(Point left, Point right)
        {
            return left.X < right.X & left.Y < right.Y;
        }
        public static bool operator >(Point left, Point right)
        {
            return left.X > right.X & left.Y > right.Y;
        }
        public static bool operator <=(Point left, Point right)
        {
            return left.X <= right.X & left.Y <= right.Y;
        }
        public static bool operator >=(Point left, Point right)
        {
            return left.X >= right.X & left.Y >= right.Y;
        }

        //                  Methods
        public double Distance(Point point)
        {
            double result = Math.Sqrt(Math.Pow(point.X - this.X,2) + Math.Pow(point.Y - this.Y, 2));
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
