using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab7UpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program will take in and store three separate sentences that should be inputted in any case, then reorders the first letter to be caps 
            //and then join all 3 sentences and make into one sentences

            //inputs 
            char firstLetter = 'A';
            string scentence1 = null;
            string scentence2 = null;
            string scentence3 = null;

            //outputs 
            //same an inputs 

            //constants 
            //none

            //processing 
            //asking user for inputs 
            Console.Write("please enter sentence 1  : ");
            scentence1 = Console.ReadLine();
            Console.Clear();

            Console.Write("please enter sentence 2 : ");
            scentence2 = Console.ReadLine();
            Console.Clear();

            Console.Write("please enter sentence  : ");
            scentence3 = Console.ReadLine();
            Console.Clear();

            //changing the inputs to upper case 
            firstLetter = scentence1.ElementAt(0);
            firstLetter = char.ToUpper(firstLetter);

            //change the rest of the scentences to lower case 
            scentence1 = scentence1.Substring(1).ToLower();
            scentence2 = scentence2.ToLower();
            scentence3 = scentence3.ToLower();

            //print back to console in a visiual manner 
            Console.WriteLine(firstLetter + scentence1+ ", " + scentence2 + ", " + scentence3+".");
            Console.ReadKey();


        }
    }
}
