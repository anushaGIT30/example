// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console .ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

//for input of numbers  we use
Console.WriteLine("enter the num");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("num is" +num);

Console.WriteLine("Enter a double value:");
double myDouble = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("You entered double: " + myDouble);

// Input for float
Console.WriteLine("Enter a float value:");
float myFloat = float.Parse(Console.ReadLine());
Console.WriteLine("You entered float: " + myFloat);

// Input for bool
Console.WriteLine("Enter a boolean value (true/false):");
bool myBool = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("You entered bool: " + myBool);

//operators
int a = Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
int ans = a + b;
Console.WriteLine(ans);

//math function
int c = 9;
int k = 57;
int max= Math.Max(c, k);
Console.WriteLine(max);
int min =Math.Min(c, k);
Console.WriteLine(min);
int d = 25;
double s = (int) Math.Sqrt(d);
Console.WriteLine(s);
double dh = 556.4555;
double h = Math.Round(dh);
Console.WriteLine(h);
double v = -9.5;
double n = Math.Abs(v);
Console.WriteLine(n);


// strings
using Microsoft.VisualBasic;

string name = "anusha";
string name2 = "ANUSHAK";
Console.WriteLine(name);
Console.WriteLine(name.Length);
// string methods
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower()); ;
string l = "akaru";
string g = "anu";
Console.WriteLine(l + g);
//using methods
string ans = string.Concat(l, g);
Console.WriteLine(ans);

string o = "69";
string x = "15";
Console.WriteLine(o + x);
//op:6915

//---INTERPOLATION--
//Another option of string concatenation, is string interpolation,
//which substitutes values of variables into placeholders in a string
string firstName = "ch";
string lastName = "anusha";
string fullname = $"My full name is: {firstName} {lastName}";
Console.WriteLine(fullname);

//Access Strings You can access the characters in a string by referring to its index number inside square brackets [].
string ak = "enjoy coding";
Console.WriteLine(ak[1]);

//You can also find the index position of a specific character in a string, by using the IndexOf() method:
Console.WriteLine(ak.IndexOf("o"));

// substring:Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string.
// This method is often used together with IndexOf() to get the specific character
Console.WriteLine(ak.Substring(ak.IndexOf("n")));

//special string characters
string txt = "We are the so-called \"Vikings\" from the north.";



//boolean
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

//A Boolean expression returns a boolean value: True or False, by comparing values/variables.
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

//realtime example

int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}
//in c# we have if,else,else if  
// largest of three numbers

Console.WriteLine("enter the first value:");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second value:");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the third value:");
int t = Convert.ToInt32(Console.ReadLine());
if(f>s && f > t)
{
    Console.WriteLine("1st value is greater");
}
else if(f<s && s > t)
{
    Console.WriteLine("2nd value");
}
else
{
    Console.WriteLine("3rd is greater");
}
// switch statement

Console.WriteLine("enter the num");
int k = Convert.ToInt32(Console.ReadLine());
switch (k)
{
    case 1: Console.WriteLine("ist case");
            break;
    case 2: Console.WriteLine("2nd case");
            break;
    case 3:Console.Write("3rd case");
            break;
    default:Console.WriteLine("error");
        break;

}


// FOR LOOP
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}

int n = Convert.ToInt32(Console.ReadLine());
for (int j = n; j > 0; j--)
{
    Console.WriteLine(j);
}
//printing a pattern

using System;


    
        // Taking input from the user for the number of rows and columns
        Console.WriteLine("Enter the number of rows:");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int c = Convert.ToInt32(Console.ReadLine());

        // Looping to print the rectangle of stars
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("*");  // Print '*' on the same line
            }
            Console.WriteLine();  // Move to the next line after each row
        }

int i = 1;
while (i<=10)
{
    Console.WriteLine(i);
    i++;
}


//continue statement

using System.Reflection.Metadata.Ecma335;

for (int i = 1; i < 20; i++)
{
    if (i == 10) ;
    continue;


    }



using System;
namespace functionExample
{
    class Program
    {
        public void show()
        {
            Console.WriteLine("this is a function");
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.show();

        }

    }
 
using System;
namespace functionExm
{

    class Example {

        public int sum(int a,int b)
        {
            return a + b;    
        }
        static void Main(string[] args)
        {
            Example  example= new Example();
           int res= example.sum(4, 6);
            Console.WriteLine(res);
        }
    }

}

// in c# we have 3 types of arrays
//1. single dimensional array 2. multi dimensional array 3. jagged array
// creating single dimensional array
int[] array = new int[10];
array[0] = 1;
array[1] = 2;
array[2] = 3;
array[4] = 4;

for(int i = 0; i <5; i++)
{
    Console.WriteLine(array[i]);
}

//C# Array Example: Declaration and Initialization at same time
//There are 3 ways to initialize array at the time of declaration.

//int[] arr = new int[5] { 10, 20, 30, 40, 50 };
//We can omit the size of array.


//int[] arr = new int[] { 10, 20, 30, 40, 50 };
//We can omit the new operator also.

//int[] arr = { 10, 20, 30, 40, 50 };
int[] arr = { 11, 22, 33, 44, 55 };
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
//we can also use for each loop 

    {
        int[] arr1 = { 10, 20, 30, 40, 50 };//creating and initializing array  

        //traversing array  
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }


//array declaration with user input
using System;
namespace program
{

    class Arrayexample {
    
    void printArray(int[] arr,int n)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Arrayexample arrayexample = new Arrayexample();
           


                arrayexample.printArray(arr,n);
            
        }
    
    
    
    }


}
*/

//****printing minimum and maximum number

using System;
namespace program
{

    class MaxMin {
    
    void printMinMax(int n, int[] arr)
        {

            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("the max value is:" + max);
            Console.WriteLine("the min value is:" + min);
        }
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            MaxMin minimax = new MaxMin();
            minimax.printMinMax(n, arr);
        }
    
    
    
    }

}



