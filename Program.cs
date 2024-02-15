namespace FactorialC_;

/// <summary>
/// This program tells the user the factorial of a number they provide.
/// Written in C# using VSCode and the C# Dev Kit.  
/// .NET SDK was installed on Mac using 'brew install dotnet'.
/// By Jimmy Shultz - 1/20/2024
/// </summary>
class Program
{
    /// <summary>
    /// The main function calls the Factorial function
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Factorial();
    }

    /// <summary>
    /// This method asks the user for a positive integer as input in the terminal 
    /// and the writes the factorial of that number back to the user in the terminal.
    /// </summary>
    static void Factorial()
    {
        //intializing a variable to hold the user's input when coverted to an integer and a flag for the while loop
        int convertedNumber = -1;
        var flag = false;

        //asking the user for input
        Console.WriteLine("Enter a positive integer: ");

        //ensuring we get proper input, by not accepting anything other than 0 or postive integers
        while (flag == false) {
            string? userInput = Console.ReadLine();
    
            if (int.TryParse(userInput, out convertedNumber)) 
            {
                if (convertedNumber < 0) 
                {
                    Console.WriteLine("Sorry, that's negative. Enter a positive integer: ");
                } 
                else 
                {
                    flag = true;
                }
            } 
            else 
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }

        //calculating the factorial and displaying to the user
        if (convertedNumber == 0) 
        {
            Console.WriteLine("The factorial of 0 is 1");
        } 
        else 
        {
            int factorialOfUserInput = 1;
            for (int i = 1; i < convertedNumber+1; i++) 
            {
                factorialOfUserInput *= i;
            }
            Console.WriteLine("The factorial of " + convertedNumber + " is " + factorialOfUserInput + ".");
        }
    }
}
