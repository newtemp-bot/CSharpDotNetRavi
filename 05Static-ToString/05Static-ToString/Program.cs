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
        static int x = 10;
        static void display() {
            Console.WriteLine("HelloDisplay");
        }

        static void Main(string[] args)
        {
            const float PI = 3.14f;//you can also use readonly if dont want to Initialization.
            Console.WriteLine("Hello, World!");
            display();
            Console.WriteLine(x);
            Demo d = new Demo(90);
            Demo d2 = new Demo(80);
            d.z = 50;
            Demo.subject = "Sic";
            d2.z = 60;
            d.display();
            d2.display();
            d.disread();
            d.jadu = x;
            d.name = "hello";
            Console.WriteLine(d.name);
        }
    }
}
