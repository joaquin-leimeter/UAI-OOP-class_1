using System;

namespace class_1
{
    class Program
    {
        class Knight
        {
            // private fields/attributes
            private bool captured;
            private int row;
            private int column;
            private string color;

            //constructor
            public Knight(int initialRow, int initialColumn, string initialColor)
            {
                row = initialRow;
                column = initialColumn;
                color = initialColor;
                captured = false;
            }

            //getter methods
            public int getRow()
            {
                return row;
            }
            public int getColumn()
            {
                return column;
            }
            public string getColor()
            {
                return color;
            }
            public bool getCaptured()
            {
                return captured;
            }
            //setter methods
            public void setPosition(int newRow, int newColumn)
            {
                //validations for row and column
                //...
                //...
                row = newRow;
                column = newColumn;
            }
            public void capture()
            {
                captured = true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Knight knight1 = new Knight(4, 0, "black");
            Console.WriteLine(knight1.getRow());
            Console.WriteLine("is it captured?" + knight1.getCaptured());
            Console.WriteLine("I'm capturing this knight...");
            knight1.capture();
            Console.WriteLine("is it captured?" + knight1.getCaptured());
        }
    }
}
