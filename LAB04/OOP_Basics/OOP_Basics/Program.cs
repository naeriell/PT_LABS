using OOP_Basics;

class Program
{
    static void Main()
    {
        Linear eq1 = new Linear(3, -4);
        eq1.PrintEquation();
        Console.WriteLine($"eq1 при x=1: {eq1.Calculate(1)}");

        Linear eq2 = new Linear(0, 7);
        eq2.PrintEquation();
        Console.WriteLine($"eq2 при x=-8: {eq2.Calculate(-8)}");

        Linear eq3 = new Linear(-2, 0);
        eq3.PrintEquation();
        Console.WriteLine($"eq3 при x=3: {eq3.Calculate(3)}");



    }
}