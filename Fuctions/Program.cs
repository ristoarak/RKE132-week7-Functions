
Console.WriteLine("Are you coming orleaving? ( in/out)");
String userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}



static void PrintHello()//funktion
{
    Console.WriteLine("Hello,World!");
}
static void PrintGoodBye()
{
    Console.WriteLine(" See you later, aligator.");
}


