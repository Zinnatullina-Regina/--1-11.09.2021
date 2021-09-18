using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Округление числа до сотых\nВведите число");
            var number = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(Math.Round(number, 2));


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Выведение на экран числа e с точностью до десятых");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(Math.Round((Math.E), 1));


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Вывод на экран числа, вводимого с клавиатуры");
            Console.WriteLine("\nВведите число");
            var a = Console.ReadLine();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("Вы ввели число " + a);


            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Вывод на экран числа, вводимого с клавиатуры");
            Console.WriteLine("\nВведите число");
            var b = Console.ReadLine();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(b + " - вот какое число Вы ввели");


            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Вывод на одной строке чисел 1, 13 и 49 с одним пробелом между ними.");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("1 13 49");


            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Вывод на одной строке чисел 7, 15 и 100 с двумя пробелами между ними.");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("7  15  100");


            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("Вывод на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            Random n = new Random();
            var one = n.Next();
            var two = n.Next();
            var three = n.Next();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(one + "  " + two + "  " + three);

            Console.WriteLine("\nЗадание 8");
            Console.WriteLine("Вывод на экран в одну строку четырех любых чисел с одним пробелом между ними.");
            one = n.Next();
            two = n.Next();
            three = n.Next();
            var four = n.Next();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(one + " " + two + " " + three + " " + four);

            Console.WriteLine("\nЗадание 9");
            Console.WriteLine("Вывод на экран чисел 50 и 10 одно под другим.");
            var f = 50;
            var t = 10;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(f + "\n" + t);

            Console.WriteLine("\nЗадание 10");
            Console.WriteLine("Ввод на экран чисел 5, 10 и 21 одно под другим.");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("5\n10\n21");

            Console.WriteLine("\nЗадание 11");
            Console.WriteLine("Вывод на экран «столбиком» четырех любых чисел.");
            var q = n.Next();
            var w = n.Next();
            var e = n.Next();
            var r = n.Next();
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(q + "\n" + w + "\n" + e + "\n" + r);

            Console.WriteLine("\nЗадание 12");
            Console.WriteLine("Вывод вывода на экран следующей информации: 5 10 7 см");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("5 10\n7 см");

            Console.WriteLine("\nЗадание 13");
            Console.WriteLine("Вывод вывода на экран следующей информации: 2 кг 13 17");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("2 кг\n13 17");



            Console.WriteLine("\nЧасть 2\nЗадание 1\nЧасть а");
            Console.WriteLine("вычисления значения функции y=7x2+3x+6 при любом значении x");

            var x = double.Parse(Console.ReadLine());
            var y = 7 * x * x + 3 * x + 6;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(y);

            Console.WriteLine("\nЧасть б");
            Console.WriteLine("вычисления значения функции x=12a2+7a+12 при любом значении а.");

            x = double.Parse(Console.ReadLine());
            y = 12 * x * x + 7 * x + 12;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(y);


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Периметр квадрата");
            var side = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(side * 4 + "- решение");

            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Диаметр окружности");
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(rad * 2 + "- решение");

            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Расстояние до линии горизонта");
            var ba = double.Parse(Console.ReadLine());
            var bg2 = Math.Pow(6350 + ba, 2) - 40322500;
            var bg = Math.Sqrt(bg2);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(bg);

            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Объем и площадь боковой поверхности куба");
            side = double.Parse(Console.ReadLine());
            var volume = Math.Pow(side, 3);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(side * side * 4 + " - площадь боковой поверхности");
            Console.WriteLine(volume + " - обЪем");

            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Длина окружности и площадь круга");
            var R = double.Parse(Console.ReadLine());
            var sq = Math.PI * Math.Pow(R, 2);
            var lengh = 2 * Math.PI * R;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(sq + " - площадь боковой поверхности");
            Console.WriteLine(lengh + " - длина");


            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("среднее арифметическое и среднее геометрическое.");
            var O = double.Parse(Console.ReadLine());
            var T = double.Parse(Console.ReadLine());
            var Cred = Math.Sqrt(O * T);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((O + T) / 2 + " - cреднее арифметическое");
            Console.WriteLine(Cred + " - среднее геометрическое");

            Console.WriteLine("\nЗадание 8");
            Console.WriteLine("Плотность материала");
            var m = double.Parse(Console.ReadLine());
            var v = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(m / v + " - плотность");

            Console.WriteLine("\nЗадание 9");
            Console.WriteLine("Плотность населения");
            var p = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(p / s + " - плотность населения");

            Console.WriteLine("\nЗадание 10");
            Console.WriteLine("решение линейного уравнения ax+b=0 (a ≠ 0).");
            var A = Console.ReadLine();
            var B = Console.ReadLine();
            double Ad = Convert.ToDouble(A);
            double Bd = Convert.ToDouble(B);
            if (Ad == 0)
            {
                Console.WriteLine("Неверно");
            }
            else
            {
                Console.WriteLine("\nОтвет:");
                Console.WriteLine((-Bd / Ad) + " - x");
            }

            Console.WriteLine("\nЗадание 11");
            Console.WriteLine("гиппотенуза треугольника");
            var katet1 = double.Parse(Console.ReadLine());
            var katet2 = double.Parse(Console.ReadLine());
            var ANS = Math.Pow(katet1, 2) + Math.Pow(katet2, 2);
            var GGG = Math.Sqrt(ANS);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(GGG);

            Console.WriteLine("\nЗадание 12");
            Console.WriteLine("Площадь кольца");
            var RAD1 = double.Parse(Console.ReadLine());
            var RAD2 = double.Parse(Console.ReadLine());
            var SQ1 = Math.PI * Math.Pow(RAD1, 2);
            var SQ2 = Math.PI * Math.Pow(RAD2, 2);
            var MOD = Math.Abs(SQ1 - SQ2);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(MOD);


            Console.WriteLine("\nЗадание 13");
            Console.WriteLine("Периметр правильного треугольника");
            var Katet1 = double.Parse(Console.ReadLine());
            var Katet2 = double.Parse(Console.ReadLine());
            var aNS = Math.Pow(Katet1, 2) + Math.Pow(Katet2, 2);
            var GgG = Math.Sqrt(aNS);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((GgG + Katet1 + Katet2));


            Console.WriteLine("\nЗадание 13 A");
            Console.WriteLine("среднее арифметическое и среднее геометрическое модулей.");
            var O1 = double.Parse(Console.ReadLine());
            var T1 = double.Parse(Console.ReadLine());
            var O12 = Math.Abs(O1);
            var T12 = Math.Abs(T1);
            var Cred12 = Math.Sqrt(O12 * T12);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((O12 + T12) / 2 + " - cреднее арифметическое модулей");
            Console.WriteLine(Cred12 + " - среднее геометрическое модулей");


            Console.WriteLine("\nЗадание 14");
            Console.WriteLine("Периметр равнобедренной трапеции");
            var AB = double.Parse(Console.ReadLine());
            var CD = double.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());
            var Paz = Math.Abs((AB - CD) / 2);
            var AN = Math.Pow(Paz, 2) + Math.Pow(H, 2);
            var GG = Math.Sqrt(AN);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(GG * 2 + AB + CD);

            Console.WriteLine("\nЗадание 14 A");
            Console.WriteLine("Периметр и длина диагонали прямоугольника");
            var AB1 = double.Parse(Console.ReadLine());
            var CD1 = double.Parse(Console.ReadLine());
            var AN1 = Math.Pow(AB1, 2) + Math.Pow(CD1, 2);
            var GG1 = Math.Sqrt(AN1);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((AB1 + CD1) * 2 + " - периметр");
            Console.WriteLine(GG1 + " - диагональ");

            Console.WriteLine("\nЗадание 15");
            Console.WriteLine("Сумма, разность, произведение, частное");
            var J = double.Parse(Console.ReadLine());
            var K = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((J + K) + " - сумма" + "\n" + (J - K) + " - разность " + "\n" + (J * K) + " - произведение" + "\n" + (J / K) + " - частное");

            Console.WriteLine("\nЗадание 16");
            Console.WriteLine("Объем и площадь боковой поверхности прямоугольного параллелепипеда");
            side = double.Parse(Console.ReadLine());
            var side2 = double.Parse(Console.ReadLine());
            var side3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((((side + side2) * 2) + (2 * (side2 * side3))) + " - площадь боковой поверхности");
            Console.WriteLine((side * side2 * side3) + " - обЪем");


            Console.WriteLine("\nЗадание 17");
            Console.WriteLine("Расстояние между двумя точками");
            Console.WriteLine("\nВведите координаты 1 точки");
            var X1 = double.Parse(Console.ReadLine());
            var Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 2 точки");
            var X2 = double.Parse(Console.ReadLine());
            var Y2 = double.Parse(Console.ReadLine());
            var L = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(L);



            Console.WriteLine("\nЗадание 18");
            Console.WriteLine("Периметр трапеции");
            AB = double.Parse(Console.ReadLine());
            CD = double.Parse(Console.ReadLine());
            H = double.Parse(Console.ReadLine());
            Paz = Math.Abs((AB - CD) / 2);
            AN = Math.Pow(Paz, 2) + Math.Pow(H, 2);
            var GG7 = Math.Sqrt(AN);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(GG7 * 2 + AB + CD);

            Console.WriteLine("\nЗадание 19");
            Console.WriteLine("Площадь трапеции");
            AB = double.Parse(Console.ReadLine());
            CD = double.Parse(Console.ReadLine());
            var ygol = double.Parse(Console.ReadLine());
            var S = ((Math.Abs(Math.Pow(CD, 2) - Math.Pow(AB, 2))) * Math.Tan(ygol)) / 4;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(S);

            Console.WriteLine("\nЗадание 20");
            Console.WriteLine("Периметр и площадь треугольника");
            Console.WriteLine("\nВведите координаты 1 точки");
            X1 = double.Parse(Console.ReadLine());
            Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 2 точки");
            X2 = double.Parse(Console.ReadLine());
            Y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 3 точки");
            var X3 = double.Parse(Console.ReadLine());
            var Y3 = double.Parse(Console.ReadLine());
            var L1 = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            var L2 = Math.Sqrt(Math.Pow(X2 - X3, 2) + Math.Pow(Y2 - Y3, 2));
            var L3 = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            var Pp = (L1 + L2 + L3) / 2;
            S = Math.Sqrt(Pp * (Pp - L1) * (Pp - L2) * (Pp - L3));
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(S + " - площадь");
            Console.WriteLine(Pp * 2 + " - периметр");


            Console.WriteLine("\nЗадание 21");
            Console.WriteLine("Площадь четырехугольника");
            Console.WriteLine("\nВведите координаты 1 точки");
            X1 = double.Parse(Console.ReadLine());
            Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 2 точки");
            X2 = double.Parse(Console.ReadLine());
            Y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 3 точки");
            X3 = double.Parse(Console.ReadLine());
            Y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите координаты 4 точки");
            var X4 = double.Parse(Console.ReadLine());
            var Y4 = double.Parse(Console.ReadLine());
            L1 = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            L2 = Math.Sqrt(Math.Pow(X2 - X3, 2) + Math.Pow(Y2 - Y3, 2));
            L3 = Math.Sqrt(Math.Pow(X3 - X4, 2) + Math.Pow(Y3 - Y4, 2));
            var L4 = Math.Sqrt(Math.Pow(X4 - X1, 2) + Math.Pow(Y4 - Y1, 2));
            var L5 = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
            var Pp1 = (L1 + L2 + L5) / 2;
            var Pp2 = (L5 + L3 + L4) / 2;
            var S1 = Math.Sqrt(Pp1 * (Pp1 - L1) * (Pp1 - L2) * (Pp1 - L5));
            var S2 = Math.Sqrt(Pp2 * (Pp2 - L5) * (Pp2 - L3) * (Pp2 - L4));
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((S1 + S2));




            Console.WriteLine("\nЗадание 22");
            Console.WriteLine("конфеты, яблоки, печенье");
            Console.WriteLine("\nВВедите кол-во кг конфет,яблок, печенья");
            var kon = double.Parse(Console.ReadLine());
            var app = double.Parse(Console.ReadLine());
            var cook = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите цены за конфеты, яблоки, печенье");
            var konz = double.Parse(Console.ReadLine());
            var appz = double.Parse(Console.ReadLine());
            var cookz = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine((kon * konz) + (app * appz) + (cook * cookz));


            Console.WriteLine("\nЗадание 23");
            Console.WriteLine("Компьютеры");
            Console.WriteLine("\nВВедите цены за монитор, системный блок,клавиатуры и мыши");
            var mon = double.Parse(Console.ReadLine());
            var sis = double.Parse(Console.ReadLine());
            var klav = double.Parse(Console.ReadLine());
            var mice = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите кол-во компьютеров");
            var N = double.Parse(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(((mon + sis + klav + mice) * 3) + " - 3 компьютера");
            Console.WriteLine(((mon + sis + klav + mice) * N) + " - N компьютеров");


            Console.WriteLine("\nЗадание 24");
            Console.WriteLine("Таня и Митя");
            Console.WriteLine("\nВведите возраст Тани");
            var Tan = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите возраст Мити");
            var Mit = double.Parse(Console.ReadLine());
            Cred = (Mit + Tan) / 2;
            var Credm = Math.Abs(Cred - Mit);
            var Credt = Math.Abs(Cred - Tan);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(Cred + " - cредний возраст");
            Console.WriteLine(Credm + " - на столько отличается возраст Мити от среднего");
            Console.WriteLine(Credt + " - на столько отличается возраст Тани от среднего ");

            Console.WriteLine("\nЗадание 25");
            Console.WriteLine("Два автомобиля на встечу друг другу");
            Console.WriteLine("\nВведите cкорость первой машины");
            var First = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите скорость второй машины");
            var Second = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите расстояние");
            S = double.Parse(Console.ReadLine());
            Cred = S / (First + Second);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(Cred + " - Время");


            Console.WriteLine("\nЗадание 26");
            Console.WriteLine("Две машины друг за другом");
            Console.WriteLine("\nВведите cкорость первой машины");
            First = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите скорость второй машины");
            Second = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите расстояние");
            S = double.Parse(Console.ReadLine());
            var V = Math.Abs(First - Second);
            ANS = S + (V * 0.5);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(ANS + " - расстояние");


            Console.WriteLine("\nЗадание 27");
            Console.WriteLine("Градусы");
            Console.WriteLine("\nВведите градусы по Цельсию");
            var cel = double.Parse(Console.ReadLine());
            var far = cel * 1.8 + 32;
            var kel = cel + 273.15;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(far + " - Фаренгейта");
            Console.WriteLine(kel + " - Кельвина");

            Console.WriteLine("\nЗадание 27");
            Console.WriteLine("450 градусов по Фаренгейту");
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(232.222 + " - по Цельсию");


            Console.WriteLine("\nЧасть 3\nЗадание 1");
            Console.WriteLine("Новая личина");
            Console.WriteLine("\nВведите число a");
            a = Console.ReadLine();
            Console.WriteLine("\nВведите число b");
            b = Console.ReadLine();
            var c = b;
            b = a;
            a = c;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(a + " - a");
            Console.WriteLine(b + " - b");

            Console.WriteLine("Задание 2\nЧасть а");
            Console.WriteLine("Новая личина 2");
            Console.WriteLine("\nВведите число a");
            a = Console.ReadLine();
            Console.WriteLine("\nВведите число b");
            b = Console.ReadLine();
            Console.WriteLine("\nВведите число c");
            c = Console.ReadLine();
            var d = a;
            a = b;
            b = c;
            c = d;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(a + " - a");
            Console.WriteLine(b + " - b");
            Console.WriteLine(c + " - c");

            Console.WriteLine("\nЧасть б");
            Console.WriteLine("Новая личина 3");
            Console.WriteLine("\nВведите число a");
            a = Console.ReadLine();
            Console.WriteLine("\nВведите число b");
            b = Console.ReadLine();
            Console.WriteLine("\nВведите число c");
            c = Console.ReadLine();
            d = c;
            c = b;
            b = a;
            a = d;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(a + " - a");
            Console.WriteLine(b + " - b");
            Console.WriteLine(c + " - c");

            Console.WriteLine("Задание 3\nЧасть а");
            Console.WriteLine("а в 4");
            Console.WriteLine("\nВведите число a");
            var a1 = double.Parse(Console.ReadLine());
            var b1 = a1 * a1;
            var c1 = b1 * b1;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c1 + " a в 4");


            Console.WriteLine("\nЧасть б");
            Console.WriteLine("а в 6");
            Console.WriteLine("\nВведите число a");
            var a2 = double.Parse(Console.ReadLine());
            var b2 = a2 * a2 * a2;
            var c2 = b2 * b2;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c2 + " a в 6");

            Console.WriteLine("\nЧасть B");
            Console.WriteLine("а в 7");
            Console.WriteLine("\nВведите число a");
            var a3 = double.Parse(Console.ReadLine());
            var b3 = a3 * a3 * a3;
            var c3 = b3 * b3 * a3;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c3 + " a в 7");

            Console.WriteLine("\nЧасть Г");
            Console.WriteLine("а в 8");
            Console.WriteLine("\nВведите число a");
            var a4 = double.Parse(Console.ReadLine());
            var b4 = a4 * a4;
            var c4 = b4 * b4;
            var d4 = c4 * c4;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d4 + " a в 8");


            Console.WriteLine("\nЧасть Д");
            Console.WriteLine("а в 9");
            Console.WriteLine("\nВведите число a");
            var a5 = double.Parse(Console.ReadLine());
            var b5 = a5 * a5;
            var c5 = b5 * b5;
            var d5 = c5 * c5 * a5;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d5 + " a в 9");


            Console.WriteLine("\nЧасть E");
            Console.WriteLine("а в 10");
            Console.WriteLine("\nВведите число a");
            var a6 = double.Parse(Console.ReadLine());
            var b6 = a6 * a6;
            var c6 = b6 * b6;
            var d6 = c6 * c6 * b6;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d6 + " a в 10");


            Console.WriteLine("Задание 4\nЧасть а");
            Console.WriteLine("а в 3 и а в 10");
            Console.WriteLine("\nВведите число a");
            var a7 = double.Parse(Console.ReadLine());
            var b7 = a7 * a7;//a2
            var c7 = b7 * a7; //a3
            var d7 = c7 * b7; //a5
            var e7 = d7 * d7; //a10
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c7 + " a в 3");
            Console.WriteLine(c7 + " a в 10");

            Console.WriteLine("\nЧасть б");
            Console.WriteLine("а в 4 и а в 20");
            Console.WriteLine("\nВведите число a");
            var a8 = double.Parse(Console.ReadLine());
            var b8 = a8 * a8;//a2
            var c8 = b8 * b8; //a4
            var d8 = c8 * c8; //a8
            var e8 = d8 * b8; //a10
            var f8 = e8 * e8;//a20
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c8 + " a в 4");
            Console.WriteLine(f8 + " a в 20");

            Console.WriteLine("\nЧасть B");
            Console.WriteLine("а в 5 и а в 13");
            Console.WriteLine("\nВведите число a");
            var a9 = double.Parse(Console.ReadLine());
            var b9 = a9 * a9;//a2
            var c9 = b9 * b9; //a4
            var d9 = c9 * a9; //a5
            var e9 = d9 * c9 * c9; //a13
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d9 + " a в 5");
            Console.WriteLine(e9 + " a в 13");

            Console.WriteLine("\nЧасть Г");
            Console.WriteLine("а в 5 и а в 19 за 6 операций");
            Console.WriteLine("\nВведите число a");
            var a10 = double.Parse(Console.ReadLine());
            var b10 = a10 * a10;//a2
            var c10 = b10 * b10; //a4
            var d10 = c10 * a10; //a5
            var e10 = d10 * c10; //a9
            var f10 = e10 * e10;//a18
            var g10 = f10 * a10;// a19
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d10 + " a в 5");
            Console.WriteLine(g10 + " a в 19");


            Console.WriteLine("\nЧасть Д");
            Console.WriteLine("а в 2, a в 5 и а в 17 за 6 операций");
            Console.WriteLine("\nВведите число a");
            var a11 = double.Parse(Console.ReadLine());
            var b11 = a11 * a11;//a2
            var c11 = b11 * b11; //a4
            var d11 = c11 * a11; //a5
            var e11 = d11 * c11; //a9
            var f11 = e11 * c11;//a13
            var g11 = f11 * c11;// a17
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(b11 + " a в 2");
            Console.WriteLine(d11 + " a в 5");
            Console.WriteLine(g11 + " a в 17");

            Console.WriteLine("\nЧасть E");
            Console.WriteLine("а в 4, a в 12 и а в 28 за 6 операций");
            Console.WriteLine("\nВведите число a");
            var a12 = double.Parse(Console.ReadLine());
            var b12 = a12 * a12;//a2
            var c12 = b12 * b12; //a4
            var d12 = c12 * b12; //a6
            var e12 = d12 * d12; //a12
            var f12 = e12 * e12;//a24
            var g12 = f12 * c12;// a17
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c12 + " a в 4");
            Console.WriteLine(e12 + " a в 12");
            Console.WriteLine(g12 + " a в 28");


            Console.WriteLine("Задание 5\nЧасть а");
            Console.WriteLine("а в 3 и а в 10");
            Console.WriteLine("\nВведите число a");
            a7 = 1010;
            b7 = a7 * a7;//a2
            c7 = b7 * a7; //a3
            d7 = c7 * b7; //a5
            e7 = d7 * d7; //a10
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c7 + " a в 3");
            Console.WriteLine(c7 + " a в 10");

            Console.WriteLine("\nЧасть б");
            Console.WriteLine("а в 4 и а в 20");
            Console.WriteLine("\nВведите число a");
            a8 = 1010;
            b8 = a8 * a8;//a2
            c8 = b8 * b8; //a4
            d8 = c8 * c8; //a8
            e8 = d8 * b8; //a10
            f8 = e8 * e8;//a20
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c8 + " a в 4");
            Console.WriteLine(f8 + " a в 20");

            Console.WriteLine("\nЧасть B");
            Console.WriteLine("а в 5 и а в 13");
            Console.WriteLine("\nВведите число a");
            a9 = 1010;
            b9 = a9 * a9;//a2
            c9 = b9 * b9; //a4
            d9 = c9 * a9; //a5
            e9 = d9 * c9 * c9; //a13
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d9 + " a в 5");
            Console.WriteLine(e9 + " a в 13");

            Console.WriteLine("\nЧасть Г");
            Console.WriteLine("а в 5 и а в 19 за 6 операций");
            Console.WriteLine("\nВведите число a");
            a10 = 1010;
            b10 = a10 * a10;//a2
            c10 = b10 * b10; //a4
            d10 = c10 * a10; //a5
            e10 = d10 * c10; //a9
            f10 = e10 * e10;//a18
            g10 = f10 * a10;// a19
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(d10 + " a в 5");
            Console.WriteLine(g10 + " a в 19");


            Console.WriteLine("\nЧасть Д");
            Console.WriteLine("а в 2, a в 5 и а в 17 за 6 операций");
            Console.WriteLine("\nВведите число a");
            a11 = 1010;
            b11 = a11 * a11;//a2
            c11 = b11 * b11; //a4
            d11 = c11 * a11; //a5
            e11 = d11 * c11; //a9
            f11 = e11 * c11;//a13
            g11 = f11 * c11;// a17
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(b11 + " a в 2");
            Console.WriteLine(d11 + " a в 5");
            Console.WriteLine(g11 + " a в 17");

            Console.WriteLine("\nЧасть E");
            Console.WriteLine("а в 4, a в 12 и а в 28 за 6 операций");
            Console.WriteLine("\nВведите число a");
            a12 = 1010;
            b12 = a12 * a12;//a2
            c12 = b12 * b12; //a4
            d12 = c12 * b12; //a6
            e12 = d12 * d12; //a12
            f12 = e12 * e12;//a24
            g12 = f12 * c12;// a17
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(c12 + " a в 4");
            Console.WriteLine(e12 + " a в 12");
            Console.WriteLine(g12 + " a в 28");



            Console.ReadKey();
        }
    }
}


