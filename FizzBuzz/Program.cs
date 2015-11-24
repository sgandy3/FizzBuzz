using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter numbers to set for Fizz, Buzz, and the highest number to \ncount, separated by a space"); //ask for data from user
            string userInput = Console.ReadLine();  //get user from data
            Console.WriteLine(" ");
            string[] myvals = userInput.Split(' ');  //separate data from string based on " "

            int x = Convert.ToInt32(myvals[0]);
            int y = Convert.ToInt32(myvals[1]);
            int z = Convert.ToInt32(myvals[2]);


            for (int i = 1; i <= z; i++)//loop and print numbers on same line until iterator equals numLimit
            {
                if (i % x == 0 && i % y == 0) //if number is equal to both fizz and buzz
                {
                    Console.Write(" FB ");//print 'fb'
                }

                else
                
                    if (i % x == 0)//if number is equal to fizz
                    {
                        Console.Write(" " + 'F' + " ");  //print 'f'
                    }
                

                else
                
                    if (i % y == 0)//if number is equal to buzz
                    {
                        Console.Write('B');//print 'b'
                    }
                
                
                else
                {

                    Console.Write(i);
                }
            }

        

            


        }
    }
}
