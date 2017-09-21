     using System;

     namespace ConsoleApplication1
     {
         class Program
         {
             static void Main()
             {
            int A;
            Console.WriteLine("Enter weight");
            A = int.Parse(Console.ReadLine());
            check(ref A);

            Console.ReadLine();

        }
            static void check(ref int i)
            {
            Console.WriteLine("Answer is");
            Console.WriteLine(i / 1.60);
           
           }
    }
 } 