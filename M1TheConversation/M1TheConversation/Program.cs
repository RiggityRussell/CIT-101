using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1TheConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            // *******************************
            // Apllication      M1 Assignment
            // Author:          Russell Arlt
            // Description:     An application that has a conversation with the user 
            //                  about board games.
            // Date Created:    1/17/21
            // Date Revised:    
            // ******************************
            //
            //  variables
            //
            string userName;
            string favoriteBoardGame;
            string typeOfBoardGame;
            string createBoardGame;
            string userResponse;

            int averageHoursPerWeek;
            int averageDaysPerYear;
            int yearsPlayingBoardGames;
            int amountOfTimeWeCouldUse;
            //
            //  *********************
            //  *   Opening Screen  *
            //  *********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkGreen ;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //
            // display an opening screen
            //
            Console.WriteLine();
            Console.WriteLine("\t\tThe Board Game Conversation");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
            //
            //  ****************
            //  * Intro Screen *
            //  ****************
            //
            // make sure to set cursor to invisible, change all ground colors and clear screen.
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //
            // display header
            //
            Console.WriteLine();
            Console.WriteLine("\t\tIntroduction");
            Console.WriteLine();
            //
            // enter convo with user
            //
            Console.WriteLine("Hello new friend!");
            Console.WriteLine();
            Console.WriteLine("My name is Russell.");                                    
            //
            // get the name of the user from string userName and echo it back to them.
            //
            Console.WriteLine();
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("It is very nice to meet you " + userName + ". ");
            //
            // username is being echoed in line above
            //
            // ask if they like board games
            // yes will prompt more questions
            // no will guide them to exit application
            //
            Console.WriteLine();
            Console.Write($"Do you like to play Board Games {userName}? ");
            userResponse = Console.ReadLine();
            //
            // pause the app for the board game lover/hater
            //
            Console.WriteLine();
            Console.WriteLine("\tYou look like you need a break. Press any key to continue when your break is over.");
            Console.ReadKey();
            //
            // ger more info if the user is a board game player
            //
            if (userResponse == "yes")
            {
                //
                //  *********************************
                //  *   Favorite Board Game Screen  *
                //  *********************************
                //
                // set cursor invisible, change ground colors, clear screen.
                //
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //
                // display header
                //
                Console.WriteLine();
                Console.WriteLine("\t\tFavorite Board Game");
                Console.WriteLine();
                //
                // get users favorite board game
                //
                Console.WriteLine();
                Console.Write($"It' nice to know we have this in common {userName}! ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("What is your favorite Board Game? ");
                favoriteBoardGame = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("So, {0}, {1} is your favorite Board Game? Mine is Terraforming Mars.", userName, favoriteBoardGame);
                //
                // get the users favorite type of board game
                //
                Console.WriteLine();
                Console.Write("I am interested in your favorite type of Board Game! ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Do you like \"resource management\", \"cooperative\", or \"competitive\"? ");
                typeOfBoardGame = Console.ReadLine();
                //
                // ask if the user would like to create a board game
                //
                Console.WriteLine();
                if (typeOfBoardGame == "resource management")
                {
                    Console.WriteLine("I also love resource managment games! ");
                    Console.WriteLine();
                    Console.WriteLine($"I think {favoriteBoardGame} is very good as well. ");
                }
                else if (typeOfBoardGame == "cooperative")
                {
                    Console.WriteLine("Cooperative games are becoming my favorite games to play recently! ");
                    Console.WriteLine();
                    Console.WriteLine($"Ok {userName}, I think we should play a cooperative game together! ");
                }
                else if (typeOfBoardGame == "competitive")
                {
                    Console.WriteLine("I used to play a lot of competitive games, but sometimes they stress me out too much! ");
                    Console.WriteLine();
                    Console.WriteLine("That being said, Terraforming Mars is very competitive and its my favorite game.");
                    Console.WriteLine();
                    Console.WriteLine($"Well {userName}, if you haven't played Terraforming Mars I can teach you how to play!");
                }
                //
                //
                // ask the user what kind of a game they would like to create if they could
                //
                Console.WriteLine();
                Console.Write($"If you had the time to create a boardgame what would you call it?");
                createBoardGame = Console.ReadLine();
                // pause the app again
                //
                Console.WriteLine();
                Console.WriteLine("\tYou look exhausted by our conversation. Take a quick break and press any key to continue.");
                Console.ReadKey();
                //
                //  *********************************
                //  *   Creating Board Game Screen  *
                //  *********************************
                //
                // set cursor to invisible, ground colors, and clear screen
                //
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                //
                // display header
                //
                Console.WriteLine();
                Console.WriteLine("\t\tLets make a game together!");
                Console.WriteLine();
                //
                // query the user for information
                //
                Console.WriteLine("I think we should create a board game!");
                Console.WriteLine();
                //
                Console.Write("How many years have you been playing board games?");
                userResponse = Console.ReadLine();
                yearsPlayingBoardGames = int.Parse(userResponse);
                Console.WriteLine();
                //
                Console.Write("How many hours a week do you play board games?");
                userResponse = Console.ReadLine();
                averageHoursPerWeek = int.Parse(userResponse);
                Console.WriteLine();
                //
                Console.Write("How many days a year do you play board games?");
                userResponse = Console.ReadLine();
                averageDaysPerYear = int.Parse(userResponse);
                Console.WriteLine();
                //
                amountOfTimeWeCouldUse = yearsPlayingBoardGames * averageHoursPerWeek * averageDaysPerYear;
                //
                Console.WriteLine($"Well {userName}, it looks like you have played {amountOfTimeWeCouldUse} hours of board games");
                Console.WriteLine($"I think if we use some of the time that we both play board games, we could come up with a concept for {createBoardGame}!");
                Console.WriteLine();
                //
                // thank the user and say good bye
                //
                Console.WriteLine();
                Console.WriteLine($"{userName}, I look forward to creating a board game with you someday!");
                Console.WriteLine("Thank you! I hope you have a great day!");
                //
                // pause the app for the user
                //
                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }
            //
            // thank the user if they're not a board game player
            //
            else 
            {
                //
                //  *************************
                //  *   Thank User Screen   *
                //  *************************
                //
                // set cursor invisible, ground colors, clear screen
                //
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"I am sorry you don't like board games {userName}. It has been nice talking to you anyways. Have a great day!");
                //
                // pause the app
                //
                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }
            //
            //  *********************
            //  *   Closing Screen  *
            //  *********************
            //
            // set cursor invisible, ground colors, clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //
            // display the closing screen information
            //
            Console.WriteLine();
            Console.WriteLine("\t\tA special thank you to Jason Holtrey and Tyler Hsu for always helping me in any situation ever making my life so much better than it would be otherwise!");
            Console.WriteLine();
            Console.WriteLine("RUSSELL MADE THIS!");
            Console.WriteLine();
            //
            // pause the app for the user
            //
            Console.WriteLine();
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
        }
    }
}
