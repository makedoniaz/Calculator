namespace MenuClass;

public class Menu
{
    private List<string> sections = new List<string>();
    private int currentSectionIndex = 0;

    public int CurrentSectionIndex
    {
        get => currentSectionIndex;
        set
        {
            if (value < 0 || value >= sections.Count)
                throw new ArgumentOutOfRangeException();

            currentSectionIndex = value;
        }

    }

    public List<string> Sections
    {
        get => sections;
        set
        {
            if (value == null)
                throw new ArgumentNullException();

            sections = value;
        }
    }

    public Menu(List<string> sections)
    {
        Sections = sections;
    }



    public virtual int ShowMenu(string menuTitle)
    {
        CurrentSectionIndex = 0;

        while (true)
        {
            Console.WriteLine(menuTitle + "\n");
            for (int i = 0; i < Sections.Count; i++)
            {
                if (i == CurrentSectionIndex)
                    Console.Write("> ");

                Console.WriteLine(Sections[i]);
            }

            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.W:
                    if (CurrentSectionIndex != 0)
                        CurrentSectionIndex--;

                    break;

                case ConsoleKey.S:
                    if (CurrentSectionIndex != Sections.Count - 1)
                        CurrentSectionIndex++;

                    break;

                case ConsoleKey.Enter:
                    return CurrentSectionIndex;

                case ConsoleKey.Escape:
                    return -1;
            }
            Console.Clear();
        }
    }
}

