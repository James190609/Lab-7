using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7FirstUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program will take the name of the user and then change the first letter of their name into caps and the rest of the name into lower case 

            //input
            string restOfName = null;
            char firstLetter = 'a';

            //output 
            //will display the input name of the user withh the first letter being a caps and the rest being lower case 

            //constants 
            //no constants 
            
            //process
            //ask users to enter their name
            Console.Write("please enter your name : ");
            restOfName = Console.ReadLine();

            firstLetter = restOfName.ElementAt(0);

            //change the first letter of the input being stored and change it to capital letters 
            firstLetter = char.ToUpper(firstLetter);
            restOfName = restOfName.Substring(1).ToLower();

            //display to console in a visiual manner 
            Console.WriteLine(firstLetter + restOfName);
            Console.ReadKey();




        }
    }
}
