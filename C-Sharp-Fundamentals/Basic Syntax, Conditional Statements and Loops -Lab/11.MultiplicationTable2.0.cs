int num = int.Parse(Console.ReadLine());
int multiplier = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
    multiplier += 1;
} while (multiplier <= 10);

//if (multiplier > 10)
//{
//    Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
//}
//else
//{
//    for (int i = multiplier; i <= 10; i++)
//    {
//        Console.WriteLine($"{num} X {i} = {num * i}");
//    }
//}

