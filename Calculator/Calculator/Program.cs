namespace Calculator;
using MenuClass;

public class Program
{
    static void Main()
    {
        List<string> sections = new List<string>()
        {
            "SUM",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE"
        };

        Menu menu = new Menu(sections);

        while (true)
            menu.ShowMenu("CALCULATOR MENU");
    }
}