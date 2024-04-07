
Console.WriteLine(" Enter the operation ( +/-)");
char userOperator =  char.Parse(Console.ReadLine());

Console.WriteLine("Entere a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Entere b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch(userOperator)
{
    case '+':
        Addition(firstNum,secondNum);
        break;
    case '-':
        Subbtraction(firstNum,secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a+b} ");
}

static void Subbtraction ( int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b} ");
}
