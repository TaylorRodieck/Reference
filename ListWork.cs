using System.IO;
using System.Collections.Generic;
using System;

namespace TableTesting
{
    class ReadingCSV
    {
        static void Main(string[] _)
        {
            ListStuff();
        }
        
        static void ListStuff()
        {
            string path = @"C:\Users\taylor.r\Documents\Visual Studio Projects\TableTesting\Book2.txt";
            string[] lines = File.ReadAllLines(path);
            
            string[] fields = new string[0];
            List<string> ColOneList = new List<string>();
            List<string> ColTwoList = new List<string>();
            
            foreach (var line in lines)
            {

                fields = line.Split(',');
                
                ColOneList.Add(fields[0]);
                ColTwoList.Add(fields[1]);
                
                Console.WriteLine("Column 1:: " + fields[0] + "; Column 2:: " + fields[1]);
            }

            Console.WriteLine();

            ColOneList.AddRange(ColTwoList);
            var listNew = String.Join(", ", ColOneList);
            Console.WriteLine("{" + listNew + "}");


            Console.Read();
        }
    }
}

