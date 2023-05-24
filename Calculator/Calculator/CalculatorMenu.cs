namespace CalculatorMenu;
using MenuClass;

public class CalculatorMenu : Menu
{
    public CalculatorMenu(List<string> sections) : base(sections) { }

    public override int ShowMenu(string menuTitle)
    {
        Console.Clear();
        int curSectionIndex = base.ShowMenu(menuTitle);
        Console.Clear();

        if (curSectionIndex == 4)
            Environment.Exit(0);

        Console.WriteLine("Enter two numbers: ");

        if (double.TryParse(Console.ReadLine(), out double num1) == false)
            throw new ArgumentException();

        if(double.TryParse(Console.ReadLine(), out double num2) == false)
            throw new ArgumentException();

        switch (curSectionIndex)
        {
            case 0:
                Console.WriteLine(num1 + num2);
                break;
            case 1:
                Console.WriteLine(num2 - num1);
                break;

            case 2:
                Console.WriteLine(num1 * num2);
                break;
            case 3:
                Console.WriteLine(num1 / num2);
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        return 0;
    }
}
