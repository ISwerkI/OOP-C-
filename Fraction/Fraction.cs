using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        int denominator;
        public int Denominator
        {
            get => denominator;
            set => denominator = value == 0 ? 1 : value;
        }
        //                  Constructors
        public Fraction()
        {
            this.Integer = 0;
            this.Numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"DefaultConstructor:{this.GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t{GetHashCode()}");
        }
        public Fraction(int integer)
        {
            this.Integer = integer;
            this.Numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"Single-ArgumentConstructor:{this.GetHashCode()}");
        }
        public Fraction(int numerator, int denominator)
        {
            this.Integer = 0;
            this.Numerator = numerator;
            this.denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }
        public Fraction(int integer, int numerator, int denominator)
        {
            this.Integer = integer;
            this.Numerator = numerator;
            this.Denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }
        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
        }
        //                  Operators:
        public static Fraction operator *(Fraction l, Fraction r)
        {
            Fraction left = new Fraction(l);
            Fraction right = new Fraction(r);
            left.ToImproper();
            right.ToImproper();
            return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToImproper();
        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
            return left * right.Inverted();
        }
        //                  Methods
        Fraction Inverted()
        {
            Fraction inverted = new Fraction(this);
            inverted.ToImproper();
            int buffer = inverted.Numerator;
            inverted.Numerator = inverted.Denominator;
            inverted.Denominator = buffer;
            return inverted;
        }
        Fraction Reduce()
        {
            int more = Numerator, less = Denominator;
            int rest;
            do
            {
                rest = more % less;
                more = less;
                less = rest;
            } while (rest != 0);
            int GCD = more;
            Numerator /= GCD;
            Denominator /= GCD;
            return this;
        }


        Fraction ToProper()
        {
            this.Integer += Numerator % Denominator;
            Numerator %= Denominator;
            return this;
        }

        Fraction ToImproper()
        {
            Numerator += Integer * Denominator;
            Integer = 0;
            return this;
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
    }
}
