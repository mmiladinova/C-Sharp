int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int trashedHeadsets = lostGames / 2;
int trashedMouses = lostGames / 3;
int trashedKeyboards = lostGames / 6;
int trashedDisplays = trashedKeyboards / 2;

double totalPriseForTrashes = 0.0;

totalPriseForTrashes = (trashedHeadsets * headsetPrice) + (trashedMouses * mousePrice) + (trashedKeyboards * keyboardPrice) + (trashedDisplays * displayPrice);

Console.WriteLine($"Rage expenses: {totalPriseForTrashes:F2} lv.");



