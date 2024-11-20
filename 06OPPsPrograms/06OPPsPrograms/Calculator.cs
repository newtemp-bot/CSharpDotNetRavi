using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06OPPsPrograms
{
    class Calculator
    {
        public int test = 0;
        public string s;
        private static Calculator o;
        private Calculator() 
        {
            Console.WriteLine("Calaculator Obj Created...");
        }
        public Calculator(int x) 
        {
            test = x;
            Console.WriteLine("X is = "+test);
        }
        public Calculator(Calculator obj) 
        {
            test = obj.test;
            Console.WriteLine("X is = "+test);
        }
        ~Calculator() {
            Console.WriteLine("Object Distructor called");
        }
        public void sum(int x,int y)
        {
            Console.WriteLine("Your Sum is = "+(x+y));
        }
        public static Calculator createMemo()
        {
            if (o == null)
            {
                o = new Calculator();
            }
            return o;
        }
    }
}
