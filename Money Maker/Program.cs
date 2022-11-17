using System;
using System.Security.Cryptography.X509Certificates;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int userVal = 0;
            Console.Write("Welcome to Money Maker!\nPlease Enter the amount to convert: "); //using Write instead of WriteLine allows for user to input text
                                                                                            //on the same line as the message
            while (userVal == 0) //while loop used so the user can try again if they input incorrect data
            {
                string userIn = Console.ReadLine();
                int.TryParse(userIn, out userVal); //turns string into an integer without throwing an exception,
                                                   //if the string is not an integer it will change userVal to 0 if the value is an integer, it will change userVal to that integer
                if (userVal != 0) //stops the invalid integer message being displayed when the user has inputted an integer
                {
                    break;
                }
                Console.Write("Please enter a valid integer: ");
            }
            //this part sees how many coins can go into the total remaining and how many are left
            int tenCoins = userVal / 10;
            int tenRemain = userVal % 10;
            int fiveCoins = tenRemain / 5;
            int fiveRemain = tenRemain % 5;
            int oneCoins = fiveRemain;
            Console.WriteLine($"You will need:\n{tenCoins} tens\n{fiveCoins} fives\n{oneCoins} ones"); //outputs the answer
        }
    }
}
