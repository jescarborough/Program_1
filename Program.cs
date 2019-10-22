using System;
using System.IO;
using System.Collections.Generic;


namespace C_
{
    class Program
    {
        public static String path  = "../../Documents/C#/bin/Debug/pizzas.csv";
        public static List<Pizza> list = new List<Pizza>();

        public static bool exit = false;
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string line = "";
                while((line=sr.ReadLine()) != null)
                {
                String[] temp = line.Split(",");
                Pizza current = new Pizza(Convert.ToInt32(temp[0]),temp[1], Convert.ToDecimal(temp[2]), Convert.ToBoolean(temp[3]));
                list.Add(current);
                }
            }
            int reply = 0;
            while(exit == false)
            {
                Console.Write("Welcome to Andrew's pizza's \n\nWhat Would you like to do?\n1-View available pizza's\n\n2-Add a pizza type\n\n3-Delete a pizza type\n\n4-Exit");
                try
                {
                reply = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                reply = 0;
                }
                switch(reply)
                {
                case 1:
                    Console.Clear();
                    foreach(Pizza curr in list)
                    {
                     System.Console.WriteLine(curr.Number + "-" + curr.Name);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Add();
                    Console.Clear();
                    break;
                case 3:
                    Delete();
                    Console.Clear();
                    break;
                case 4:
                    exit = true;
                    Console.Clear();
                    break;
                default:
                Console.Clear();
                Console.WriteLine("\n\nI didnt quite get that, One more time please");
                break;
                }
            }
        }

        public static void Add()
        {
            System.Console.WriteLine( "Please enter the Name of the pizza:\t");
            string name = Console.ReadLine();
            System.Console.WriteLine( "Please enter the Cost of the pizza:\t");
            decimal cost = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine( "Is it Vegetarian:\n1-YES\n\n2-NO");
            int veg_reply = Convert.ToInt32(Console.ReadLine());
            bool veg = false;
            if(veg_reply == 1)
            {
                veg = true;
            }
            Pizza Added = new Pizza(list.Count+1,name, cost, veg);
            list.Add(Added);
            using(StreamWriter sw = new StreamWriter(path))
            {
                foreach(Pizza pizz in list)
                {
                    sw.WriteLine(pizz.ToString());
                }
            }
        }

        public static void Delete()
        {
            foreach(Pizza curr in list)
                {
                System.Console.WriteLine(curr.Number + "-" + curr.Name);
                }
            System.Console.WriteLine( "Please enter the Number of the pizza you wish to delete:\t");
            int del_number = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(del_number-1);
            using(StreamWriter sw = new StreamWriter(path))
            {
                foreach(Pizza pizz in list)
                {
                    sw.WriteLine(pizz.ToString());
                }
            }
        }

        public static void reverse()
        {
            string reverse = "";
            Console.WriteLine("Welcome");
            string letters = Console.ReadLine();
            for(int i = 1; i <= letters.Length; i++)
            {
                 reverse = reverse + letters[letters.Length-i];
            }
            Console.WriteLine(reverse);
        }

        public static void Fibbonacci()
        {
            Console.WriteLine("Please enter the number of Fibonacci numbers you are looking for:");
            int number = Convert.ToInt32(Console.ReadLine());
                int number1 = 0;
                int number2 = 1; 
            for(int i = 0; i<number; i++)
            {
                Console.Write(number1);
                int temp = number1;
                number1 = number2;
                number2 = temp + number2;
            }
        }

        public static void Palindrome()
        {
            bool palindrome = true;
            Console.WriteLine("Enter a suspected palindrome:");
            string letters = Console.ReadLine().ToLower();
            for(int i = 0; i< letters.Length-1; i++)
            {
                if(letters[i]!=letters[letters.Length-1-i])
                {
                    palindrome = false;
                }
            }
            Console.WriteLine(palindrome);
        }
    }
}

