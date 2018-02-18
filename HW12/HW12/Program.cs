using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            string userstr = "";

            try
            {
                Console.WriteLine("Enter Text To See If It's a Palindrome or Enter Exit to Quit: ");
                userstr = AcceptInput();
                userstr = userstr.ToLower();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            while (userstr.ToUpper() != "EXIT")
            {
                string reversestring = "";
                int length;
                length = userstr.Length - 1;
                while (length >= 0)
                {
                    reversestring = reversestring + userstr[length];
                    length--;
                }
                string resultString = (userstr == reversestring) ? "Text is a Palindrome" : "Text is Not a Palindrome";
                Console.WriteLine($"Reverse  String  Is  {reversestring} : {resultString}");

                try
                {
                    Console.WriteLine("Enter Text To See If It's a Palindrome or Enter Exit to Quit: ");
                    userstr = AcceptInput();
                    userstr = userstr.ToLower();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        static string AcceptInput()
        {
            string userstr = "";
            try
            {
                userstr = Convert.ToString(Console.ReadLine());
            }
            catch (IOException e)
            {
                throw e;
            }
            return userstr;

        }
    }
}