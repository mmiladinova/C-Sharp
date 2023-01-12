int num = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= num; i++)
{
    int oddNum = i * 2 - 1;
    Console.WriteLine(oddNum);
    sum += oddNum;
}
Console.WriteLine($"Sum: {sum}");
