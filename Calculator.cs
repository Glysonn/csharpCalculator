using System;
namespace _CSharpCalculator
{
    class Calculator : Formulas
    {
        double num1, num2, result;
        public void Calc()
        {
            // new Option (enum) type variable. It also calls the menu() method
            Option escolhida = Menu.menu();
            // switch case to decide which operation must be done
            switch (escolhida)
            {
                case (Option.Addition):
                    Console.WriteLine($"You choose {escolhida}!\nPlease, enter your first nummber: ");
                    this.num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"You first number is {this.num1}!\nNow choose your second number: ");
                    this.num2 = Convert.ToDouble(Console.ReadLine());
                    this.result = addition(this.num1, this.num2);
                    Console.WriteLine($"The result of {this.num1}+{this.num2} is {this.result}");
                    break;

                case Option.Subtraction:
                    Console.WriteLine($"You choose {escolhida}!\nPlease, enter your first nummber: ");
                    this.num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"You first number is {this.num1}!\nNow choose your second number: ");
                    this.num2 = Convert.ToDouble(Console.ReadLine());
                    this.result = subtraction(this.num1, this.num2);
                    Console.WriteLine($"The result of {this.num1}-{this.num2} is {this.result}");
                    break;
                
                case Option.Multiplication:
                    Console.WriteLine($"You choose {escolhida}!\nPlease, enter your first nummber: ");
                    this.num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"You first number is {this.num1}!\nNow choose your second number: ");
                    this.num2 = Convert.ToDouble(Console.ReadLine());
                    this.result = multiplication(this.num1, this.num2);
                    Console.WriteLine($"The result of {this.num1}*{this.num2} is {this.result}");
                    break;
                
                case Option.Division:
                    Console.WriteLine($"You choose {escolhida}!\nPlease, enter your first nummber: ");
                    this.num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"You first number is {this.num1}!\nNow choose your second number: ");
                    this.num2 = Convert.ToDouble(Console.ReadLine());
                    this.result = division(this.num1, this.num2);
                    Console.WriteLine($"The result of {this.num1}/{this.num2} is {this.result}");
                    break;

                default:
                Console.WriteLine("The chosen option doesn't exists. Please try again!");
                break;
            }
        }
    }
}