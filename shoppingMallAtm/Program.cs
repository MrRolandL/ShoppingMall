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

static int SelectOption()
{
    Console.WriteLine("Please select what you want do do?\n1: Buy products (type 1)\n2: Buy a lottery(type 2)\n3: Buy products and a lottery(type 3)\n4: Quit program(type 4)");
    int customerOption = Int32.Parse(Console.ReadLine());
    
    if (customerOption == 1) 
    {
        Console.WriteLine("You chose to buy products");
        return customerOption;

    }
    else if (customerOption == 2) 
    {
        Console.WriteLine("You chose to buy a lottery ticket");
        return customerOption;

    }
    else if (customerOption == 3) 
    { 
        Console.WriteLine("You chose to buy products and a lottery ticket");
        return customerOption;
    }
     
     
    Console.WriteLine("Invalid input! Program closes!");
    return 0;
    
}
SelectOption();


static List <string> BuyAProduct()
{
    string[,] productList =     
    {
        {"1:Banana", "Banana", "1.24"},
        {"2:Apple", "Apple", "0.57" },
        {"3:Cigarettes", "Cigarettes", "10.8"},
        {"4:Milk", "Milk", "2.32"},
        {"5:Ryebread", "Ryebread", "1.45"},
        {"6:Meat", "Meat", "5.76"},
        {"7:Beer", "Beer", "4.95"},
        {"8:Butter", "Butter", "2.75"},
        {"9:Outmeal", "Outmeal", "0.95" },
        {"10:Cheese", "Cheese", "8.88"} 
    };

    int choice;
    string product, price, productWithPrice; 
    
    List<string> basket = new List<string>();
    
    do
    {
        Console.WriteLine("Select a product from list or type 0 if your done");
        Console.WriteLine("Choose what to buy from list:");

        for (int i = 0; i < productList.GetLength(0); i++)
            Console.WriteLine("| {0}\t  {1} EUR\t", productList[i, 0], productList[i, 2]);
        choice = Int32.Parse(Console.ReadLine()) - 1;
        
        if (choice == -1)
            break;
        else 
        {
            product = productList[choice, 1];
            price = productList[choice, 2];
            productWithPrice = product;
            int len = 18 - product.Length;
            for (int i = 0; i < len; i++)
            {
                productWithPrice += " ";
            }
            productWithPrice +=  price + " EUR";
            basket.Add(productWithPrice + "\n");
            Console.WriteLine($"Added following products to basket:\n'{productWithPrice}'");
        }    
    }
    while (choice != -1);
    return basket;
}

List <string> selectedProducts = BuyAProduct();
static void SaveShoppinglistToFile(List <string> selectedProducts)
{

    StreamWriter sw = new StreamWriter("c:\\temp\\shoppinglist.txt");
    foreach (string item in selectedProducts)
    {
        sw.Write(item);
    }
    sw.Close();
}
SaveShoppinglistToFile(selectedProducts);



static void ReadLotteryAndProductFile()
{
    StreamReader sr = new StreamReader("c:\\temp\\shoppinglist.txt");
    string values;

    while (sr.EndOfStream == false)
    {
        values = sr.ReadLine();
        Console.WriteLine(values);
    }
    sr.Close();

}
ReadLotteryAndProductFile();

//static void Print()
//{
//    Double.Parse(Console.WriteLine(values));
//}




//static void Randomstuff()
//{
//    int chart = Int32.Parse(Console.ReadLine());
//    if (chart <= 0)
//    {
//        return 0;
//    }
//    else if (chart == 1)
//    {
//        return chart;
//    }

//    else if (chart == 2)
//    {
//        return chart;
//    }
//    else if (chart == 3)
//    {
//        return chart;
//    }
//    else if (chart == 4)
//    {
//        return chart;
//    }
//    else
//    {
//        Console.WriteLine("We only have 4 bananas left, do you want to have them? (yes/no)");
//        string want4BananasOrWhat = Console.ReadLine().ToLower();
//        if (want4BananasOrWhat == "yes")
//        {
//            return 4;
//        }
//        else if (want4BananasOrWhat == "no")
//        {
//            Console.WriteLine("Do you wish to have less than 4 bananas?");
//        }
//        string askForLessBanana = Console.ReadLine();
//        if (askForLessBanana == "yes")
//        {
//            Console.WriteLine("How many do you wish to have?");

//            int newBananaOrder = Int32.Parse(Console.ReadLine());
//            if (newBananaOrder == 3)
//            {
//                return 3;
//            }
//            else if (newBananaOrder == 2)
//            {
//                return 2;
//            }
//            else if (newBananaOrder == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                return 0;
//            }
//        }
//        else if (askForLessBanana == "no")
//        {
//            return 4;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//}
//Randomstuff();