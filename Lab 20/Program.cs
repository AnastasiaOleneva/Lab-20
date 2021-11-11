using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(СircumferenceLength);
            myDelegate?.Invoke(4.5);

            MyDelegate myDelegate1 = AreaCircle;
            if (myDelegate1 != null)
            {
                myDelegate1(6.2);
            }

            MyDelegate myDelegate2 = new MyDelegate(VolBall);
            myDelegate2?.Invoke(23.5);
            Console.ReadKey();
        }

        static double СircumferenceLength(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine("Длина окружности радиусом {0} равна {1}", R, D);
            return D;

        }

        static double AreaCircle(double R)
        {

            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь круга радиусом {0} равна {1}", R, S);
            return S;
        }
        static double VolBall(double R)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine("Объем шара радиусом {0} равна {1}", R, V);
            return V;


        }
    }



}
