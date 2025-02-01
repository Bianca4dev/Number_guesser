using System;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName ="Number Guessing Game!";
            string appVersion ="2.0";
            string appAuthor = "Me :)";

            //COLOUR
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("{0} Version {1} by {2}",appName,appVersion,appAuthor);
            Console.ResetColor();

            Console.WriteLine("Your Name: ");
            string userName = Console.ReadLine();
            

            //Maybe use a dowhile?

            Console.WriteLine("Hello {0} ,Welcome to THE NUMBER GUESSING GAME! \nDo you want to Play?(Y/N)" ,userName);
            string wannaPlay = Console.ReadLine();

            if(wannaPlay == "Y"){
                //play the game
            }else if(wannaPlay=="N"){
                //exit
            }else{
                //wrong input
            }


            //Keeps Console Open while testing
            Console.ReadKey();


        }
    }
}