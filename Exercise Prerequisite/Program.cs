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
                            string FullName = RunExerciseThree();
                            Console.WriteLine(FullName);
                            break;
                        case 4:
                            string FullFox =  RunExerciseFour();
                            String str = "The quick fox Jumped Over the DOG";
                            Console.WriteLine(str + "\n" + FullFox);
                            break;
                        case 5:
                            string FullArray = RunExerciseFive();
                            Console.WriteLine(FullArray);
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
            Console.WriteLine("Yesterdays date was: {0}", Yesterday.ToString("yy/MM/dd")); //Only shows yy/mm/dd in Console and not the time.

            Console.WriteLine("Todays date is: {0}", DateTime.Today.ToString("yy/MM/dd"));

            DateTime Tomorrow = TomorrowsDate();    //Gets Tomorrows date from Method TomorrowsDate
            Console.WriteLine("Tomorrows date is: {0}", Tomorrow.ToString("yy/MM/dd"));
            
        }
        private static string RunExerciseThree()
        {
            Console.Clear();
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            string FullName = FirstName + " " + LastName;

            return FullName;
        }
        private static string RunExerciseFour()
        {
            Console.Clear();

            String BabyFox = "The quick fox Jumped Over the DOG";

            string FirstFox = BabyFox.Replace("quick", "brown");
            string SecondFox = FirstFox.ToLower();
            string ThirdFox = char.ToUpper(FirstFox[0]) + SecondFox.Substring(1);
            string FourthFox = ThirdFox.Insert(30, "lazy ");

            // change "The quick fox Jumped Over the DOG"
            // to get "The brown fox jumped over the lazy dog"

            string FullFox = FourthFox;
            return FullFox;
        }
        private static string RunExerciseFive()
        {
            Console.Clear();
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            Console.ReadLine();
            string FirstArray = str.Remove(68, 8); //Removes 4 characters starting from character 68
            //Arrays are very common in programming, they look something like: [1,2,3,4,5]
            //                                                                  68
            string SecondArray = FirstArray.Remove(71, 1); // :)
            string ThirdArray = SecondArray.Insert(72, ",4,5,6,7,8,9,10]"); //Continue testing
            string FullArray = ThirdArray;
            return FullArray;
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
