interface IFormulas
{
    // ADDITION method
    abstract double addition(double num1, double num2);
    // SUBTRACTION method
    abstract double subtraction(double num1, double num2);
    // MULTIPLICATION method
    abstract double multiplication(double num1, double num2);
    // DIVISION method
    abstract double division(double num1, double num2);
}

class Formulas : IFormulas
{
    // making the interface method ADDITION body
    public double addition(double num1, double num2)
    {
        return (num1 + num2);
    }

    // making the interface method SUBTRACTION body
    public double subtraction(double num1, double num2)
    {
        return (num1 - num2);
    }

    // making the interface method MULTIPLICATION body
    public double multiplication(double num1, double num2)
    {
        return (num1 * num2);
    }

    // making the interface method DIVISION body
    public double division(double num1, double num2)
    {
        return (num1 / num2);
    }
}