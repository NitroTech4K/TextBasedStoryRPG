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
            "You slowly awake...your vision blurry and hearing all muffled. You wake up on a cold, damp, stone floor.;Coming to realization...you're in a cave...alone.....;Slowly you get up, rubbing your eyes to clear your vision from your deep sleep...; ; ;Looking around the area, you can see 2 pathways.; ;The left path, showing a bright, glowing source of light. Passing through the clear crystals that have clearly been on the cavern walls for centuries. The light also emits a shimmering pattern on the ceiling…like…water, reflecting off the surface.; ;The other on the right, showing a dark, pitch-black path. But has the sound of a soothing, gentle voice. Humming a song, similar to a lullaby. You’ve never heard it before, but…it feels oddly familiar…strange…; ; ; ;Which path do you choose?...; ; ;!REMEMBER!...every choice has its benefits, and consequences…choose wisely…;Follow the lit pathway on the left.;Follow the dark pathway on the right.; 1; 2", //page 0
            "you pet the dog but find The Cat, its Better then Dog; pet cat; kick cat; 3; 4", //page 1
            "You kicked the dog, it whimpers and runs away. You're alone.;end",  //page 2
            "You pet the cat, the dog whimpers and runs away. You abandoned him.;end",//Page 3
            "You kick the cat. It hisses and runs off. You're with the dog now.;end", //Page 4
            };
        
       
        static int choices = 0; //The choice of the page (To be changed to 1 so a title screen can be added.)

        static string[] pagesElements;
        
        static bool play;

        static void Main(string[] args) //Main Program
        {
            Console.WriteLine("Quest Of Elsyum");

            Console.ReadKey(true);
            Console.Clear();

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

            if (pagesElements[pagesElements.Length - 1].Contains("end")) //If there's no splits
            {
                    
                play = false;
                                              //i++ = (i = i + 1)
                for (int i = 0; i < pagesElements.Length - 1; i++)  //Print out the ending page for that branch of text. 
                {
                    Console.WriteLine(pagesElements[i]);
                }
            }
            
            else
            {
                for (int i = 0; i < pagesElements.Length - 4; i++) // continue to count until max amount of splits, minus 4, to not show the choices and next pages.
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

            }



        }


        static void inputManager() //manages the input from the user, only for the options provided.
        {
            ConsoleKeyInfo input = Console.ReadKey(true);
            if (pagesElements[pagesElements.Length - 1].Contains("end"))
            {



                
            }

            else
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
