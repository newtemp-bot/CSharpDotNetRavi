using Animals;

namespace _02ProjectALLConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            string str = "Ashok Prajapati";
            Console.WriteLine("Hello, World!");
            Cat cat = new Cat();
            cat.meaow();
            Console.WriteLine(str);
            Console.WriteLine("Name = "+str);
            Console.WriteLine($"Jadu {str}");
            Console.WriteLine("Enter Your name = ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1);
        }
    }
}
