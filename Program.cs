using System;

namespace FunctionsMethodsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
           // Console.WriteLine("Welcome Friends");
           // Console.WriteLine("Have a nice day!");

            // Task 2
           // Console.WriteLine("__");

            //Console.WriteLine("Please input your name: ");
           // string yourName = Console.ReadLine();

           // Console.WriteLine("Welcome friend " + yourName);
          //  Console.WriteLine("Have a nice day!");

            // Task 3
        //    Console.WriteLine("__");

        //    Console.WriteLine("Enter a number of your choice: ");
        //    int numerouno = int.Parse(Console.ReadLine());
            // Asks user for a second input
        //    Console.WriteLine("Enter another number of your choice: ");
        //    int numerodos = int.Parse(Console.ReadLine());

         //   int sum = numerouno + numerodos;

         //   Console.WriteLine("The sum of the two numbers is: " + sum);

             // Task 4
            // string str = "This is a test string";
            // char ch = 's';
    
            // int freq = 0;
            // foreach (char c in str);
            // {
            //     if (c == ch) {
            //         freq++;
            //     }
            // }
    
            // Console.WriteLine(freq);
            // Task 5
            //     int[] a= new int[100];
            // int i, n, sum=0;
            
            
            //    Console.Write("Find sum of all elements of array:");
            //    Console.Write("--------------------------------------");	

            //    Console.Write("Input the number of elements to be stored in the array :");
            //    n = Convert.ToInt32(Console.ReadLine()); 
        
            //    Console.Write("Input {0} elements in the array :\n",n);
            //    for(i=0;i<n;i++)
            //     {
            //       Console.Write("element - {0} : ",i);
            // 	  a[i] = Convert.ToInt32(Console.ReadLine()); 
            //     }

            // for(i=0; i<n; i++)
            // {
            //     sum += a[i];
            // }

            // Console.Write("Sum of all elements stored in the array is : {0}", sum);
            // Task 6
            // int number1, number2, temp;
            // Console.Write("\nInput the First Number : ");
            // number1 = int.Parse(Console.ReadLine());
            // Console.Write("\nInput the Second Number : ");
            // number2 = int.Parse(Console.ReadLine());
            // temp = number1;
            // number1 = number2;
            // number2 = temp;
            // Console.Write("\nAfter Swapping : ");
            // Console.Write("\nFirst Number : "+number1);
            // Console.Write("\nSecond Number : "+number2);
            // Console.Read();
            // Task 7
            //     int n1;
            //     int exp1;
            //     Console.Write("Function : To calculate the result of raising an integer number to another :");
            //     Console.Write("--------------------------------------------------------------------------------");
            //     Console.Write("Input Base number: ");
            //     n1= Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Input the Exponent : ");
            //     exp1= Convert.ToInt32(Console.ReadLine());	  
            //     Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ",n1, exp1, PowerRaising(n1, exp1));  
            // }
            // public static int PowerRaising(int num, int exp)
            //     {
            //     int rvalue = 1;
            //     int i;
            //     for (i=1;i<=exp;i++)
            //     rvalue=rvalue*num;
            //     return rvalue;
            //     }
            //Task 8
            // static int Fibo(int nno)
            //     {
            //     int num1 = 0;
            //     int num2 = 1;
                
            //     for (int i = 0; i < nno; i++)
            //     {
            //         int temp = num1;
            //         num1 = num2;
            //         num2 = temp + num2;
            //     }     
            //     return num1;
            //     }
                    
            //         Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
            //         Console.Write("------------------------------------------------------------\n");
            //         Console.Write("Input number of Fibonacci Series : ");
            //         int n= Convert.ToInt32(Console.ReadLine());
                    
            //         Console.WriteLine("The Fibonacci series of "+n+" numbers is :");	  
            //         for (int i = 0; i < n; i++)
            //         {
            //             Console.Write(Fibo(i)+"  ");
            //         }
            //         Console.WriteLine();
                        //Task 9
            //  Console.WriteLine("Pick a number: ");
            //  int n = int.Parse(Console.ReadLine()), a = 0; 

            //   for (int i = 1; i <= n; i++) {
            //     if (n % i == 0) {
            //        a++;
            //      }
            //   }
            //   if (a == 2) {
            //       Console.WriteLine("{0} is a Prime Number", n);
            //    } else {
            //       Console.WriteLine("Not a Prime Number");
            //    }
            //    Console.ReadLine();

                        // Task 10
            //    int SumCal( int n ){

            //    string n1 = Convert.ToString(n);
            //   int sum = 0;
            //   for (int i = 0; i < n1.Length; i++)
            //    sum += Convert.ToInt32(n1.Substring(i,1));
            //    return sum;
            //   }
            //  int num;


            //   Console.Write("Enter a number: ");
            //   num = Convert.ToInt32( Console.ReadLine() );
            //   Console.WriteLine("The sum of the digits of the number {0} is : {1} \n",num,SumCal(num));
        }            
    }
}
