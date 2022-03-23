class Exercise4
{
    static string[] strIngs;
    static int length, length2;
    static void Main()
    {
        bool errorCatch=false;

        while (errorCatch == false)
        {
            Console.Write("Enter the number of strings you'd like to enter: ");
            errorCatch = int.TryParse(Console.ReadLine(), out length);
            Console.Write("Enter the length of the subsets you'd like: ");
            errorCatch = int.TryParse(Console.ReadLine(), out length2);
        }
        if (errorCatch)
        {
            string[] strings = new string[length];
            Console.WriteLine("\nPlease enter the elements below and press enter to signify a new element: ");

            for (int i = 0; i < length; i++)
            {
                strings[i] = Console.ReadLine();
            }
            strIngs = strings;
            RecursiveSubsets(0);
        }
    }

    static int ewo = 1,a=0,b=1;
    static void RecursiveSubsets(int count)
    {
        if (count == length2)
        {
            PrintLoops();
            a++;
            return;
        }

        for (int i = ewo; i <= strIngs.Length; i++)
        {
            RecursiveSubsets(count + 1);
        }
        ewo++;
        b++;
    }

    static void PrintLoops()
    {
        Console.Write("( " + strIngs[a]);
        for (int i = 1; i < length2; i++)
        {
            Console.Write(", " + strIngs[b]);
        }
        Console.Write(" )\t");
    }
}
