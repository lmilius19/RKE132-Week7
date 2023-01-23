
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);



static void PrintAnyWord(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}




// test 7 
//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();
//GreetUser(userName);
//static void GreetUser (string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}