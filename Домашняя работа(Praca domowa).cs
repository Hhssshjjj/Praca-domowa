using System;

namespace project
{


    class Program
    {
        static void Main()
        {
            /*Функции 1-10(Funkcje 1-10)*/
            funkcja1();
            /*Функция 11(Funkcja 11)*/
            Console.WriteLine("Введите x :");
            int x1 = int.Parse(Console.ReadLine());
            funkcja11(x1);
            /*Функция 12(Funkcja 12)*/
            Console.WriteLine("Введите x :");
            int x2 = int.Parse(Console.ReadLine());
            funkcja12(x2);
            /*Функция 13(Funkcja 13)*/
            Console.WriteLine("Введите сторону прямоугольника(a) :");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника(b) :");
            int b2 = int.Parse(Console.ReadLine());
            funkcja13(b1,b2);
            /*Функция 14(Funkcja 14)*/
            Console.WriteLine("Введите сторону прямоугольника(a) :");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника(b) :");
            int c2 = int.Parse(Console.ReadLine());
            funkcja14(c1, c2);
            /*Функция 15(Funkcja 15)*/
            Console.WriteLine("Введите радиус сектора :");
            int g1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол сектора :");
            int g2 = int.Parse(Console.ReadLine());
            funkcja15(g1, g2);
            /*Функция 16(Funkcja 16)*/
            Console.WriteLine("Введите значение a :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b :");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c :");
            int n3 = int.Parse(Console.ReadLine());
            funkcja16(n1, n2 ,n3);
            /*Функция 17(Funkcja 17)*/
            Console.WriteLine("Введите предложениe :");
            string word = Console.ReadLine();
            funkcja17(word);
            /*Функция 18(Funkcja 18)*/
            Console.WriteLine("Введите высоту ромба :");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону ромба :");
            int k2 = int.Parse(Console.ReadLine());
            funkcja18(k1 , k2);
            /*Функция 19(Funkcja 19)*/
            Console.WriteLine("Введите сторону ромба :");
            int u1 = int.Parse(Console.ReadLine());
            funkcja19(u1);
            /*Функция 20(Funkcja 20)*/
            Console.WriteLine("Введите верхнее основание :");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите нижнее основание :");
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту :");
            int r3 = int.Parse(Console.ReadLine());
            funkcja20(r1, r2, r3);
            /*Функция 21(Funkcja 21)*/
            Console.WriteLine("Введите сторону шестиугольника :");
            int kr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту шестиугольника :");
            int kr2 = int.Parse(Console.ReadLine());
            funkcja21(kr1, kr2);
            /*Функция 22(Funkcja 21)*/
            Console.WriteLine("Введите сторону шестиугольника :");
            int kr4 = int.Parse(Console.ReadLine());
            funkcja22(kr4);
            /*Функция 23(Funkcja 23)*/
            Console.WriteLine("Введите m :");
            int rk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите g :");
            int rk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите h :");
            int rk3 = int.Parse(Console.ReadLine());
            funkcja23(rk1, rk2 ,rk3);
            /*Функция 24(Funkcja 24)*/
            Console.WriteLine("Введите m :");
            int rk5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите V :");
            int rk6 = int.Parse(Console.ReadLine());
            funkcja24(rk5, rk6);
            /*Функция 25(Funkcja 25)*/
            Console.WriteLine("Введите m :");
            int rk8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите g :");
            int rk9 = int.Parse(Console.ReadLine());
            funkcja24(rk5, rk6);


        }

        public static void funkcja1()
        /*Площадь квадрата(S kwadrata)*/
        {
            Console.WriteLine("Введите сторону квадрата(Bok kwadratu):");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь квадрата(S kwadratu):");
            Console.WriteLine(Math.Pow(a, 2));
        }

