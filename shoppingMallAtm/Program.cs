//if (args.Length > 0)
//{
//    if (args[0] == "kiosk")
//    {

//        Console.WriteLine("Your building a kiosk");
//    }
//    else if (args[0] == "atm")
//        Console.WriteLine("Your building a atm");
//}
//else
//    Console.WriteLine("Something went wrong!");

static void Atm()
{
    static int status()
    {
        Random random = new Random();
        int status = random.Next(0, 100);
        return status;
    }
    int accstatus = status();

    static double balance()
    {
        Random random = new Random();
        double balance = random.Next( -10, 10000000);

        //Console.WriteLine(balance);
        return balance;
    }
    double accountBal = balance();

    static double AccountStatus(double balance, int status)
    {
        if (balance > 0 && status > 0)
        {
            return balance;
        }
        else if (status == 0)
        {
            Console.WriteLine("Ýour account is locked!");
            return status;
            
        }
        else if (balance == 0)
        {
            Console.WriteLine("Your account is empty");
            return balance;
        }
        else 
        { 
            Console.WriteLine("Your account is negative");
            return balance;
        }
    }
        
    double yourAccountStat = AccountStatus(accountBal, accstatus);
        
    Console.WriteLine("Do you want to check the balance of your account(Yes/No)?");
    string? answer = Console.ReadLine();
    if (answer.ToLower() == "yes")
    {
        Console.WriteLine("Your balance is:{0:C}", yourAccountStat);
    }
 
    else if (answer.ToLower() == "no")
    {
        Console.WriteLine("Goodbye!");
    }
         
    else
    {
        Console.WriteLine("Something went wrong!");
    }
}
Atm();