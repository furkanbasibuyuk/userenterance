using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userEnteranceRight = 3;
            while(true) 
            {
                Console.WriteLine("Please write your nickname");
                string userNickName = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                string userPassword = Console.ReadLine();   

                if (userNickName == "furkan" && userPassword == "1234") 
                {
                    Console.WriteLine("Congratulations you entered the system succesfully!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your user name or user password is wrong! Try again.");

                    if(userEnteranceRight > 0)
                    {
                        userEnteranceRight -= 1;    
                    }
                    if(userEnteranceRight == 0)
                    {
                        Console.WriteLine("Your enterance rights are done! You have no more rigth to enter the system");
                        break;
                    }
                }
            }

            Console.WriteLine();

        }
    }
}
