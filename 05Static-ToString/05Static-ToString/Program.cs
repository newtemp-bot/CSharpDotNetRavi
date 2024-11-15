namespace _05Static_ToString
{
    public class Demo
    {
        private int _Id;
        public string name { get; set; }
        readonly int xy; 
        public int z = 20;
        public static string subject = "Maths";

        public int jadu
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public Demo(int xy)
        {
            this.xy = xy;
        }

        public void display()
        {
            Console.WriteLine(z);
            Console.WriteLine(subject);
        }
        public void disread()
        {
            Console.WriteLine(xy);
        }
    }
    internal class Program
    {
        static int z = 10;
        static void display() {
            Console.WriteLine("HelloDisplay");
        }

        static void Main(string[] args)
        {
            const float PI = 3.14f;//you can also use readonly if dont want to Initialization.
            Console.WriteLine("Hello, World!");
            display();
            Console.WriteLine(z);
            Demo d = new Demo(90);
            Demo d2 = new Demo(80);
            d.z = 50;
            Demo.subject = "Sic";
            d2.z = 60;
            d.display();
            d2.display();
            d.disread();
            d.jadu = z;
            d.name = "hello";
            Console.WriteLine(d.name);

            //TOstring Ex
            ToStringEx e = new ToStringEx();
            e.dis();
            Console.WriteLine(e.ToString());

            //Equals Method
            int x = 20;
            int y = 50;
            string a = "Hello";
            string b = "hello";
            Console.WriteLine(x==y);
            Console.WriteLine(x.Equals(y));
            Console.WriteLine(a==b);
            Console.WriteLine(a.Equals(b));

            //override equals
            ToStringEx e1 = new ToStringEx();
            e1.number = 20;
            e1.n2 = 50;
            ToStringEx e2 = new ToStringEx();
            e2.number = 20;
            e2.n2 = 60;

            string test = null;
            Console.WriteLine(Convert.ToString(test));

            Console.WriteLine(e1.Equals(e2));
        }
    }
}
