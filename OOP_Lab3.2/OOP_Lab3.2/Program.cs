using System;

namespace OOP_Lab3._2
{
    public class Parent
    {
        protected float pole1;
        protected float pole2;

        public Parent()//Конструктор без параметрів
        {
        }

        public Parent(float pole1, float pole2)//Конструктор, що привласнює значення полів
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
        }

        public void Print()
        {
            Console.Write("a = {0}", pole1);
            Console.WriteLine(", b = {0}", pole2);
        }

        public float Metod1()//Площа прямокутника
        {
            return pole1 * pole2;
        }
        public float Metod2()//Периметр прямокутника
        {
            return 2 * (pole2 + pole1);
        }
    }

    public class Child  : Parent
    {
        private float r;
        public Child(float x)
        {
            pole1 = x; pole2 = x;
            r = x / 2;
        }
        public double Metod3()
        {
            return Math.PI * r * r;
        }
        public double Metod4()
        {
            return 2 * Math.PI * r;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            float s, p;
            for(int i = 0; i < 5; i++)
            {
                int x = random.Next(1, 5); int y = random.Next(1, 5);
                if (x != y)
                {
                    Parent pa = new Parent(x, y);
                    pa.Print();
                    s = pa.Metod1();
                    p = pa.Metod2();
                    Console.WriteLine("Прямокутник: S = {0}, P = {1}", s, p);
                    Console.WriteLine();
                }
                else
                {
                    Child ch = new Child(x);
                    ch.Print();
                    s = ch.Metod1();
                    p = ch.Metod2();
                    Console.WriteLine("Квадрат: S = {0}, P = {1}", s, p);
                    double sp = ch.Metod3();
                    double pp = ch.Metod4();
                    Console.WriteLine("Вписане коло: Площа = {0:F2} , Довжина = {1:F2}", sp, pp);
                    Console.WriteLine();
                }
            }
        }
    }
}
