using System.Text;

namespace _04UsefulFunctions
{
    public class Employee
    {
        public int emp_id;
        public string name;
    }
    
    internal class Program
    {
        public static int rec(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                return n + rec(n - 1);
            }
            else
            { 
                return n;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);
            //Console.WriteLine(args[2]);

            string str = "Ashok";

            if (args.Length>0)
            {
                Employee emp = new Employee();
                emp.emp_id = 1;
                emp.name = "Test";

                Employee emp2 = emp;
                emp2.name = "Smith";

                Console.WriteLine("Emp Obj id = " + emp.emp_id);
                Console.WriteLine("Emp Obj name = " + emp.name);
                Console.WriteLine("Emp Obj id = " + emp2.emp_id);
                Console.WriteLine("Emp Obj name = " + emp2.name);
                Console.WriteLine(rec(5));
            }
            else
            {
                Console.WriteLine("Please contact your devloper.");
            }
            str += String.Concat(" Prajapati");
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello\n");
            sb.Append("World");
            str = sb.ToString();
            Console.WriteLine(str);
            
        }
    }
}
