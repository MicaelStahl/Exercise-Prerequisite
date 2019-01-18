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

            double Area = PI * (Radius * Radius);
            double Volume = 4 * PI * Math.Pow(Radius, 3) / 3;

            Console.WriteLine("The Area of the circle is: {0:0.00} ", Area);
            Console.WriteLine("The Volume of the circle is: {0:0.00} ", Volume);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
