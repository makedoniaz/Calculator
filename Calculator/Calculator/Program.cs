namespace Calculator;
using CalculatorMenu;

public class Program
{
    static void Main()
    {
        List<string> sections = new List<string>()
        {
            "SUM",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE",
            "EXIT",
        };

        CalculatorMenu calculatorMenu = new CalculatorMenu(sections);

        while (true)
            calculatorMenu.ShowMenu("CALCULATOR MENU");
    }
}