int receivedOrders = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int order = 1; order <= receivedOrders; order++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double price = (days * capsulesCount) * pricePerCapsule;
    totalPrice += price;

    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}

Console.WriteLine($"Total: ${totalPrice:F2}");