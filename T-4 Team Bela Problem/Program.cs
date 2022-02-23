//authors: Brian Cantor, Cheyenne VH., William C., Taino N., Gonzalo M., Leslie M., Semir A
//assignment: T-4 Team Echo Bela Kattis Problem
//2/24/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_Team_Bela_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //retrieve input from console user
            string line = Console.ReadLine();
            //set marker to index of the suit type
            int marker = line.IndexOf(' ');
            //create and set index variable so that the for loop will be able to determine when to stop
            int nhands = int.Parse(line.Substring(0, marker))*4;
            //points variable to keep track of the total amount
            int Total = 0;
            //assign suit input to a variable so that program can read it
            char suit = line[marker + 1];
            //for loop using a switch to ruyn through all lines of input and keep a running total based on the designated cases
            for (int i = 0; i < nhands; i++)
            {
                string holder = Console.ReadLine();
                switch (holder[0])
                {
                    case '7':
                        Total += 0;
                        break;
                    case '8':
                        Total += 0;
                        break;
                    case '9':
                        if (holder[1] == suit)
                            Total += 14;
                        break;
                    case 'T':
                        Total += 10;
                        break;
                    case 'J':
                        if (holder[1] == suit)
                            Total += 20;
                        else
                            Total += 2;
                        break;
                    case 'Q':
                        Total += 3;
                        break;
                    case 'K':
                        Total += 4;
                        break;
                    case 'A':
                        Total += 11;
                        break;
                    default:
                        break;
                }
            }
            //display total points tally to user
            Console.WriteLine(Total);
            Console.ReadLine();
        }
    }
}
