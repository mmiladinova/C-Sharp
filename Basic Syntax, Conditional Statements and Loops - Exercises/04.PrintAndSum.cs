int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

int sum = 0;

while (startNum <= endNum)
{
    Console.Write(startNum + " ");
    sum += startNum;
    startNum++;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
