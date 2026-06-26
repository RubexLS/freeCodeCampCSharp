//CodeCampfree - Add Looping Logic to Your Code Using the do-while and while Statements in C#

//exercise 1---------------------------------------------------------------------------------------

int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10.");

do
{
    string? readValue = Console.ReadLine();
    validNumber = int.TryParse(readValue, out numericValue);
    if(validNumber == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }
    else
    {    
        if(numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            validNumber = false;
        }
    }
}while(validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");


//exercise 2---------------------------------------------------------------------------------------


bool validRole = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    string? roleInput = Console.ReadLine();
    if(roleInput == null)
    {
        Console.WriteLine($"The role name that you entered, \"{roleInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        continue;
    }
    else
    {
        string roleClean = roleInput.Trim().ToLower();
        if(roleClean != "administrator" && roleClean != "manager" && roleClean != "user")
            Console.WriteLine($"The role name that you entered, \"{roleClean}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            
        else
        {
            validRole = true;
            Console.WriteLine($"Your input value ({roleClean}) has been accepted.");
        }
    }
}while(validRole ==false);


//exercise 3---------------------------------------------------------------------------------------

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach(string x in myStrings)
{
    string myString = x;
    int periodLocation = myString.IndexOf('.'); 
    while(periodLocation != -1)
    {
        string result = myString.Substring(0, periodLocation);
        Console.WriteLine(result);
        myString = myString.Remove(0, periodLocation+1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf('.');
    }
    
    Console.WriteLine(myString);
}