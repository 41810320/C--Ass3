using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.

            //int Num;
            //Console.Write(" Enter Number ");
            //Num = int.Parse(Console.ReadLine());

            //Console.WriteLine(Num);

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string MyInput = "Ahmed2020";
            //int MyOutput = Convert.ToInt32(MyInput);

            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //double Num1 = 0.5;
            //double Num2 = 0.2;
            //double Sum = Num1 + Num2;
            //Console.Write("Sum = ");
            //Console.WriteLine(Sum);

            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.

            //string MyString = "Ahmed Khaled";
            //string MySupString = string.Substring(6);
            //Console.WriteLine(MySupString);

            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 1;
            //int y = 2;
            //x = y;

            //x = 3;
            //Console.Write("X = ");
            //Console.WriteLine(x);

            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //int[] Array1 = {1, 2, 3 };
            //int[] Array2 = Array1;
            //Array2[1] = 20;

            //Console.WriteLine($" Array1 = {Array1[1]} Array2 = {Array2[1]}");


            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            //string string1 = "Ahmed";
            //string string2 = "Khaled";

            //Console.WriteLine($"{string1} { string2}") ;

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //double principal = 500.0;
            //double rate = 4.5;
            //double time = 6.0;
            //double interest = (principal * rate * time) / 100;

            //Console.Write(" Interest = ");
            //Console.WriteLine(interest);


            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //double Weight = 73.0;
            //double Height = 1.7;
            //double BMI = (Weight) / (Height * Height);

            //Console.WriteLine($"BMI = {BMI}");

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"

            //double Temperature = 9.0;
            //string Massage = Temperature < 10 ? "Just Cold" : Temperature > 30 ? "Just Hot" : "Just Good";

            //Console.WriteLine(Massage);


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001

            //DateTime dateTime = DateTime.Now;
            //String format1 = $"{dateTime.Day},{dateTime.Month},{dateTime.Year}";
            //String format2 = $"{dateTime.Day}/{dateTime.Month}/{dateTime.Year}";
            //String format3 = $"{dateTime.Day}-{dateTime.Month}-{dateTime.Year}";

            //Console.WriteLine(format1);
            //Console.WriteLine(format2);
            //Console.WriteLine(format3);

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No

            //Console.Write("Enter a number ");
            //int number = int.Parse(Console.ReadLine());

            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive


            //Console.Write("Enter an integer ");
            //int number = 0;
            //Console.ReadLine();

            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            //Console.Write("Enter the first number ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the third number ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("The maximum number is: " + Math.Max(num1, Math.Max(num2, num3)));
            //Console.WriteLine("The minimum number is: " + Math.Min(num1, Math.Min(num2, num3)));




            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter Number ");
            //int number = int.Parse(Console.ReadLine());

            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Even Number ");
            //    }else
            //    {
            //        Console.WriteLine("Odd Number");
            //    }



            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant


            //Console.Write("Enter a character ");
            //char character = Console.ReadKey().KeyChar;

            //character = char.ToLower(character);

            //    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Consonant");
            //    }

            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31


            #endregion

        }

    }
}
