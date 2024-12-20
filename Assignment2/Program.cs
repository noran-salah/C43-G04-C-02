﻿namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Write a program that allows the user to enter a number then print it.

            int Number;
            Console.WriteLine("Enter Number");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine(Number);
            #endregion

            #region MyRegion
            //Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen

            String Input = "123ABC";
            int Result =Convert.ToInt32(Input);
            #endregion

            #region MyRegion
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            double num1 = 0.1;
            double num2 = 0.2;
            double sum= num1 + num2;
            Console.WriteLine($"Sum = {sum}"); //0.3
            #endregion

            #region MyRegion
            //Write C# program that Extract a substring from a given string.

            string String = "Hello World";
            string SubString = String.Substring(5);
            Console.WriteLine($"Substring = {SubString}");
            #endregion

            #region MyRegion
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int X = 2;
            int Y = 2;

            X = Y; X=2 Y=2

            X = 4; 4

            Console.WriteLine($"X = {X}  Y = {Y}");
            #endregion

            #region MyRegion
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr01 = { 1, 2, 3 };

            int[] arr02 = arr01;

            arr02[0] = 5;

            Console.WriteLine( $" Arr01 ={arr01[0]}  Arr02 ={arr02[0]}");
            #endregion

            #region MyRegion
            //Write C# program that take two string variables and print them as one variable 

            string str01 = "Hello";
            string str02 = "world";

            Console.WriteLine($"{str01} {str02}");
            #endregion

            #region MyRegion
            // 8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            double principal = 1000.0;
            double rate = 2.0;
            double time = 5.0;

            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"interest = {interest}");
            #endregion

            #region MyRegion
            //9 - Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            double Weight = 70.0;
            double Height = 1.90;

            double BMI = (Weight) / (Height * Height);

            Console.WriteLine($"BMI = {BMI}");
            #endregion

            #region MyRegion
            //10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result.Assume that below 10 degrees is "Too Cold", above 30 degrees is "Too Hot", and anything else is "Just Good".

            double Temp = 8.0;

            string Message = Temp < 10 ? "too cold" : Temp > 30 ? "Too Hot" : "Just Good";

            Console.WriteLine(Message);
            #endregion

            #region MyRegion
            #region Q11
            //11 - Write a program that takes the date from user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            DateTime dateTime = DateTime.Now;

            string Fromate01 = $"{dateTime.Day} , {dateTime.Month} , {dateTime.Year}";
            string Fromate02 = $"{dateTime.Day} / {dateTime.Month} / {dateTime.Year}";
            string Fromate03 = $"{dateTime.Day} - {dateTime.Month} - {dateTime.Year}";

            Console.WriteLine(Fromate01);
            Console.WriteLine(Fromate02);
            Console.WriteLine(Fromate03);
            #endregion


            #region MyRegion
            //What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");  // 06/14/2024

            ////a) The event is on 14/06/2024
            ////b) The event is on 2024-06-14
            ////c) The event is on 06/14/2024
            ////d) The event is on June 14, 2024

            //// Ansewr --> C
            #endregion


            #region MyRegion
            //13 - Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20)); //False --> true -->1
            //Console.WriteLine(d);
            ////e)	A value 0 will be assigned to d.
            ////f)	A value 1 will be assigned to d.
            ////g)	A value -1 will be assigned to d.
            ////h)	The code reports an error.
            ////i)	The code snippet will work correctly if ! is replaced by Not.


            //Console.WriteLine(d);


            // Ansewr --> f
            #endregion


            #region MyRegion
            //14-	Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2); //6 1

            //a)	6.5 1
            //b)	6.5 0
            //c)	6 0
            //d)	6 1
            //e)	6.5 6.5


            // 6 1

            // Answer --> d
            #endregion
            #region MyRegion
            //What will be the output of the C# code given below?


            //int num = 1, z = 5;


            //if (!(num <= 0)) //True 
            //                       //7  7
            //    Console.WriteLine(++num + z++ + " " + ++z); 
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //a)	5 6
            //b)	6 5
            //c)	6 6
            //d)	7 7


            // Answer --> d

            #endregion
        }
    }
}
