using System;
public class GradeSystem
{
     public static void Run()
     {
          while (true)
          {
               System.Console.WriteLine();
               System.Console.WriteLine("Enter your grade: ");

               if (!double.TryParse(Console.ReadLine(), out double grade))
               {
                    System.Console.WriteLine("Invalid Input!");
                    continue;
               }
               if (grade < 0 || grade > 100)
               {
                    System.Console.WriteLine("Invalid Input Grade!");
                    continue;
               }
               if (grade >= 97 && grade <= 100)
               {
                    System.Console.WriteLine("Grade is equivalent 1.00");
               }
               else if (grade >= 94 && grade <= 96)
               {
                    System.Console.WriteLine("Grade is equivalent 1.25");
               }
               else if (grade >= 91 && grade <= 93)
               {
                    System.Console.WriteLine("Grade is equivalent 1.50");
               }
               else if (grade >= 87 && grade <= 90)
               {
                    System.Console.WriteLine("Grade is equivalent 1.75");
               }
               else if (grade >= 83 && grade <= 86)
               {
                    System.Console.WriteLine("Grade is equivalent 2.00");
               }
               else if (grade >= 79 && grade <= 82)
               {
                    System.Console.WriteLine("Grade is equivalent 2.25");
               }
               else if (grade >= 75 && grade <= 78)
               {
                    System.Console.WriteLine("Grade is equivalent 2.50");
               }
               else if (grade >= 71 && grade <= 74)
               {
                    System.Console.WriteLine("Grade is equivalent 2.75");
               }
               else if (grade >= 65 && grade <= 70)
               {
                    System.Console.WriteLine("Grade is equivalent 3.00");
               }
               else
               {
                    System.Console.WriteLine("Grade is equivalent 5.00 Failed!");
               }

          }
     }
}
