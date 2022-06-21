using System;

namespace SortStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Orxan";
            string reversedName = backswardsStringConvert(name);
            Console.WriteLine(name + " written backwards is "+reversedName);
            Console.ReadLine();
        }

        private static string backswardsStringConvert(string name)
        {
            string r = "";

            for (int i = name.Length-1; i >=0; i--)
            {
                r += name[i];
            }
            return r;
        }
    }
}
