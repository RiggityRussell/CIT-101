using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpertSystem_WIP
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // **********************************************************************
            // *Title:              The Expert System                               *    
            // *Application Type:   Console                                         *
            // *Author:             Arlt, Russell                                   *
            // *Description:        An application that has a conversation with the *
            // *                    user about how old they are in varying times.   *
            // *Date Created:       1/24/2021                                       *
            // *Date Revised:       Constantly                                      *
            // **********************************************************************
            //Time a Person has Been Alive
            //User input: birthdate
            //App output: seconds, minutes, hours, days, weeks, and months alive
            //
            //Develop the application with the following requirements
            //Opening Screen – include a description of the application---DONE
            //Instructions Screen---DONE
            //User Input Screen – echo the user input---DONE
            //Results Screen---DONE
            //Closing Screen---DONNNEEEEEE
            //
            // screen configurations
            // set screen colors for the theme- Simple black white theme.
            // 
            ConsoleColor openingClosingScreenBackground = ConsoleColor.Black;
            ConsoleColor openingClosingScreenForeground = ConsoleColor.White;
            ConsoleColor appScreenBackground = ConsoleColor.Black;
            ConsoleColor appScreenForeground = ConsoleColor.White;
            //
            // Variables
            //
            string userName;
            string userResponse;
            string bornYear;
            string bornMonth;
            string bornDay;
            // I just learned how to have the date and time show up so its on every screen.
            DateTime myValue = DateTime.Now;
            double userSec;
            double userMin;
            double userHour;
            double userDay;
            double userWeek;
            double userMonth;
            double userYear;
            bool userHadFun = true;
            //
            // **********************
            // *   Opening Screen   *
            // **********************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();
            //
            // display opening screen
            // 
            Console.WriteLine(myValue.ToString());
            Console.WriteLine();
            Console.WriteLine("\t\t\tHow long have you been alive?\n");
            Console.WriteLine("\tPress any key to find out!");
            Console.ReadKey();
            //
            // ***************************
            // *   Initial User Screen   *
            // ***************************
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //
            Console.CursorVisible = true;
            Console.BackgroundColor = appScreenBackground;
            Console.ForegroundColor = appScreenForeground;
            Console.Clear();
            //
            // greet the user
            // begin application
            //
            Console.WriteLine(myValue.ToString());
            Console.WriteLine("\nHello!\n");
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine($"\nIt is nice to meet you {userName}.\n");
            Console.WriteLine($"Well {userName} this application will tell you exactly how long you have been alive.\n");
            Console.Write($"I assume you want to find out how long you've been alive {userName}? ");
            userResponse = Console.ReadLine();
            //
            // Get users response to wanting to know their age. If they do continue here, if not, go to else.
            // Allow user to respond with multiple choices of yes.
            //
            if (userResponse == "yes" || userResponse == "Yes" || userResponse == "y" || userResponse == "yeah" || userResponse == "ye" || userResponse == "for sure" || userResponse == "YEAH")
            {
                //
                // *******************************
                // *   User Input Screen   *
                // *******************************
                //
                // set cursor visible and clear screen
                //
                Console.CursorVisible = true;
                Console.Clear();
                Console.WriteLine(myValue.ToString());
                Console.WriteLine("\n\t\t\tThe Age Equation\n");
                Console.WriteLine("I need to get some information from you before we go further!\n");
                Console.WriteLine("What year were you born?\n");
                bornYear = Console.ReadLine();
                Console.WriteLine("\nWhat month were you born?\n");
                bornMonth = Console.ReadLine();
                Console.WriteLine("\nWhat day were you born?\n");
                bornDay = Console.ReadLine();
                // Take the year, Month, and day and display it coherently
                DateTime userBirthday = DateTime.Parse($"{bornMonth},{bornDay},{bornYear}");
                Console.WriteLine($"\nSo you were born on {userBirthday.ToShortDateString()}.");
                Console.ReadLine();
                Console.WriteLine($"\nWell {userName} let's go to the next page!\n");
                Console.WriteLine("\tPress any key to continue.");
                Console.ReadKey();
                // **************************
                // *    Results Screen 1    *
                // **************************
                //This page will display all relevant age data, seconds, minutes, hours, days, weeks, and months alive
                // DateTime userBirthday = DateTime.Parse($"{bornMonth},{bornDay},{bornYear}");
                // Console.WriteLine(userBirthday.ToShortDateString());
                // Console.ReadLine();
                Console.CursorVisible = true;
                Console.BackgroundColor = appScreenBackground;
                Console.ForegroundColor = appScreenForeground;
                Console.Clear();
                Console.WriteLine(myValue.ToString());
                Console.WriteLine($"\nFrom here we will show you eactly how long you've been alive {userName}. Press any key you want! No wrong answers!\n");
                Console.ReadLine();
                //seconds, minutes, hours, days, weeks, and months alive
                //display a table of values, formatted with columns, column headers, and column totals.
                //Validate user input of an integer or double and store the value in a local variable.
                // Use a nested decision block dependent on two user responses to prompts.
                TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
                Console.WriteLine("You have been alive...");
                userSec = userAge.TotalSeconds;
                Console.WriteLine(userSec); Console.WriteLine("Seconds!");
                Console.ReadLine();
                userMin = userAge.TotalMinutes;
                Console.WriteLine(userMin); Console.WriteLine("Minutes!");
                Console.ReadLine();
                userHour = userAge.TotalHours;
                Console.WriteLine(userHour); Console.WriteLine("Hours!");
                Console.ReadLine();
                userDay = userAge.TotalDays;
                Console.WriteLine(userDay); Console.WriteLine("Days!");
                Console.ReadLine();
                userWeek = userAge.TotalDays / 7;
                Console.WriteLine(userWeek); Console.WriteLine("Weeks!");
                Console.ReadLine();
                userMonth = userAge.TotalDays / 30;
                Console.WriteLine(userMonth); Console.WriteLine("Months!");
                Console.ReadLine();
                userYear = userAge.TotalDays / 365.242199;
                Console.WriteLine(userYear); Console.WriteLine("Years!");
                int age = (int)((DateTime.Now - userBirthday).TotalDays / 365.242199);
                Console.ReadLine();
                Console.WriteLine($"{userName}! I bet you want to see that in a nice neat table!");
                Console.WriteLine("\tPress any key to get to the table of your dreams.");
                Console.Read();
                Console.Clear();
                // ******************************
                // *    Results Array Screen    *
                // *    Results Screen 2        *
                // ******************************
                //declaration
                double[] ageVar;
                //assignment, anytime using = is THE assignment operator. 
                ageVar = new double[7];
                //assigning these to the slots
                ageVar[0] = userSec;
                ageVar[1] = userMin;
                ageVar[2] = userHour;
                ageVar[3] = userDay;
                ageVar[4] = userWeek;
                ageVar[5] = userMonth;
                ageVar[6] = userYear;

                string[] labelNum;
                labelNum = new string[7];

                labelNum[0] = "Seconds";
                labelNum[1] = "Minutes";
                labelNum[2] = "Hours";
                labelNum[3] = "Days";
                labelNum[4] = "Weeks";
                labelNum[5] = "Months";
                labelNum[6] = "Years";

                Console.CursorVisible = true;
                Console.BackgroundColor = appScreenBackground;
                Console.ForegroundColor = appScreenForeground;
                Console.WriteLine(myValue.ToString());
                Console.WriteLine("\n\t\tTHE TABLE OF AGE!\n");
                Console.WriteLine("How long you've been alive in.......\n");
                // three parts in parentheses 
                // 1st part initialization of variable N, happens once at loop
                // 2nd part "continuation condition," will loop for as long as n is less than 7
                // 3rd will happen after each iteration of the loop. N becomes incremented by one every time loop repeats.
                for (int N = 0; N < 7; N++)
                {
                    Console.WriteLine(labelNum[N] + "\t" + ageVar[N]);                    
                }
                Console.WriteLine("\n\nWow! What a table! Well it looks like our time is drawing to a close.");
                Console.WriteLine("\tPlease Press any key to continue!");
                Console.ReadLine();
                Console.Read();
                Console.Clear();
                // For some reason the Console.Read above this will crash the whole code if removed.
                // The Writeline below is added also for the same reason.
                // After hours of troubleshooting this is the best I could come up with. It works so I'm good with it.
                Console.WriteLine();
                Console.Read();
                Console.Clear();
                // ********************************
                // *    User Feedback Screen      *
                // ********************************
                Console.CursorVisible = true;
                Console.BackgroundColor = appScreenBackground;
                Console.ForegroundColor = appScreenForeground;
                Console.WriteLine(myValue.ToString());
                Console.WriteLine();
                Console.WriteLine($"Did you have fun {userName}? Enter a number between 1 and 10, with 10 being the highest, telling me how much fun you had!");
                while (userHadFun)
                {
                    int userHadFun1 = int.Parse(Console.ReadLine());
                    if (userHadFun1 == 10)
                    {
                        userHadFun = false;
                    }
                    else
                    {
                        Console.WriteLine("Well I think you had more fun than that! Try again!");
                    }
                }
                // ***********************
                // *     Final Screen    *
                // ***********************
                Console.CursorVisible = false;
                Console.BackgroundColor = openingClosingScreenBackground;
                Console.ForegroundColor = openingClosingScreenForeground;
                Console.Clear();
                Console.WriteLine(myValue.ToString());
                Console.WriteLine("\n\t\tThe Final Screen\n");
                Console.WriteLine($"Well {userName} we laughed, we cried, but all great things must come to a close.\n");
                Console.WriteLine("Thanks for using the age equation and have a great day!\n");
                Console.WriteLine("\t\tPress any key to end the program");
                Console.ReadLine();
            }
            else
            {
                //
                // **********************************
                // *   User Not Interested Screen   *
                // **********************************           
                Console.CursorVisible = true;
                Console.Clear();
                Console.WriteLine(myValue.ToString());
                Console.WriteLine($"\nI am sorry you don't want to know your age, {userName}");
                Console.WriteLine("\nI will cherish our time together!\n");
                Console.WriteLine("Have a nice day.");
                Console.WriteLine("\nPress any key to continue.\n");
                Console.Read();
            }
        }
    }
}
