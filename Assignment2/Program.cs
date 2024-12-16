namespace Assignment2
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



        }
    }
}
