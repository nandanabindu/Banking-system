using System;

namespace Banking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            float balD,balW,bal;
            
            void Operation(IBank obj){
                int ch;
                char proceed;
                do{
                 Console.WriteLine("Choose the operation \n 1. Deposit \n 2. Withdrawal \n 3. Balance Enquiry \n ");
                 ch = Convert.ToInt32(Console.ReadLine());
                
                switch(ch){
                case 1: Console.WriteLine("Enter amount to be deposited");
                        float amtDeposit = Convert.ToInt32(Console.ReadLine());
                        balD = obj.deposit(amtDeposit);
                        Console.WriteLine("{0} deposited successfully",balD);
                        break;
                case 2 : Console.WriteLine("Enter amount to be withdrawn");
                        float amtWithdraw = Convert.ToInt32(Console.ReadLine());
                        balW = obj.withdrawal(amtWithdraw);
                        if(balW == -1){
                             Console.WriteLine("Balance insufficient!!Please check your balance.");
                             break;
                        }
                        Console.WriteLine("{0} withdrawn successfully",amtWithdraw);
                        break;
                case 3 :bal = obj.getBalance();
                        Console.WriteLine(" Current Balance is {0}",bal);
                        break;
                 default:Console.WriteLine("Please enter a valid enquiry!!");
                        break;
                }
                Console.WriteLine("Do you want to perform another operation y/n");
                proceed = Convert.ToChar(Console.ReadLine());
                }while(proceed == 'y');
                
            }
            int choice;
            
            
             Console.WriteLine("Choose the account type \n 1. Savings Account \n 2. Current Account \n 3. Recurring Account \n ");
             choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1: IBank savings = new SavingsAccount();
                        Operation(savings);
                        break;
                case 2: IBank current = new CurrentAccount(); 
                        Operation(current);
                        break;
                case 3: IBank recurring = new RecurringAccount(); 
                        Operation(recurring);
                        break;
                default:Console.WriteLine("Account type does not exist");
                        break;
                
            }
        }
    }
}
