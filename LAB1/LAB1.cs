using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Как Вас зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {Name}");


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Деление");
            Console.WriteLine("Введите 1 число");
            var FirstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            var SecondNum = double.Parse(Console.ReadLine());
            if (FirstNum == 0)
            {
                Console.WriteLine("\nОтвет:");
                Console.WriteLine($"{FirstNum } / {SecondNum } = " + (0));
                Console.WriteLine($"{SecondNum } / {FirstNum } =  Ошибка");

            }
            if (SecondNum == 0)
            {
                Console.WriteLine("\nОтвет:");
                Console.WriteLine($"{FirstNum } / {SecondNum } =  Ошибка");
                Console.WriteLine($"{SecondNum } / {FirstNum } = " + (0));

            }
            if (SecondNum != 0 && FirstNum != 0)
            {
                Console.WriteLine("\nОтвет:");
                Console.WriteLine($"{FirstNum } / {SecondNum } = " + (FirstNum / SecondNum));
                Console.WriteLine($"{SecondNum } / {FirstNum } = " + (SecondNum / FirstNum));
            }

            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Следующая буква");
            char letter = Console.ReadKey().KeyChar;
            char letter2 = char.ToLower(letter);
            char next;
            if (letter2 == 'z')
                next = 'a';
            else
                next = (char)(((int)letter2) + 1);
            Console.WriteLine();
            Console.WriteLine(next);















            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Решение кв. уравнения вида ax^2 + bx + c = 0");
            Console.WriteLine("Введите а");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            var c = double.Parse(Console.ReadLine());
            var dis = Math.Pow(b, 2) - (4 * a * c);
            double x1, x2;
            if (dis < 0)
            {

                Console.WriteLine("\nОтвет:");
                Console.WriteLine("Нет корней");

            }
            if (dis == 0)
            {

                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("\nОтвет:");
                Console.WriteLine($"x1 = { x1}; x2 = { x2}");
            }


            if (dis > 0)
            {

                x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("\nОтвет:");
                Console.WriteLine($"x1 = { x1}; x2 = { x2}");
            }




            Console.ReadKey();
        }
    }
}
