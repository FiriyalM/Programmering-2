using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Triangle(1, 1);
            Console.WriteLine("Skriv in höjden: ");
            int heightRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in bredden: ");
            int widthRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in figuren: ");
            string s = Console.ReadLine();

            if (s == "triangel")
            {
                shape = new Triangle(heightRectangle, widthRectangle);
            }

            else
            {
                shape = new Rectangle(heightRectangle, widthRectangle);

            }

            Console.WriteLine("Arean är: "+ shape.Area());

            Console.WriteLine("Omkretsen är: "+ shape.Circumference());
        }
    }
}

