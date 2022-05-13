using System;

namespace ConsoleSnake
{
    class Program
    {

        static void Main(string[] args)
        {
            Point x1 = new Point();
            x1.x = 1;
            x1.y = 3;
            x1.sym = '*';

            x1.Draw();

            Console.ReadLine();
        }
    }
}
