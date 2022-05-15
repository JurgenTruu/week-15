using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Christmas
        {
            string name;
            string wish;
            public Christmas(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }
            public string Name
            {
                get { return name; }
            }
            public string Wish
            {
                get { return wish; }
            }
        }
        static void Main(string[] args)
        {
            List<Christmas> myChristmas = new List<Christmas>();
            string[] wishesFromFile = GetDataFromFile();
            foreach(string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Christmas newChristmas = new Christmas(tempArray[0], tempArray[1]);
                myChristmas.Add(newChristmas);
                
                
            }
            foreach(Christmas wishesFromList in myChristmas)
            {
                Console.WriteLine($"{wishesFromList.Name} wishes for christmas {wishesFromList.Wish}.");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"{element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\37253\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    }
}
