namespace ItzinRemastered;

class Program
{
    static void Main(string[] args)
    {
        Calculation calc = new Calculation();
        String choice = "";

        Console.WriteLine("Please enter C for calculation:");

        choice = Console.ReadLine().ToUpper();

        if (choice == "C")
        {
            calc.Calc();
            calc.Show();
            calc.SimpleCalc();
            calc.RelativeCalc();
            calc.ChangesCalc();
            calc.AntiCalc();
        }
        Console.ReadKey();
    }
}