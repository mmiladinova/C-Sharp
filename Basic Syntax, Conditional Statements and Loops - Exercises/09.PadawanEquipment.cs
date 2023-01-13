double budget = double.Parse(Console.ReadLine()); 
int studentsCount = int.Parse(Console.ReadLine());  
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double totalPrice = 0;
int additionalLightsaber = (int)Math.Ceiling(studentsCount * 0.10);
double additionaSabberPrice = additionalLightsaber * lightsaberPrice;
int additionalBelts = studentsCount / 6;
double discountBeltPrice = additionalBelts * beltPrice;

totalPrice = (studentsCount * lightsaberPrice) + additionaSabberPrice + (studentsCount * robePrice) + (studentsCount * beltPrice) - discountBeltPrice;

if (budget - totalPrice >= 0)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {(totalPrice - budget):F2}lv more.");
}

