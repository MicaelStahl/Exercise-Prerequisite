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
                            string FullFox = RunExerciseFour();
                            String str = "The quick fox Jumped Over the DOG";
                            Console.WriteLine(str + "\n" + FullFox);
                            break;
                        case 5:
                            string fullNumbers = RunExerciseFive();
                            Console.WriteLine(fullNumbers);
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
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
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Hit any key to continue!");
                    Console.ResetColor();
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

        static DateTime TomorrowsDate()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime YesterdaysDate()
        {
            return DateTime.Today.AddDays(-1);
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
            Console.WriteLine("You successfully ran exercise five! Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();

            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            Console.ReadLine();

            int firstNumbers = str.IndexOf("[");
            string secondNumbers = str.Substring(firstNumbers);
            string thirdNumbers = secondNumbers.Remove(3, 4); //Removes 4 characters starting from character 4
            string fourthNumbers = thirdNumbers.Insert(6, ",6,7,8,9,10"); //inserts "5,6,7,8,9,10" from character 6. 

            string fullNumbers = fourthNumbers;
            return fullNumbers;
        }
        private static void RunExerciseSix()
        {
            Console.WriteLine("You successfully ran exercise six! Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please add the first number to the exercise: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now, Please add the second number to the exercise: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            if (numberA > numberB)
            {
                Console.Clear();

                int numberPDifference = numberA - numberB;
                int numberNDifference = numberB - numberA;

                int numberSum = numberA + numberB;

                int numberProduct = numberA * numberB;

                double numberRatio = numberA / (double)numberB;

                Console.WriteLine("Biggest: " + numberA);
                Console.WriteLine("Smallest: " + numberB);
                Console.WriteLine("Positive difference: " + numberPDifference);
                Console.WriteLine("Negative difference: " + numberNDifference);
                Console.WriteLine("Sum: " + numberSum);
                Console.WriteLine("Product: " + numberProduct);
                Console.WriteLine("Ratio: " + numberRatio);

                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                int numberPDifference = numberB - numberA;
                int numberNDifference = numberA - numberB;

                int numberSum = numberB + numberA;

                int numberProduct = numberB * numberA;

                double numberRatio = numberB / (double)numberA;

                Console.WriteLine("Biggest: " + numberB);
                Console.WriteLine("Smallest: " + numberA);
                Console.WriteLine("Positive difference: " + numberPDifference);
                Console.WriteLine("Negative difference: " + numberNDifference);
                Console.WriteLine("Sum: " + numberSum);
                Console.WriteLine("Product: " + numberProduct);
                Console.WriteLine("Ratio: " + numberRatio);

                Console.ReadKey();
            }
        }
        private static void RunExerciseSeven()
        {
            Console.ResetColor();
            Console.Write("Please input the radius value: ");
            double Radius = double.Parse(Console.ReadLine() ?? "");

            double PI = Math.PI;

            double sphereArea = 4 * PI * Math.Pow(Radius, 2);
            double sphereVolume = 4 * PI * Math.Pow(Radius, 3) / 3;

            double circleArea = PI * (Radius * Radius);

            Console.WriteLine("\nThe Area of the circle is: {0:0.00} ", circleArea);

            Console.WriteLine("\nThe Area of the sphere is: {0:0.00} ", sphereArea);
            Console.WriteLine("\nThe Volume of the sphere is: {0:0.00} ", sphereVolume);

            Console.ReadKey();
            Console.Clear();
        }
        private static void RunExerciseEight()
        {
            Console.Write("Please type a decimal number (x,xx): ");
            double decimalNumber = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("\nThat results in the following results: ");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nSquare root of " + decimalNumber + " is: " + Math.Sqrt(decimalNumber));

            Console.WriteLine("The power of 2 of " + decimalNumber + " is: " + Math.Pow(decimalNumber,2));

            Console.WriteLine("The power of 10 of " + decimalNumber + " is: " + Math.Pow(decimalNumber, 10));

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        private static void RunExerciseNine()
        {
            Console.ResetColor();
            Console.Write("\nHello dear Customer. What is your name? ");
            string fullName = (Console.ReadLine() ?? "");

            Console.Write("\nHello dearest " + fullName + ". What year were you born? ");
            double birthYear = double.Parse(Console.ReadLine() ?? "");

            double ageRestriction = DateTime.Now.Year - birthYear;

            if (ageRestriction >= 18)
            {
                Console.Write("\nThat means you're " + ageRestriction + "! \nWould you like a beer? y/n: ");
                string answerBeer = (Console.ReadLine() ?? "");
                if (answerBeer == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour order has been placed!");

                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                else
                {
                    Console.Write("\nWould you like a coke instead? y/n ");
                    string answerCoke = (Console.ReadLine() ?? "");

                    if (answerCoke == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nYour order has been placed!");

                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nNo other option is available :(");

                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.Write("\nWould you like to order a coke? y/n: ");
                string answerCoke = (Console.ReadLine() ?? "");

                if (answerCoke == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour order has been placed!");

                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo other option is available :(");

                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private static void RunExerciseTen()
        {
            Console.ResetColor();
            Console.WriteLine("Thank you for choosing option 10! Here's 3 options to pick between!");

            Console.Write("1: is a math program to count division! \n2: is exercise 4! \n3: is a colourful option!\nPick between 1-3: ");
            int Choice = int.Parse(Console.ReadLine() ?? "");

            switch (Choice)
            {
                case 1:
                    RunExerciseTenDivision();
                    break;

                case 2:
                    string FullFox = RunExerciseFour();
                    String str = "The quick fox Jumped Over the DOG";
                    Console.WriteLine(str + "\n" + FullFox);
                    break;

                case 3:
                    RunExerciseTenColour();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }
        private static void RunExerciseTenDivision()
        {
            Console.Clear();

            Console.Write("Hello! Please insert your first number: ");
            double divisionOne = double.Parse(Console.ReadLine() ?? "");

            Console.Write("\nPlease insert a number to divide " + divisionOne + " with: ");
            double divisionTwo = double.Parse(Console.ReadLine() ?? "");

            double divisionAnswer = divisionOne / divisionTwo;

            if (divisionTwo == 0 && divisionOne == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nError! Can't divide with 0!");

                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n" + divisionOne + " / " + divisionTwo + " = " + divisionAnswer);

                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            }
        }
        public static void RunExerciseTenColour()
        {
            

            Console.WriteLine("Welcome to exercise 10 option 3!");
            Console.ReadKey();

            if (Globals.globalColour == "Red")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This is now green!");

                Console.ResetColor();
                //Console.ReadKey();

                Globals.globalColour = "Green";
            }
            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is now red!");

                Console.ResetColor();
                //Console.ReadKey();

                Globals.globalColour = "Red";
            }
        }
        private static void RunExerciseEleven()
        {
            Console.Write("Please insert a number greater than 0: ");
            int numberCheck = int.Parse(Console.ReadLine() ?? "");

            if (numberCheck <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! You didn't pick a number great than 0");
                Console.ResetColor();
                
                Console.ReadKey();
                Console.Clear();
            }

            for (int goingUp = 0; goingUp <= numberCheck; goingUp++)
            {
                if (IsOdd(goingUp))
                {
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(goingUp);
                }
                else
                {
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(goingUp);
                }
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
            Console.ResetColor();

            for (int goingDown = numberCheck; goingDown >= 0; goingDown--)
            {
                if (IsOdd(goingDown))
                {
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(goingDown);
                }
                else
                {
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(goingDown);
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        private static void RunExerciseTwelve()
        {
            Console.WriteLine("Hello and welcome to exercise 12! press any key to see a multiplication table!");
            Console.ReadKey();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + "\t");
            //    for (int j = 2; j <= 10; j++)
            //    {
            //        if (i > 0) Console.Write(i * j + "\t");
            //        else Console.Write(j + "\t");
            //    }
            //    Console.Write("\n");
            //}

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");

                for (int j = 2; j <= 10; j++)
                {
                    if (i > 0)
                    {
                        Console.Write(i * j + "\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.Write("\n");
            }
        }
        private static void RunExerciseThirteen()
        {
            bool stayAlive = true;
            Random random = new Random();
            int randomNumber = random.Next(0, 500);
            int tries = 0;

            while (stayAlive)
            {
                Console.Write("Please enter a guess: ");
                int guess = int.Parse(Console.ReadLine() ?? "");

                if (guess > randomNumber)
                {
                    tries = tries + 1;
                    Console.WriteLine("Your guess was too big! Try again! You've guessed " + tries + " Times!");
                }
                else if (guess < randomNumber)
                {
                    tries = tries+ 1;
                    Console.WriteLine("Your guess was too small! Try again! You've guessed " + tries + " Times!");
                }
                else
                {
                    tries = tries+ 1;
                    Console.WriteLine("Congratulations, you guessed correctly! it was: " + guess + " You guessed " + tries + " Times!");
                    stayAlive = false;
                }
            }
        }

        public static class Globals
        {
            public static String globalColour = "Red";
        }
    }
}
