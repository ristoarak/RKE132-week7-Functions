﻿

Console.WriteLine("Provide total: ");

int userInput = Int32.Parse(Console.ReadLine());
double discount = CaclulateDiscount(userInput);
Console.WriteLine($"Your discount is :{discount} %");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updateted total with {discount}%: {newTotal}");

static double CaclulateDiscount(int total)
    {
    if(total < 10)
    {
        return 1;
    }
    else if (total >=10 && total < 20)
    {
        return 5;
    }
    else
    { return 10; }

}


static double CalculateNewTotal(double total,double discount)
{
double result = total - (discount * total) / 100;
    return result;
}