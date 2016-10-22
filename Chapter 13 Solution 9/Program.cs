﻿using System;

namespace Chapter_13_Solution_9
{
    public class Program
    {
        public void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string[] sentences = text.Split('.');

            foreach (string str in sentences)
                if (str.Contains(" in ")) Console.WriteLine(str + '.');

            Console.ReadLine();
        }
    }
}
