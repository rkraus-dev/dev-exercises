public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Add(double a, double b, int decimals)
    {
        return Math.Round(a + b, decimals);
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Subtract(double a, double b, int decimals)
    {
        return Math.Round(a - b, decimals);
    }

}
