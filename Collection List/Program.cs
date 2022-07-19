using System;
using System.Collections.Generic;


namespace Collection_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // first  type
            List<int> obj = new List<int>();
            obj.Add(12);
            obj.Add(123);
            obj.Add(124);
            obj.Add(125);

            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
            // second type 
            List<string> s = new List<string>() { "akshay  ", "saini   ", "hiii   ", "hello   " };
            foreach (string item in s)
            {
                Console.Write(item);
            }

            Console.WriteLine(obj.Count);
        }
    }
}
