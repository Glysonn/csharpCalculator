namespace _CSharpCalculator
{
    // enum with options, so i can work with switch. This enum must start by number one
    public enum Option { Addition = 1, Subtraction, Multiplication, Division };
    public static class Menu
    {
        public static void menu()
        {
            Console.WriteLine("Welcome to my calculator. Choose one of the options below: ");
            Console.WriteLine("1- Addition\n2- Subtraction\n3- Multiplication\n4- Division");
            // recieving the user input (it reads as string) and converting to an integer type
            int index = Convert.ToInt32(Console.ReadLine());
            // the enum Option variable (chosenOption) convert the input (now an integer type) to the enum Option type, then recieve its value
            Option chosenOption = (Option)index;
            switch (chosenOption)
            {
                case Option.Addition:
                    Console.WriteLine($"You choose {chosenOption}");
                    break;

                case Option.Subtraction:
                    Console.WriteLine($"You choose {chosenOption}");
                    break;

                case Option.Multiplication:
                    Console.WriteLine($"You choose {chosenOption}");
                    break;

                case Option.Division:
                    Console.WriteLine($"You choose {chosenOption}");
                    break;

                default:
                    Console.WriteLine("You choose an invalid option! Please try again");
                    break;
            }
        }
    }
}