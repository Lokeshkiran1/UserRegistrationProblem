﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class ValidFirstName
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";


        public void IsValidFirstName()
        {
            bool flag;
            Console.WriteLine("Enter the first name");

            do
            {
                string firstname = Console.ReadLine();
                flag = (Regex.IsMatch(firstname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }
    }
}
