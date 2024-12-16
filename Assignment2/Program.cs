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


        }
    }
}
