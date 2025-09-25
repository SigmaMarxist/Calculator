using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void GetParen(string input) {
            string group = "";
            bool inParen = false;
            for (int i = 0; i < input.Length; i++)
            {    //for loop puts first thing in parentheses in group ()
                if (input[i] == ')')
                {
                    break;
                }
                if (inParen)
                {
                    group += input[i];
                }
                if (input[i] == '(')
                {
                    group = "";
                    inParen = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string group = "";
            bool inParen = false;
            GetParen(input);
            Console.Write(group);

        }
    }
}
