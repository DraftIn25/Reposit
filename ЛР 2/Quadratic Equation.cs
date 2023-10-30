using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2
{
    internal class Quadratic_Equation
    {
        double a, b, c;
        public Quadratic_Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Show()
        {
            string text = "";
            if (a != 0)
                text = $"{a}x^2";
            if (b > 0)
                text = text + $"+{b}x";
            else if (b == 0)
                text = text + "";
            else
                text = text + $"{b}x";
            if (c > 0)
                text = text + $"+{c}x";
            else if (c == 0)
                text = text + "";
            else
                text = text + $"{c}x";
            if (a == 0)
                throw new aException($"Получили линейное уравнение {text}=0.Введите параметр 'a'>0");
            else
            Console.WriteLine($"Квадратное уравнение:{text}=0");
        }
        public void Solution()
        {
            double d = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант = "+d);
            if (d < 0)
                throw new NegativeDiscriminantException("Дисрриминант < 0. Нет решений");
            double x1=(-b+Math.Sqrt(d))/(2*a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if(d==0)
                Console.WriteLine($"Уравнение имеет один корень:x1={x1}");
            else if(d>0)
            Console.WriteLine($"Уравнение имеет два корня x1={Math.Round(x1,3)} x2={Math.Round(x2,3)}");
        }
    }
}
