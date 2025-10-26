//Group Activity : Direction: Write a simple program that can determine the divisibility of a number by 2, 3, and 6.
using System;



class Discrete
{
    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Checking the Divisibility");
            Console.WriteLine();


            Divisibility(num1);
            Console.WriteLine();

            Divisibility(num2);
            Console.WriteLine();

            Divisibility(num3);
            Console.WriteLine();

            Console.WriteLine("Do you want to continue? Press y/n");
            string again = Console.ReadLine().ToLower();
            if (again != "y") break; //Break point.
        }
    } 
        
        static void Divisibility(int num) {

        Console.WriteLine($"Number: {num}");
          if (num == 0)
        {
            Console.WriteLine("0 is not Divisibility by 2, 3, 6");
               return;
        }
         
          if (num < 0)
                {
             Console.WriteLine("Its not Divisibility by 2");
             Console.WriteLine("Its not Divisibility by 3");
             Console.WriteLine("Its not Divisibility by 6");
             return;
        }
       
        if (num % 2 == 0)
        {
            Console.WriteLine("Its Divisibility by 2 ");
            
        }
        else
        {
            Console.WriteLine("Its not Divisibility by 2");
        }

        if (num % 3 ==  0)
        {
            Console.WriteLine("Its Divisibility by 3");
          
        }   
        else
        {
            Console.WriteLine("Its not Divisibility by 3");
        }

        if (num % 6 == 0)
        {
            Console.WriteLine("its Divisibility by 6");
          
        }
        else
        {
            Console.WriteLine("Its not Divisibility by 6");
           }
        }
     }
 
   
