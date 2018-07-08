using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
         static int getCont(ref int a)
        {
            
            Console.WriteLine("ВВедіть параметр а (а>0)");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a == 0) return -1;
            else return a;
        }

        static void getPoint (ref double x,ref double y)
        {
            Console.WriteLine("Введіть x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть y:");
            y = Convert.ToDouble(Console.ReadLine());
        }

        static void outCont( int a)
        {
            Console.WriteLine($"[{a}]");
        }
        
        static void outPoint(double x, double y)
        {
            Console.WriteLine($"({x};{y})");
        }

        static int  wherePoint (int a, double x, double y)
        {
            if (x < 0) x = -x;
            if (y < 0) y = -y;
            if ((-a * x - a * y + a * a) < 0 ) return -1;
            if ((-a * x - a * y + a * a == 0 && y <= a) || (x <= a && y == 0)) return 0;
            else return 1;
            
        }

        static void processPoint ( int a)
        {
            double x = 0, y = 0;
            getPoint(ref x,ref y);
            outCont(a);
            outPoint(x, y);



        }

        static void Main(string[] args)
        {
            int a=0, x, y;
            getCont(ref a);
            if (a<0 || a==0)
            {
                Console.WriteLine("<<<WRONG PARAMETR>>>");
                return;
            }
            processPoint(a);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
