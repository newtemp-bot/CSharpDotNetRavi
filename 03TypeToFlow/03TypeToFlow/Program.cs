namespace _03TypeToFlow
{
    internal class Program
    {
        public static bool isPalindrom(int x)
        {
            int temp = x,sum=0;
            while(x>0)
            {
                int rem = x % 10;
                sum = (sum * 10)+rem;
                x = x / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
            
        }
        public static void display()
        {
            Console.WriteLine("This is the write line");
        }
        public static void display(int a)
        {
            Console.WriteLine("This is the write line = "+a);
        } 
        public static string displayRe()
        {
            return "This is the write line return";
        }
        public static string displayRe(int a,int b)
        {
            return "This is the write line return = "+(a+b);
        }
        static void Main(string[] args)
        {
            display();
            display(125);
            string str = displayRe();
            Console.WriteLine(str);
            Console.WriteLine(displayRe());
            Console.WriteLine(displayRe(10,20));
            int a = 50;
            float b = 20.3564654651324f;
            a = Convert.ToInt16(b);
            a = (int)b;
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            int[] c = { 10, 20, 30, 40 };
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 30)
                    continue;
                Console.WriteLine(c[i]);
            }
            //foreach (int item in c)
            //{
            //    Console.WriteLine(item);
            //}
            if (isPalindrom(1421))
                Console.WriteLine("Yes it is palindrom");
            else
                Console.WriteLine("No it not");
        }
    }
}
