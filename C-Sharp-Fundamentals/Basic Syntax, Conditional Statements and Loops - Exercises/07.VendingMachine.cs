string input = Console.ReadLine();

double totalMoney = 0;
double price = 0;

while (true)
{
    if (input == "Start")
    {
        break;
    }
    else
    {
        double inputSum = double.Parse(input);
        if (inputSum == 0.1 || inputSum == 0.2 || inputSum == 0.5 || inputSum == 1 || inputSum == 2)
        {
            totalMoney += inputSum;
        }
        else
        {
            Console.WriteLine($"Cannot accept {inputSum}");
        }
    }
    input = Console.ReadLine();
}

while (true)
{
    if (input == "Start")
    {
        input = Console.ReadLine();
        continue;
    }
    if (input == "End")
    {
        Console.WriteLine($"Change: {totalMoney:F2}");
        break;
    }
    else
    {
        if (input == "Nuts")
        {
            price = 2.0;
            if (totalMoney - price >= 0)
            {
                totalMoney -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (input == "Water")
        {
            price = 0.7;
            if (totalMoney - price >= 0)
            {
                totalMoney -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (input == "Crisps")
        {
            price = 1.5;
            if (totalMoney - price >= 0)
            {
                totalMoney -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (input == "Soda")
        {
            price = 0.8;
            if (totalMoney - price >= 0)
            {
                totalMoney -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (input == "Coke")
        {
            price = 1.0;
            if (totalMoney - price >= 0)
            {
                totalMoney -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else
        {
            Console.WriteLine("Invalid product");
        }
    }
    input = Console.ReadLine();
}
