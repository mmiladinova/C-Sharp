int number = int.Parse(Console.ReadLine());

int firstNum = number;
int smallFactSum = 1;
int factSum = 0;
int fact = 1;

while (number > 0)
{
    fact = number % 10;

    while (fact > 0)
    {
        smallFactSum *= fact;
        fact--;
    }
    factSum += smallFactSum;
    smallFactSum = 1;

    number /= 10;
}

if (firstNum == factSum)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}