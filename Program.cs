using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedStoryRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string words = "The dog is cute today and all days; pet dog; kick dog;2;3; you pet the dog but find The Cat, its Better then Dog; pet cat; don't kick cat you monster;4;5";


            string[] pages = words.Split(';');

            Console.WriteLine(pages[3]);


            Console.ReadKey(true);
        }
    }
}
