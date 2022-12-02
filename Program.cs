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
            "You slowly awake...your vision blurry and hearing all muffled. You wake up on a cold, damp, stone floor.;Coming to realization...you're in a cave...alone.....;Slowly you get up, rubbing your eyes to clear your vision from your deep sleep...; ; ;Looking around the area, you can see 2 pathways.; ;The left path, showing a bright, glowing source of light. Passing through the clear crystals that have clearly been on the cavern walls for centuries. The light also emits a shimmering pattern on the ceiling…like…water, reflecting off the surface.; ;The other on the right, showing a dark, pitch-black path. But has the sound of a soothing, gentle voice. Humming a song, similar to a lullaby. You’ve never heard it before, but…it feels oddly familiar…strange…; ; ; ;Which path do you choose?...; ; ;!REMEMBER!...Every choice has its benefits, and consequences...Choose wisely...;1. Follow the lit pathway on the left.;2. Follow the dark pathway on the right.; 1; 2", //page 0
            "You chose to follow the blue lit pathway. Admiring all the beautiful crystals that surround you. They’re extremely sharp, so it’s not really a good idea to touch them.; ;As you continue to follow the light, you notice something. The crystals are reflecting the rays of light from the water ripples, but you don’t know where the water even is.; ;The rays feel warm and soothing on your skin, calming to see them dance on the cave walls and on your body. You keep walking forward and start to hear some water droplets falling in the distance. It sounds like the water’s far away from where you are now, but the crystals seem to be oddly projecting the light. ; ;As you continue your way through the cave, your temptation to take a crystal for yourself grows intensely, completely disregarding the pain it might cause you. It’s so sharp, but you can feel a sort of...heat...radiating from the crystals...; ; ;What do you do? ; ;1. Leave it...it’s probably dangerous...;2. Take one. It’ll look so nice in a necklace or ring.; 3; 4", //page 1
            "You choose the dark and eerie path.; ;You can’t see a thing...it’s completely pitch black...the only thing you can sense is the smell of damp, rotting moss, probably forming on the cave walls. It smells fowl...you cover your mouth with your shirt just to be safe.; ;Since you can’t see, your only way to move around...is by sound...; ;You stomp your foot on the ground a few times to see if you can let sound waves do their work. To get a sense of where you are. But after you do that...you hear a wheezing sound...like a dry throated soul...begging for water...or in this case...blood...; ;You can feel a warmth making you shiver from behind you. The sound is surrounding you slowly. Left, right and everywhere in between. You turn around and see two red glowing eyes...you’re trapped.; ;You then realize you have a flashlight in your bag. You quickly pull it out, faced with two options.; ; ; ;What do you do?;1. Throw it at the figure. Scare it off.;2. Turn it on, to see what you're up against.;5; 6", //page 2
            "You follow your gut instincts and leave the crystals in their natural habitat. Not touching any.; ;Eventually, you end up in a massive open cavern at the end of the path. The ground and the roof of it must be at least 20 stories tall. It’s lined with crystals, much bigger and purer than the ones in the path. The ones from the ceiling are the biggest in the cavern. Glowing the brightest.; ;Strangely, there’s a natural spring of water being emitted from the crystals in the ceiling. Like an upside-down fountain. The water falls down and into a huge natural pool. The bottom lined with other crystals, probably made from the same water. The crystals on the bottom of the pool are glowing gently, making a perfect atmosphere for relaxation. You decide to head down, and gently step into the warm, crystal clean water. The bottom of the lake feels nice and smooth. You were initially worried that it would be rough and spiky, but were proven wrong.; ;Once you’re in the pool, you feel a soothing wave of energy wash over you. Like a massage for the soul. But something starts to reveal itself in your head…the more you relax in the pool, the more your thoughts are cleared…you start to remember everything that happened…and how you got here. And soon...the way out of the cave is slowly revealed inside your mind. All your fears melt away, and soon you get out, and eventually find your way out of the cave and back into civilization.; ;But whenever you need a break from reality...that place is always there for you to go to, and rejuvenate yourself.; ; ;Good ending.;end",  //page 3
            "You chose to try and take a crystal for yourself. Your greed gets the best of you...; ;When you first touch it, it feels warm to the touch...and some weird energy...flows through your body...but then, you finally break it off of the wall.; ;However, a weird reaction started to occur...the crystal was getting hotter and hotter...too hot to the touch, glowing immensely bright, blinding even.; ; ;Suddenly, you could feel the crystal becoming more and more spiky in your hands. It was looking for a source of energy to feed on…more crystals started to emerge rapidly from the original one, wrapping around your hand. Crystallizing on and around your body. Trapping you in its grasp.; ;It only got worse...you tried to run, but you were slowly being encased in solid transparent rock. You scream for help, but alas, to no avail. You’re the only one...;Just before your head is enshrouded by the crystals...you hear the same humming you did before...and slowly...your entire body, becomes nothing but a crystalized statue...destined to rest in peace inside the path for eternity...eventually to be devoured into the walls themselves...; ;waiting for their next prey...; ; ;Crystalized Ending.;end", //Page 4
            "You throw the flashlight at the eyes...mistakes are made...; ;The figure screams and the eyes come dashing towards you. The figure tackles you to the ground.; ;The flashlight is knocked out of your hands. You have one last chance to get out alive!; ; ;What do you do?!;1. Push and fight back;2. Squirm out of it's grasp and run;7;8", //Page 5
            "You chose to shine the light at the figure; ; ;You hear the beast shriek an ear-piercing scream. The figure turns out to be a decaying corps of a woman. She covers her face in pain.; ;“AAAAUUUUGHHH!!!...IT HURTS!!!...IT BURRRRNS!!!...MAKE IT STOP!!!”; ; ;The girl drops to her knees, clutching her face with agony and pain. Smoke coming from her body started to fill the air. She’s down, now’s your chance!; ;What do you do?!;1. Run away as fast as you can.;2. Attempt to kill her anything you have.;9;10",//Page 6
            "You choose to push and fight back; ;The figure was way too fast and aware of everything you were going to try to defend yourself.; ;The figure pinned your arms down above your head, and you all of a sudden feel an incredibly sharp pain in your chest...; ;Your vision goes blurry, although it’s pitch black. You can see nothing but the glowing red eyes...; ;You hear the muffled sounds of fresh flesh being devoured. It gets quieter...and quieter...; ;You eventually fade away...your body to be nothing but food, and your soul forever trapped inside the cave...;Devoured Ending.;end",//Page 7
            "You choose to squirm and run away to try and get out.; ; ;It’s a struggle, but eventually you get the chance to get up and run; ;But you can also hear the screams of the figure running towards you...and fast...; ;While running, you hear a soft humming voice...like it’s guiding you somewhere.; ;You instinctively follow it, and eventually you find your way out of the cave!; ;Authorities are waiting outside the cave, looking for you and any other survivors.; ;Now you can relax...you’re alive and healthy...and back in society...; ; ;Struggled Escape Ending;end",//Page 8
            "You decide to take your chances and run for it.; ; ;As you’re running down the path, you can also hear the screams of the figure running towards you...and fast...; ;While running, you hear a soft humming voice...like it’s guiding you somewhere.; ;You instinctively follow it, and eventually you find your way out of the cave!; ;Authorities are waiting outside the cave, looking for you and any other survivors.; ;Now you can relax...you’re alive and healthy...and back in society...; ; ;Struggled Escape Ending;end",//Page 9
            "You choose to use your time to attempt to end her.; ; ; ;You see a sharp rock on the ground next to you...perfect! It’s do or die!; ;You approach her, and stab her right in the heart. She screams as she’s impaled by the rock. But some weird substance starts to flow out...it’s not blood...but black mold...; ;You approach her, and stab her right in the heart. She screams as she’s impaled by the rock. But some weird substance starts to flow out...it’s not blood...but black mold...; ;The mold rapidly crawled up your arm...the mold multiplies rapidly, until your whole body’s taken over. Eventually, your body decomposes into a pile of rotten fleshy mass...right beside the girl...; ;You may have died...but your sacrifice made sure that no one will ever be killed by her hands ever again...; ; ;Rest in peace...; ; ; ;Sacrificed Ending.;end"//Page 10
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
