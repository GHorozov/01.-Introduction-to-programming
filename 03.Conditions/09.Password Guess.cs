﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string corectPassword = "s3cr3t!P@ssw0rd";
            if (password == corectPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
