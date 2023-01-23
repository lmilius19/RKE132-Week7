Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBey();
}




static void PrintHello() //funktsion / method
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodBey()
{
    Console.WriteLine("See you later, aligator.");
}

Console.WriteLine("HelloWorld");








//test 7

//HelloWorld();

//static void HelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//---------------------------------------------------------------

//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}