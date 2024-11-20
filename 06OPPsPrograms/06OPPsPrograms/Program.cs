namespace _06OPPsPrograms
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        private void Method2()
        {
            Console.WriteLine("Method 2");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("This is protected");
        }
    }
    class B : A 
    {
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        public void callProtacted()
        {
            this.protectedMethod();
        }
    }
    class C : B
    {
        public void Method4()
        {
            Console.WriteLine("Method 4");
        }
    }
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
            B b = new B();
            b.Method3();
            b.Method1();
            C cobj = new C();
            cobj.Method4();
            cobj.Method1();
            b.callProtacted();
        }
    }
}
