using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Number_Guesser
{
    class Program
    {
        static void PlayGame(string x) {
            Random rnd=new Random();
            int randomNum=rnd.Next(1,10);
            
            bool correct=false;

            while(correct==false){
            int guess = Convert.ToInt32(x);
            if(randomNum==guess){
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("YAY,you guessed correctly well done!!!!");
            correct=true;
            Console.ResetColor();
            }else{
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Wrong,Guess Again!");
                Console.ResetColor();
                x=Console.ReadLine();
               
            }
        }
        }  
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

            Console.WriteLine("Hello {0} ,Welcome to THE NUMBER GUESSING GAME!" ,userName);
            bool continueGame=true;
           do{
            Console.WriteLine("Do you want to play?(Y/N)");
            string wP = Console.ReadLine();
            string wannaPlay =wP.ToUpper();

            if(wannaPlay=="Y"){
                
                    Console.WriteLine("Guess A Number!");
                    string guess = Console.ReadLine();
                    PlayGame(guess);
                
            }else if(wannaPlay=="N"){
                Console.WriteLine("Thank you for playing!");
                continueGame=false;
            }
           }while(continueGame ==true);

            //Keeps Console Open while testing
            Console.ReadKey();


        }
    }
}