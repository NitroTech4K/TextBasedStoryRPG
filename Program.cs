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
            {                          //1 means go to page 1, 2 means go to page 2
            "The dog is cute today and all days; pet dog; kick dog; 1; 2", //page 0
            "you pet the dog but find The Cat, its Better then Dog; pet cat; kick cat; 3; 4", //page 1
            "You kicked the dog, it whimpers and runs away. You're alone.;end",  //page 2
            "You pet the cat, the dog whimpers and runs away. You abandoned him.",//Page 3
            "You kick the cat. It hisses and runs off. You're with the dog now.", //Page 4
            };
        
       
        static int choices = 0; //The choice of the page (To be changed to 1 so a title screen can be added.)

        static string[] pagesElements;
        
        static bool play;

        static void Main(string[] args) //Main Program
        {
            play = true;

            while (play == true) //Loop to repeat the following actions infinately
            {
            SplitStory();
            
            inputManager();
   
            Console.Clear(); //Resets the screen so after the player makes a choice, the next page is the only one on the screen.
            }
        }

        static void SplitStory() //Splits the story string up, separated by ;. Also a display methoud of options.
        {
            pagesElements = Pages[choices].Split(';');


            if (pagesElements) //If there's no splits
            {
                Console.WriteLine("r");
            }

            else
            {
                for (int i = 0; i < pagesElements.Length - 4; i = i + 1) // continue to count until max amount of splits, minus 4, to not show the choices and next pages.
                {
                    Console.WriteLine(pagesElements[i]); //First part of the story string of text
                } 


                if (pagesElements.Length > 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(pagesElements[pagesElements.Length - 4]); //Option 1
                    Console.WriteLine(pagesElements[pagesElements.Length - 3]); //Option 2
                }
                else 
                {
                    play = false;
                }

            }



        }


        static void inputManager() //manages the input from the user, only for the options provided.
        {
            ConsoleKeyInfo input = Console.ReadKey(true);
            if (pagesElements.Length > 1)
            {
                if (input.Key == ConsoleKey.D1)  //If the player presses the 1 key on the keyboard
                {
                    choices =  int.Parse(pagesElements[pagesElements.Length - 2]); //choice will go to the page for the first option.
                }

                if (input.Key == ConsoleKey.D2)  //If the player presses the 2 key on the keyboard
                {
                    choices = int.Parse(pagesElements[pagesElements.Length - 1]);  //choice will go to the page for the second option.
                }
            }
        }
    }
}
