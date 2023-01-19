using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasStringLights
{
    public static class PiscaPisca
    {
        public static void Run()
        {
            Console.Write("Escreva uma frase / palavra: ");
            string palavra = Console.ReadLine();
            Console.Clear();
            while(true)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(palavra[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(palavra[i]);
                    }
                }
                Thread.Sleep(1);
                Console.Clear();
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(palavra[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(palavra[i]);
                    }
                }
                Thread.Sleep(1);
                Console.Clear();
            }
        }
    }
}
