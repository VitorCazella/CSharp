using System;

namespace AbstractDemo
{
    class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => side * side;//{ return side * side }

        static void Main()
        {
            Square sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }
}
