namespace _06OPPsPrograms
{
    class A
    {
        public A(int a)
        {
            Console.WriteLine("Constructor A called...");
        }
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
        public B(int num) : base(num) 
        {
            Console.WriteLine("Constructor B called...");
        }
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
        public C(int num) : base(num)
        {
            Console.WriteLine("Constructor c called...");
        }
        public void Method4()
        {
            Console.WriteLine("Method 4");
        }
    }
    class D : A
    {
        public D(int a) : base(a)
        {
            
        }
        public void display(string s)
        {
            Console.WriteLine(s);
        }
    }
    internal class Program : Demo2
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
            B b = new B(20);
            b.Method3();
            b.Method1();
            C cobj = new C(50);
            cobj.Method4();
            cobj.Method1();
            b.callProtacted();
            D d = new D(50);
            d.Method1();
            d.display("Hello how are you?");
            Program p2 = new Program();
            //p2.sum(10, 20);
            p2.math();
        }

        public void math()
        {
            Console.WriteLine("This is interface");
        }
    }
}
