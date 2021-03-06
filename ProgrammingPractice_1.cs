using System;
using System.Collections.Generic;

namespace ProgrammingPractice
{
    class Program
    {
        static void Main(string[] _)
        {
            // FizzBuzz();
            // FindDuplicateInArray();
            // Console.WriteLine(Program2.Test(4,4));
            ArrayProgram.ArrayMethod();
            Console.ReadKey();
            
        }

        static void FizzBuzz()
        // Prints the integers 1-100 and every time an int is divisible by 3 it prints Fizz and everytime it is divisible by 5 it prints buzz and...
        // ...when the int is divisible by both 3 and 5 it prints FizzBuzz.
        {
            for(int i = 1; i <= 100; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }

        static void FindDuplicateInArray()
        //Finds duplicate integers in an array of integers without using LINQ and siplays how many times it occurs.
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();
        }

    }
    class Program2
    // Evaluates two integers and if they are equal, it sums them then multiplies the sum by 3. If they are not equal, it just sums them.
    {
        static void Main2(string[] _)
        {
            Console.WriteLine(Test(1, 2));
            Console.WriteLine(Test(3, 2));
            Console.WriteLine(Test(2, 2));
            Console.ReadKey();
        }
        
        public static int Test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }

    class ArrayProgram
    // Allows user to input 10 values into an array and then prints the values as an array.
    {
        public static void ArrayMethod()
        {
            Console.WriteLine("State how many elements in array:: ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numOfElements];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input numOfElements elements in the array :\n");
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: [ ");
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write(" ]\n");
        }
    }
}
