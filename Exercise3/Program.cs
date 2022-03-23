class Exercise3
{
    //an exerise using recursion to print out all possible number combinations of 12345 without repetition allowed
    static int[] vals;
    static int k;
    static void Main()
    {
        Console.Write("Please enter the value of \'n\': ");
        bool errorCatch = int.TryParse(Console.ReadLine(), out int n);
        Console.Write("\nPlease enter the value of \'k\': ");
        errorCatch = int.TryParse(Console.ReadLine(), out k);
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

    static int ewo = 1;//Easy way out <3

    static void NestedLoops(int count)
    {
       
        if (count == k)
        {
            PrintLoops();
            return;
        }

        for (int i = ewo; i <= vals.Length; i++)
        {
            vals[count] = i;
            NestedLoops(count + 1);
        }
        ewo++;
    }

    static void PrintLoops()
    {
        for (int i = 0; i < k; i++)
        {
            Console.Write(vals[i] + " ");
        }
        Console.WriteLine("\n");
    }
}