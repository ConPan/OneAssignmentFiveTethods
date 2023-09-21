// See https://aka.ms/new-console-template for more information

string? MyFirstMethod() 
{
    Console.WriteLine("Enter a name, please!");
    string userInput = Console.ReadLine();
    return userInput;
}


string? MySecondMethod()
{
    Console.WriteLine("Enter a word, please!");
    string userInput = Console.ReadLine();
    return ("#" + userInput);
}


string? MyThirdMethod(string message)
{
    Console.WriteLine(message);
    string userInput = Console.ReadLine();
    return userInput;
}


string? MyFourthMethod(string word)
{
    Console.WriteLine($"Please enter a {word}");
    string userInput = Console.ReadLine();
    return userInput;
}

string? MyFifthMethod(string firstName, string lastName)
{
    string userInputFullName = (lastName + ", " + firstName);
    return userInputFullName;
}


Console.WriteLine("userInput: " + MyFirstMethod());
Console.WriteLine(MySecondMethod());
Console.WriteLine(MyThirdMethod("Please enter a number"));
Console.WriteLine(MyFourthMethod("number"));

Console.WriteLine("Please enter your first name");
string userInputFirstName = Console.ReadLine();
Console.WriteLine("Please enter your last name");
string userInputLastName = Console.ReadLine();
Console.WriteLine(MyFifthMethod(userInputFirstName, userInputLastName));


