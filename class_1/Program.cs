using System;

namespace class_1
{
    class Program
    {
        class Knight
        {
            // public fields/attributes
            public int row;
            public int column;
            public string color;

            //constructor
            public Knight(int initialRow, int initialColumn, string initialColor)
            {
                row = initialRow;
                column = initialColumn;
                color = initialColor;
            }

            //methods
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Knight knight1 = new Knight(4, 0, "black");
            Console.WriteLine(knight1.row);
            Console.WriteLine(knight1.column);
            Console.WriteLine(knight1.color);
        }
    }
}
