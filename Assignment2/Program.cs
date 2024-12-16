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

        }
    }
}
