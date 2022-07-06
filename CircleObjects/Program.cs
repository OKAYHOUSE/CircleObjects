//CircleObjects
using CircleObjects;

Console.WriteLine("Welcome to Circle Objects!");

int entryCount = 0;

//Program loop.
bool RunAgain = true;
while (RunAgain)
{
    //Validate data entry.
    try
    {
        //Ask for user input.
        Console.Write("Please enter a radius: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());

        //Call in the methods.
        Circle myCircle = new Circle(circleRadius);

        //Count number of input per user.
        entryCount++;

        //Display circumference and area.
        Console.WriteLine("\nCircumference: " + myCircle.CalculateCircumference());
        Console.WriteLine("\nArea: " + myCircle.CalculateArea());
    }
    catch (Exception e)
    {
        Console.WriteLine("Invalid entry, please try again using a number.");

    }

    //Loop to continue.
    while (true)
    {
        Console.Write("\nWould you like to go again? y/n ");
        string response = Console.ReadLine().ToLower().Trim();
        if (response == "y")
        {
            break;
        }
        else if (response == "n")
        {
            Console.WriteLine($"Goodbye. You created {entryCount} Circle object(s)!");
            RunAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, Please try again");
        }
    }
 
}