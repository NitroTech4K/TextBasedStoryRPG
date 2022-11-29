using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedStoryRPG
{
    internal class Program
    {
        static string[] Pages = //Page is in brackets below
            {
            "The dog is cute today and all days; pet dog; kick dog;2;3; you pet the dog but find The Cat, its Better then Dog; pet cat; don't kick cat you monster;4;5",
            "He's happy.; Give treat; Walk away;"
            };
        
       
        static int choices = 0; //The choice of the page (To be changed to 1 so a title screen can be added.)
        
        static void Main(string[] args) //Main Program
        {
            while (true) //Loop to repeat the following actions infinately
            {
            SplitStory();
            
            inputManager();
   
            Console.Clear(); //Resets the screen so after the player makes a choice, the next page is the only one on the screen.
            }
        }

        static void SplitStory() //Splits the story string up, separated by ;. Also a display methoud of options.
        {

            string[] pagesElements = Pages[choices].Split(';');

            Console.WriteLine(pagesElements[0]); //First part of the story string of text
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(pagesElements[1]); //Option 1
            Console.WriteLine(pagesElements[2]); //Option 2
        }

        static void inputManager() //manages the input from the user, only for the options provided.
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.D1)  //If the player presses the 1 key on the keyboard
            {
                choices = 1;    //choice will go to page 1. (Needs work, hard coded.)
            }
        }
    }
}
