string choice = "";
bool getMenu = true;
while (getMenu != false)
{
    System.Console.WriteLine("View Full Triangle - Enter 1 / View Partial Triangle - Enter 2 / Enter 3 - Exit Menu");
    choice = Console.ReadLine();
    switch(choice)
    {
        case "1":
            GetFull();
            getMenu = true;
            break;
        case "2":
            GetPartial();
            getMenu = true;
            break;

        case "3":
            getMenu = false;
            break;

        default: 
            Invalid();
            getMenu = true;
            break;
    }
}

static void GetFull()
{
    Console.Clear();
    Random row = new Random();
    int rowAmt = row.Next(3, 10);
    for(int j=0; j < rowAmt; j++)
    {
        for(int i=0; i<=j; i++)
        {
            Console.Write("0");
        }
    }
    ReturnMenu();
}

static void GetPartial()
{
    Console.Clear();
    Random row = new Random();
    int rowAmt = row.Next(3,10);
    for(int j=0; j<rowAmt; j++)
    {
        for(int i=0; i<=j; i++)
        {
            Random missing = new Random();
            int spot = missing.Next(2);
            if(spot==1)
            {
                System.Console.Write("0");
            }
            else Console.Write(" ");
        }
        System.Console.WriteLine();
    }
    ReturnMenu();
}

static void Invalid()
{
    System.Console.WriteLine("Invalid entry");
    ReturnMenu();
}

static void ReturnMenu()
{
    Console.Clear();
    System.Console.WriteLine("Press any key to return to menu");
    Console.ReadKey();

}

