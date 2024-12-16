namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Error Types
            #region Syntax Error

            //console.WriteLine(); // syntax error
            //Console.writeLine();
            //Console.WriteLine() // Syntax Error




            #endregion


            #region Logical Error

            //Console.WriteLine(Sum(10, 5));
            //Console.WriteLine("Hello");
            #endregion

            #region RunTime Errors

            //int x = 0; int y = 0;

            //int z;
            //Console.WriteLine(x / y);
            //Console.WriteLine("Hello After Divide");
            #endregion



            #endregion

            #region Variables
            //int x; //=> Declaration
            //x = 0; //=> initialization

            //int y = 0;
            //int z;
            ////Console.WriteLine(z);
            //if(z > 0)
            //{

            //}

            //byte x = 1;

            //sbyte y = -2;

            //int z = -6;

            //uint a = 6;



            #endregion


            #region Value Type 

            //int x = 4;
            //Console.WriteLine("x =" + x);
            //Console.WriteLine(x.GetHashCode());

            //int y = 9;
            //Console.WriteLine("y =" + y);
            //Console.WriteLine(y.GetHashCode());

            //Console.WriteLine("After y = x");
            //Console.WriteLine("=============================");
            //y = x;
            //Console.WriteLine("x =" + x);
            //Console.WriteLine(x.GetHashCode());

            //Console.WriteLine("y =" + y);
            //Console.WriteLine(y.GetHashCode());


            #endregion


            #region Reference Type 

            //Point p1 = new Point();
            //Point p2 = new Point();
            //p1.x = 5;
            //p1.y = 10;
            //Console.WriteLine("P1");
            //Console.WriteLine("x = " + p1.x + " y = "+ p1.y);
            //Console.WriteLine(p1.GetHashCode());
            //p2.x = 25;
            //p2.y = 50;

            //Console.WriteLine("=========================");
            //Console.WriteLine("P2");
            //Console.WriteLine("x = " + p2.x + " y = " + p2.y);
            //Console.WriteLine(p2.GetHashCode());

            //p2 = p1;

            //p2.x = 100;

            //Console.WriteLine("after Changes");
            //Console.WriteLine("P1");
            //Console.WriteLine("x = " + p1.x + " y = " + p1.y);
            //Console.WriteLine(p2.GetHashCode());




            #endregion

            #region System.Object

            //obj = 10;
            //obj = true;
            //obj = "hello";
            //obj = 'a';

            //3.GetHashCode();
            //3.ToString();
            //4.Equals(obj);


            //object obj = new object();
            //Console.WriteLine(obj);

            //obj = new Point();
            //Console.WriteLine(obj);

            //obj = 4;
            //Console.WriteLine(obj);
            //obj = true;
            //Console.WriteLine(obj);
            //obj = 3.5;
            //Console.WriteLine(obj);


            #endregion



            #region Casting

            #region Implicit Casting (Safe Casting)



            //int x = int.MaxValue;
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());

            //long y = x;
            //Console.WriteLine(y); 
            //Console.WriteLine(y.GetType());

            //object z = y;

            //short l = 1;
            //y = l;






            #endregion


            #region Explicit Casting

            //unchecked
            //{
            //    long y = 4865134896148;

            //    int x = (int)y; 
            //     Console.WriteLine(x);
            //}


            //object obj = 'a';

            //int x = (int)obj;

            //Console.WriteLine("hello");






            #endregion


            #region Parse
            // parse  => Convert from String to any dataType


            //string x = "a";

            //int y = int.Parse(x);


            //double.Parse(x);
            //long.Parse(x);
            //DateTime.Parse(x);
            //char.Parse(x);
            //byte.Parse(x);



            //Console.WriteLine(y);


            //// to be Safe Casting 


            //int.TryParse(x, out int result);



            #endregion


            #region Convert 
            // Convert => Convert from any dataType To Any DataType

            //bool x = true;

            //object obj = 6;
            //int y = Convert.ToInt32(obj);




            #endregion

            #endregion


            #region Fractions DataType

            //double x = 17.5; 
            //decimal y = 18.6M;
            //float z = 196.6f;


            //int a = 999_999_999;





            #endregion




            #region Operators

            #region Unary Operators [++, --]

            //Postfix

            //int x = 0;

            //Console.WriteLine(x++);  // after logic increase x by 1 => x +=1 || x = x+1
            //Console.WriteLine(x);


            //Prefix

            //int x = 0;

            //Console.WriteLine(++x);  // Before logic increase x by 1 => x +=1 || x = x+1
            //Console.WriteLine(x);


            #endregion


            #region Binary Operators [+,-,/,*, %]

            //Console.WriteLine(1+1);
            //Console.WriteLine(1 - 1);
            //Console.WriteLine(1 / 1);
            //Console.WriteLine(2 * 2);

            //          // +4 => 9    || -2 => 3/3 
            //int x = 5%3; // => 2.5 => 2
            //Console.WriteLine( x);  // => 5






            #endregion


            #region Relational Operators [==, != , >, < , >=, <=]

            //int x = 10;

            //bool flag =  x ==10; // =>    true

            //flag = x != 9; //true


            //if(10 > 5)
            //    Console.WriteLine("hello");





            #endregion

            #region Assignment Operators   [=, +=, -=, *=,/=,%=]

            //int x = 1;
            //x += 2; // => x = x+2;
            //x -= 2; // => x = x-2;
            //x %= 2; // => x = x%2;



            #endregion

            #region Logical Operators

            //bool flag = false;

            ////if(!flag)    // => not equal false => true
            ////{
            ////    Console.WriteLine("Hello");
            ////}

            //// && must two conditions return true to enter 
            //if (false || false)  // || must two conditions return false to ignore 
            //{
            //    Console.WriteLine("Hello");

            //}


            #endregion


            #region Ternary Operator    [ = ? :]


            //bool flag = false;
            //int x;

            //if (flag)
            //    x = 1;
            //else
            //    x = 4;


            //x = flag ? 5 : 6;

            //Console.WriteLine(x);


            #endregion


            #region BitWise Operators [& , | , ~ , ^ , << , >>]


            /*
             *                 32  16  8  4  2  1
             *      5                  0  0  1  0  
             *      
             *      8                  1  0  0  0
             */




            #region And & 

            //int a = 5; //binary : 0101;
            //int b = 3; //binary : 0011;


            //int result = a & b; //binary:   0001 [Decimal Number : 1]     
            //Console.WriteLine(result);


            #endregion


            #region Or [ | ]
            //int a = 5; //binary : 0101;
            //int b = 3; //binary : 0011;


            //int result = a | b; //binary:   0111 [Decimal Number : 7]     
            //Console.WriteLine(result);

            #endregion


            #region XOR [ ^ ]
            //int a = 5; //binary : 0101;
            //int b = 3; //binary : 0011;


            //int result = a ^ b; //binary:   0110 [Decimal Number : 6]     
            //Console.WriteLine(result);

            #endregion

            #region Not [ ~ ]

            //int x = 5; // binary : 0101;

            //int result = ~x; // binary: 1010 Decimal : -6
            //Console.WriteLine(result);



            #endregion


            #region SHift Left

            //int x = 5; // binary : 0101;

            //int result = x << 1; // binary:  1010 Decimal : 10
            //Console.WriteLine(result);

            #endregion


            #region Shift Right

            int x = 5; // binary : 0101;

            int result = x >> 1; // binary:  0010 Decimal : 2
            Console.WriteLine(result);

            #endregion


            #endregion


            #endregion


            #region How To Read Data From User

            Console.WriteLine("Please Enter Your age");

            //string input = Console.ReadLine();

            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your Age = "+ age);




            #endregion
        }
    }
}
