using System;
					
public class MartiniGlass
{
	public static void Main()
	{
		MartiniGlass main = new MartiniGlass();
        main.Run();
	}
	
	/// <summary>
    /// Start the process.
    /// </summary>
    private void Run()
    {
        int height = 0;
		Console.Write("------------------------------------------------\n");
        Console.WriteLine("                  Martini Glass               ");
		Console.Write("------------------------------------------------\n\n");

        do
        {
			Console.Write("Note: Can't be less than 1 or no greater than 50\n\n");
            Console.Write("Give me a Height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("\n");  
        } 
        while ((height <= 0) || (height > 50));
         
		for(int i = height - 1; i >= 0; i--)
		{
			Console.WriteLine(new string('0', (2 * i) + 1).PadLeft(i+height));
		}
		
		Console.Write(new string('|', height).Replace("|","|\n".PadLeft(height+1)));
		Console.WriteLine(new string('=', (height * 2-1)));

    }
	
}


