using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class DestructorEx
    {
        public DestructorEx()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorEx()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DestructorEx obj1 = new DestructorEx();
            DestructorEx obj2 = new DestructorEx();
            //Making obj1 for Garbage Collection
            obj1 = null;
            Console.ReadKey();
        }
    }
}
