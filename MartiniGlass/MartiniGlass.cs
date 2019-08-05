using System;


public class MartiniGlass
{
    public static void Main()
    {
        MartiniGlass main = new MartiniGlass();
        main.Run();
        Console.Read();
    }

    /// <summary>
    /// Start the process.
    /// </summary>
    private void Run()
    {
        int hash = 0;
        int height = 0;
        Console.WriteLine("Can't be less than 1 or no greater than 50\n\n");

        do
        {
            Console.Write("Give me a Height: ");
            height = int.Parse(Console.ReadLine());
            hash = height * 2;
            Console.Write("\n");
        }

        while ((height <= 0) || (height > 50));
        DoMartiniGlass(height, hash);

    }

    /// <summary>
    /// Recursive method for Create the Martini Glass.
    /// </summary>
    /// <param name="height"></param>
    /// <param name="hash"></param>
    /// <param name="index"></param>
    private void DoMartiniGlass(int height, int hash, int index = 0)
    {
        if (index < height)
        {
            DoChalice(index, hash);
            hash -= 2;
            Console.Write("\n");

            if (index == (height - 1))
            {
                DoStem(height);
                DoBase(height);
            }
            DoMartiniGlass(height, hash, (index + 1));
        }
    }

    /// <summary>
    /// Recursive method for create the Chalice Base.  
    /// </summary>
    /// <param name="a"></param>
    /// <param name="hash"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    private void DoChalice(int a, int hash, int b = 0, int c = 0)
    {
        if (b < a)
        {
            Console.Write(" ");
            DoChalice(a, hash, (b + 1), hash);
        }

        if (c < (hash - 1))
        {
            Console.Write("O");
            DoChalice(a, hash, a, (c + 1));
        }
    }

    /// <summary>
    /// Recursive method for create the Stem Base. 
    /// </summary>
    /// <param name="height"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    private void DoStem(int height, int a = 0, int b = 0)
    {
        if (a < height)
        {
            if (b < (height - 1))
            {
                Console.Write(" ");
                DoStem(height, a, (b + 1));
            }
            else
            {
                Console.WriteLine("|");
                DoStem(height, (a + 1));
            }
        }

    }

    /// <summary>
    /// Recursive method for create the Glass Base.
    /// </summary>
    /// <param name="height"></param>
    /// <param name="index"></param>
    private void DoBase(int height, int index = 1)
    {
        if (index < (height * 2))
        {
            Console.Write("=");
            DoBase(height, (index + 1));
        }
    }
}


