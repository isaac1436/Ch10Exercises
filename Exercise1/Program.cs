class Exercise1
{
    //an exerise using recursion to print out all possible number combinations of 12345 with repetition allowed
    static int[] vals;
    static void Main()
    {
        Console.Write("Please enter a number: ");
        bool errorCatch = int.TryParse(Console.ReadLine(), out int n);
        if (errorCatch = false)
        {
            Console.WriteLine("Invalid Value entered");
        }
        else
        {
            vals = new int[n];
            NestedLoops(0);
        }
    }

    static void NestedLoops(int k)
    {
        if (k == vals.Length)
        {
            PrintLoops();
            return;
        }

        for (int i = 1; i <= vals.Length; i++)
        {
            vals[k] = i;
            NestedLoops(k+1);
        }
    }

    static void PrintLoops()
    {
        for (int i = 0; i < vals.Length; i++)
        {
            Console.Write(vals[i] + " ");
        }
        Console.WriteLine("\n");
    }
}