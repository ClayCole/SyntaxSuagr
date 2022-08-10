using System;

namespace SyntaxSugarExcerise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }

            // The Homework 

            // var answer = 4;
            // var responses = (answer < 9) ? $"{answer} is less than nine" : $:{answer} greater than or equal to nine";


        }
    }
}

