namespace _06OPPsPrograms
{
    internal class Program
    {
        void display()
        {
            Console.WriteLine("Hello Display");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();

            Calculator c = new Calculator(25);
            Calculator c2 = new Calculator(c);
            c.sum(10, 20);
            Console.WriteLine(c.test);
            if (c.s==null)
            {
                Console.WriteLine("c.s is null");
            }
            Calculator c3 = Calculator.createMemo();
            Calculator c4 = Calculator.createMemo();
            Console.WriteLine("Hello, World!");
        }
    }
}
