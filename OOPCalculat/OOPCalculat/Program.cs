using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculat
{
    class Program {
        static void Main()
        {
            //Console.ReadLine();
            var obj = new Calculator(2, 2);
            obj.Mnoj();
            Console.WriteLine("Результат умножения  2 и 2 равен :" + obj.Mnoj());
            obj.Del();
            Console.WriteLine("Результат деления 2 и 2 равен :" + obj.Del());
            obj.Add();
            Console.WriteLine("Результат сложения 2 и 2 равен :" + obj.Add());
            obj.Min();
            Console.WriteLine("Результат отнимания 2 и 2 равен : " + obj.Min());
        }

    }

    class Calculator
    {
        public int  x, y;
       
       

        public Calculator(int i,int j)
        {
            x = i;
            y = j;

        }

        public int Add()
        {
            return x + y;
        }

        public int Min()
        {
            return x - y;
        }

        public int Del()
        {
            return x / y;
        }

        public int Mnoj()
        {
            return x * y;
        }

            
    }
}
