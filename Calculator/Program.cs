//using System;
//using System.Collections.Generic;

//namespace Calculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("NUMBER MULTIPLIER SECTION -------------------------------------------");

//            var stringNumbers1 = "1,2,3";
//            var stringNumbers2 = "2,4,5";

//            var numGroup1 = stringNumbers1.Split(",");
//            var numGroup2 = stringNumbers2.Split(",");

//            int numValue1 = 1;
//            int numValue2 = 1;
//            string numSquareValue1 = "";
//            string numSquareValue2 = "";

//            Console.WriteLine($"({stringNumbers1}), ({stringNumbers2})");
//            Console.WriteLine("Type 'multiply' to multiply each group of numbers together, or type 'square' to square each number in the two groups.");
//            var selection = Console.ReadLine();

//            if (selection == "multiply")
//            {
//                foreach (var num in numGroup1)
//                {
//                    int intNum = int.Parse(num);
//                    numValue1 = intNum * numValue1;
//                }

//                foreach (var num in numGroup2)
//                {
//                    int intNum = int.Parse(num);
//                    numValue2 = intNum * numValue2;
//                }

//                Console.WriteLine(numValue1);
//                Console.WriteLine(numValue2);
//            }
//            else if (selection == "square")
//            {
//                foreach (var num in numGroup1)
//                {
//                    int intNum = int.Parse(num);
//                    if (numSquareValue1.Length == 0)
//                    {
//                        numSquareValue1 = (intNum * intNum).ToString();
//                    }
//                    else
//                    {
//                        numSquareValue1 = $"{numSquareValue1}, {(intNum * intNum).ToString()}";
//                    }
//                }

//                foreach (var num in numGroup2)
//                {
//                    int intNum = int.Parse(num);
//                    if (numSquareValue2.Length == 0)
//                    {
//                        numSquareValue2 = (intNum * intNum).ToString();
//                    }
//                    else
//                    {
//                        numSquareValue2 = $"{numSquareValue2}, {(intNum * intNum).ToString()}";
//                    }
//                }

//                Console.WriteLine(numSquareValue1);
//                Console.WriteLine(numSquareValue2);
//            }
//        }
//    }
//}


//// oorrr

using System;

namespace Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string userOption = "";
            do
            {
                Console.WriteLine("Enter a list of integers like the following format: 1,4,6,8. Type exit to quit");
                userInput = Console.ReadLine();
                Console.WriteLine("Would you like to square or multiply this series?");
                userOption = Console.ReadLine();
                userOption = userOption.ToLower();
                string[] userNumbers = userInput.Split(",");
                int multiplytotal = 0;
                string squaredList = "";
                foreach (string item in userNumbers)
                {
                    if (userOption == "multiply")
                    {
                        multiplytotal += int.Parse(item);
                    }
                    else
                    {
                        squaredList += $"{int.Parse(item) * int.Parse(item)},";
                    }
                }
                if (userOption == "multiply")
                {
                    Console.WriteLine(multiplytotal);
                }
                else if (userOption == "square")
                {
                    Console.WriteLine(squaredList);
                }
                else
                {
                    Console.WriteLine("you didnt enter a valid answer");
                }

            }
            while (userInput != "exit");
        }
    }
}