using System;

namespace ConsoleApp10
{
    class Num
    {
        public int _num1;
        public int _num2;
        public Num()
        {

        }
        public Num(int num1)
        {
            _num1 = num1;
        }
        public Num(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public void Display()
        {
            Console.WriteLine(_num1+" "+_num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Num num = new Num();
            num.Display();
            Num num_1 = new Num(5);
            num_1.Display();
            Num num_2 = new Num(8, 7);
            num_2.Display();
            Console.ReadKey();
        }
    }
}
