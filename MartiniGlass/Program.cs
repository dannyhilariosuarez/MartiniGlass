using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartiniGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.DoMartiniGlass();
            Console.Read();
        }

        private void DoMartiniGlass()
        {
            Console.WriteLine("Can't be less than 1 or no greater than 50\n\n");
            int hash = 0;
            int height = 0;

            do
            {
                Console.Write("Give me a Height: ");
                height = int.Parse(Console.ReadLine());
                hash = height * 2;
                Console.Write("\n");
            }
            while ((height <= 0) || (height > 50));

            for (int a = 0; a < height; a++)
            {
                DoChalice(a, hash);
                hash -= 2;
                Console.Write("\n"); 

                if (a == (height - 1))
                {
                    DoStem(height);
                    DoBase(height);
                }
            }
        }

        private void DoChalice(int a, int hash)
        {
            for (int b = 0; b < a; b++)
            {
                Console.Write(" ");
            } 
            for (int b = 0; b < (hash - 1); b++)
            {
                Console.Write("O");
            }
        }

        private void DoStem(int height)
        {
            for (int b = 0; b < height; b++)
            {
                for (int c = 0; c < (height - 1); c++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }

        private void DoBase(int height)
        {
            for (int b = 1; b < (height * 2); b++)
            {
                Console.Write("=");
            }
        }
    }
}
