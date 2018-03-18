﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 6;
            p2.sym = '#';
            Draw(p2.x, p2.y, p2.sym);

            //int x1 = 1;
            //int y1 = 4;
            //char sym1 = '*';
            //Draw (x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 6;
            //char sym2 = '#';
            //Draw (x2, y2, sym2);

            Console.ReadKey();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