        public static void funkcja2()
        /*Периметр квадрата(P kwadrata)*/
        {
            Console.WriteLine("Введите сторону квадрата(Bok kwadratu):");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр квадрата(P kwadratu):");
            Console.WriteLine(4 * b);
        }
        public static void funkcja3()
        /*Площадь круга(S koła)*/
        {
            Console.WriteLine("Введите радиус круга(R koła):");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга(S koła):");
            Console.WriteLine(Math.PI * Math.Pow(c, 2));
        }
        public static void funkcja4()
        /*Длинна окружности круга(С koła)*/
        {
            Console.WriteLine("Введите радиус круга(R koła):");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Длинна окружности круга(C koła):");
            Console.WriteLine(2 * Math.PI * d);
        }
        public static void funkcja5()
        /*Площадь прямоугольного треугольника(S trójkąta prostokątego )*/
        {
            Console.WriteLine("Введите сторону треугольника(bok trójkąta prostokątego):");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника(drugi bok trójkąta prostokątego ):");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольного треугольника(S trójkąta prostokątego):");
            Console.WriteLine((e * f) / 2);
        }
        public static void funkcja6()
        /*Периметр треугольника(P trójkąta)*/
        {
            Console.WriteLine("Введите сторону треугольника(bok trójkąta prostokątego):");
            double g = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника(drugi bok trójkąta prostokątego ):");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника(trzeczi bok trójkąta prostokątego ):");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр треугольника(P trójkąta):");
            Console.WriteLine(g + h + i);
        }
        public static void funkcja7()
        /*Площадь  треугольника(S trójkąta)*/
        {
            Console.WriteLine("Введите сторону треугольника(bok trójkąta):");
            double j = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту треугольника(h trójkąta):");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь  треугольника(S trójkąta):");
            Console.WriteLine(j * k * 0.5);
        }
        public static void funkcja8()
        /*Площадь  треугольника через pr2(S trójkąta pr2)*/
        {
            Console.WriteLine("Введите полупериметр треугольника(p trójkąta):");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус вписанной окружности треугольника(r trójkąta):");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь  треугольника(S trójkąta):");
            Console.WriteLine(l * Math.Pow(m, 2));
        }
        public static void funkcja9()
        /*Площадь  треугольника по его сторонам(S trójkąta abc)*/
        {
            Console.WriteLine("Введите сторону треугольника(bok trójkąta):");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника(bok trójkąta):");
            double o = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника(bok trójkąta):");
            double z = double.Parse(Console.ReadLine());
            double p = n + o + z;
            double x = p * (p - z);
            double y = x * (p - o);
            double v = y * (p - n);
            Console.WriteLine("Площадь  треугольника(S trójkąta):");
            Console.WriteLine(Math.Sqrt(v));
        }
        public static void funkcja10()
        /*Площадь  трапеции(S trapezowy)*/
        {
            Console.WriteLine("Введите нижнее основание трапеции(dolna podstawa trapezu):");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнее основание трапеции(gorna pódstawa trapezu):");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции(h trapezu):");
            double a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь  трапеции(S trapezu):");
            Console.WriteLine((a1 + a2) / 2 * a3);
        }

        public static void funkcja11(int x1)
        /*Возведение числа в квадрат(x2)*/
        {
            int t = x1*x1;
            Console.WriteLine(t);
        }

        public static void funkcja12(int x2)
        /*Возведение числа в квадрат(x3)*/
        {
            int p = x2 * x2*x2;
            Console.WriteLine(p);
        }

        public static void funkcja13(int b1,int b2)
        /*Площадь прямоугольника(S prostokąta)*/
        {
            int p1 = b1*b2;
            Console.WriteLine(p1);
        }
        public static void funkcja14(int c1, int c2)
        /*Периметр прямоугольника(P prostokąta)*/
        {
            int t1 = c1 * c2;
            Console.WriteLine(t1);
        }

        public static void funkcja15(int g1, int g2)
        /*Площадь сектора(S sektora)*/
        {
            double t2 = 0.5*g1*g1*g2;
            Console.WriteLine(t2);
        }
        public static void funkcja16(int n1, int n2 , int n3)
        /*Дискрименант(D)*/
        {
            int D = (n2 * n2) - 4 * n1 * n3;
            Console.WriteLine(D);
        }
        public static void funkcja17(string word)
        /*Предложение*/
        {
            Console.WriteLine(word);
        }
        public static void funkcja18(int k1 ,int k2)
        /*Площадь ромба(S rombu)*/
        {
            int k3 = k1 * k2;
            Console.WriteLine(k3);
        }
        public static void funkcja19(int u1)
        /*Периметр ромба(P rombu)*/
        {
            int u2 = 4 * u1;
            Console.WriteLine(u2);
        }
        public static void funkcja20(int r1, int r2 ,int r3)
        /*Средняя линия трапеции(m trapezu)*/
        {
            int r4 = (r1+r2)/2*r3;
            Console.WriteLine(r4);
        }
        public static void funkcja21(int kr1, int kr2)
        /*Площадь шестиугольника*/
        {
            int kr3 = (kr1 + kr2)*6;
        }

        public static void funkcja22(int kr4)
        /*Периметр шестиугольника*/
        {
            int kr5 = kr4 * 6;
        }
        public static void funkcja23(int rk1,int rk2,int rk3)
        /*Формула нахождения потенциальной энергии*/
        {
            int rk4 = rk1 * rk2*rk3;
        }
        public static void funkcja24(int rk5, int rk6)
        /*Плотность тела*/
        {
            int rk7 = rk5 / rk6;
        }
        public static void funkcja25(int rk8, int rk9)
        /* Сила тяжести*/
        {
            int rk10 = rk8 * rk9;
        }

    }
}