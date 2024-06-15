using System;

namespace Banking_app_by_gaurav_khatri
{
    internal class Program
    {// hint email is gk@gmail.com & password is gk123
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Khatri Bank ");
            Console.WriteLine("======================");

            String email = "gk@gmail.com";
            String password = "gk123";
            String name = string.Empty;

            while (true)
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("Hi! " + name + ", Kindly Enter your Email and Password ");
                Console.WriteLine("Enter your Email");
                String enteremail = Console.ReadLine();
                Console.WriteLine("Enter your Password");
                String enterpassword = Console.ReadLine();

                if (enteremail == email && enterpassword == password)
                {
                    Console.WriteLine("Access Granted!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect email or password. Please try again.");
                }
            }

            int balance = 500;  // Initialize balance

            while (true)
            {
                Console.WriteLine("Welcome " + name + ", Which Service do you want? " +
                    "1: Check Balance  " +
                    "2: Withdraw " +
                    "3: Deposit " +
                    "4: Exit");

                Console.WriteLine("Enter the Service Number");
                string input = Console.ReadLine();
                int num;

                if (int.TryParse(input, out num))
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Checking Balance...");
                            Console.WriteLine("Your current balance is: " + balance);
                            break;
                        case 2:
                            Console.WriteLine("Withdrawing...");
                            Console.WriteLine("Enter the Amount you want to Withdraw:");
                            string amountWithdrawStr = Console.ReadLine();
                            int amountWithdraw;

                            if (int.TryParse(amountWithdrawStr, out amountWithdraw))
                            {
                                if (amountWithdraw > balance)
                                {
                                    Console.WriteLine("Error: Withdrawal amount exceeds balance.");
                                }
                                else
                                {
                                    balance -= amountWithdraw;
                                    Console.WriteLine("You have successfully withdrawn " + amountWithdraw + ". Now your total balance left is " + balance + ".");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please enter a valid number.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Depositing...");
                            Console.WriteLine("Enter the Amount you want to Deposit:");
                            string amountDepositStr = Console.ReadLine();
                            int amountDeposit;

                            if (int.TryParse(amountDepositStr, out amountDeposit))
                            {
                                balance += amountDeposit;
                                Console.WriteLine("You have successfully deposited " + amountDeposit + ". Now your total balance is " + balance + ".");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please enter a valid number.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using Khatri Bank. Goodbye!");
                            return; // Exit the application
                        default:
                            Console.WriteLine("Invalid Service Number. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
