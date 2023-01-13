int numOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string day = Console.ReadLine();

double pricePerPerson = 0.0;
double totalPrice = 0.0;

if (typeOfGroup == "Students")
{
    if (day == "Friday")
    {
        pricePerPerson = 8.45;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 9.80;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 10.46;
    }

    totalPrice = numOfPeople * pricePerPerson;

    if (numOfPeople >= 30)
    {
        totalPrice -= totalPrice * 0.15;
    }
}
else if (typeOfGroup == "Business")
{
    if (day == "Friday")
    {
        pricePerPerson = 10.90;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 15.60;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 16;
    }

    totalPrice = numOfPeople * pricePerPerson;

    if (numOfPeople >= 100)
    {
        totalPrice = totalPrice - (10 * pricePerPerson);
    }
}
else if (typeOfGroup == "Regular")
{
    if (day == "Friday")
    {
        pricePerPerson = 15;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 20;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 22.50;
    }

    totalPrice = numOfPeople * pricePerPerson;

    if (numOfPeople >= 10 && numOfPeople <= 20)
    {
        totalPrice = totalPrice - (totalPrice * 0.05);
    }
}

Console.WriteLine($"Total price: {totalPrice:F2}");
