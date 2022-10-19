using System;
class Program;
{
    public static void Main();
    {
        int amount = 10000, deposit, withdraw;
        int choice, pin = 0, x = 0;
        Console.WriteLine("Enter your pin number: ");
        int = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Welcome to the ATM Machine");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your choice:");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("Your balance is: {0}", amount);
                break;

                case 2:
                Console.WriteLine("Enter the amount to withdraw: ");
                withdraw = int.Parse(Console.ReadLine());
                if ( withdraw %100 != 0)
                {
                    Console.WriteLine("Pleas enter amount in multiple to 100");
                }
                else if (withdraw > (amount - 500))
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                amount = amount - withdraw;
                Console.WriteLine("Please collect your cash");
                Console.WriteLine("Your balance is: {0}", amount)
                }
                break;

                case 3:
                Console.WriteLine("Enter the amount to deposit:");
                deposit = int.Parse(Console.Readline());
                amount = amount + deposit;
                Console.WriteLine("Your current balance is: {0}", amount);
                break;

                case 4:
                Console.WriteLine("Thank you for using the ATM");
                break;
            }
        }
        Console.WriteLine("Thank you for using the ATM service");
    }
}
