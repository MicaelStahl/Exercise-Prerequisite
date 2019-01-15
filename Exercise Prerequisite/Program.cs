using System;

namespace Exercise_Prerequisite
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }
        private static void RunExerciseOne()
        {
            Console.ResetColor();
            Console.WriteLine("You successfully ran exercise one! Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("What's your first name?: ");
            string strFirstName = Console.ReadLine();

            Console.Write("Hello " + strFirstName + ", What's your second name?: ");
            string strSecondName = Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello " + strFirstName + " " + strSecondName + "! I'm glad to inform you that you are the test subject of my very first assignment!");
        }
        private static void RunExerciseTwo()
        {
            Console.WriteLine("You successfully ran exercise two! Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();

            DateTime Yesterday = YesterdaysDate(); //Gets Yesterdays date from Method "YesterdaysDate"
            Console.WriteLine("Yesterday: {0}", Yesterday);

            Console.WriteLine("Today: {0}", DateTime.Today.ToString("yy/MM/dd"));

            DateTime Tomorrow = TomorrowsDate();
            Console.WriteLine("Tomorrow: {0}", Tomorrow);


            //DateTime value = new DateTime();


            //int intDate = Convert.ToInt32(Console.ReadLine());

            //int intYesterdaysDate = intDate--;
            //int intTomorrowsDate = intDate++;
            
        }
        private static void RunExerciseThree()
        {
            Console.WriteLine("You successfully found the secret assignment!");
        }
        static DateTime TomorrowsDate()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime YesterdaysDate()
        {
            return DateTime.Today.AddDays(-1);
        }
    }
}
