//total < 10 - 1%
//total >= 10 && total < 20 - 5%
//total >=20 - 10%



Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}





////test 7

//Console.WriteLine("How many steps have you walked today?");
//int usersSteps = Int32.Parse(Console.ReadLine());

//double result = HealthMonitor(usersSteps);

//Console.WriteLine($"Your result is: {result} steps");

//static double HealthMonitor(int steps)
//{
//    if (steps < 4000)
//    {
//        return "You need to move more.";
//    }
//    else if (steps >= 4000 && steps < 8000)
//    {
//        return "Health goal achieved!";
//    }
//    else
//    {
//        return "Well done!";
//    }
//}

