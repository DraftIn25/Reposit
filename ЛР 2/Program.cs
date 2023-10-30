using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ЛР_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=null;
            Console.WriteLine("Программа по решению квадратного уравнения.\nОбщий вид квадратного уравнения: ax^2+bx+c=0");
            try
            {
                StreamReader reader = new StreamReader("H:/Тестирование и отладка ПО/ЛР 2/ЛР 2/Parametres.txt");
                 text = reader.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Ошибка: "+ex.Message);
            }
            string [] data=text.Split(' ');
            try
            {
                for (int i = 0; i < data.Length; i++)
                    if (data[i].Length<1|| Regex.IsMatch(data[i], @"^[a-zA-Z]+$"))
                        throw new ParametresInFileException("Входные данные имеют неверный формат");
            }
            catch(ParametresInFileException ex)
            {
                Console.WriteLine("Ошибка: "+ex.Message);
            }
            finally 
            {
                Console.WriteLine("Данные успешно получены!");
            }
            double a = Convert.ToDouble(data[0]);
            double b = Convert.ToDouble(data[1]);
            double c = Convert.ToDouble(data[2]);
            Quadratic_Equation quadratic = new Quadratic_Equation(a, b, c);
            try
            {
                quadratic.Show();
            }
            catch (aException ex) 
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            try 
            {
                quadratic.Solution();
            }
            catch(NegativeDiscriminantException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
