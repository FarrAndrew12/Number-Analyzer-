public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey what is your name?");
        Console.WriteLine();
        string name = Console.ReadLine();
        bool continueLoop = true;
        int number = 0;

        while (continueLoop)
        {
            while (true)  
                //this will only continue to the next part of the loop if the number entered meets the requirement of the condition
                //otherwise it will ask for a valid integer 
            {
                Console.WriteLine("Hello " + name + " please enter an integer between 1 and 100");
                int enteredInteger = int.Parse(Console.ReadLine());

                number = enteredInteger;

                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine("Okay " + name + " your number is " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry " + name + " please try again");
                }
            }
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number you entered is even");
                }
                else
                {
                    Console.WriteLine("The number you entered is odd");
                }
                if (number % 2 != 0 && number < 60)
                {
                    Console.WriteLine("and less than 60");
                }
                else if (number % 2 == 0 && number < 25)
                {
                    Console.WriteLine("and less than 25");
                }
                else if (number % 2 == 0 && number <= 60)
                {
                    Console.WriteLine("and between 26 and 60 inclusive");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine("and greater than 60");
                }
                else if (number % 2 != 0 && number > 60)
                {
                    Console.WriteLine("and greater than 60");
                }
                
   
            
            Console.WriteLine(name + " would you like to run this again? Press y to continue:");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "y")
            {
                Console.WriteLine("Not a problem :)");
     
            }
            else
            {
                Console.WriteLine("You are now exiting the program. Have a nice day!");
                
                break;
            }
        }
    }
}