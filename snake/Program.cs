using System;
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
            Point p1 = new Point(1, 4, '*');
            p1.Draw();

            Point p2 = new Point(4, 6, '@');
            p2.Draw();

            //создаю еще две точки
            Point p3 = new Point(6, 8, '&');
            p3.Draw();

            Point p4 = new Point(8, 10, '$');
            p4.Draw();

            List<int> numList = new List<int>();//создали класс "список" с целочисленными переменными
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);//положили в список несколько переменных

            //чтобы получить доступ к переменным, нужно сослаться на их порядковый номер
            int x = numList[1];
            int y = numList[2];
            int z = numList[3]; //присвоили локальным переменным значения переменных из списка

            /*foreach(int i in numList) //при каждой итерации переменной i поочередно присваивается очередное значение переменной из списка
            {
                Console.WriteLine(i);
            }*/

            numList.RemoveAt(0);//удалить элемент из списка

            List<Point> pList = new List<Point>();//создали список, содержащий точки
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4); 


            Console.ReadKey();
        }
    }
}
