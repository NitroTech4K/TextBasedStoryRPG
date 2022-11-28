using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedStoryRPG
{
    internal class Program
    {
        static string[] Pages =
            {
            "The dog is cute today and all days; pet dog; kick dog;2;3; you pet the dog but find The Cat, its Better then Dog; pet cat; don't kick cat you monster;4;5",
            "He's happy.; Give treat; Walk away;"
            };
        
       
        static int choices = 0;
        
        static void Main(string[] args)
        {
            while (true)
            {
            SplitStory();
            
            inputManager();
   
            Console.Clear();
            }
        }

        static void SplitStory()
        {

            string[] pagesElements = Pages[choices].Split(';');

            Console.WriteLine(pagesElements[0]);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(pagesElements[1]);
            Console.WriteLine(pagesElements[2]);
        }

        static void inputManager()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.D1)
            {
                choices = 1;
            }
        }
    }
}
