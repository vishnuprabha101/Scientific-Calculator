namespace Calculator.Interfaces
{
    public interface ICalculatorService<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
         T Multiply(T a, T b);
        double SquareRoot(double a);
        double Power(double baseValue, double exponent);
        double Percentage(double total, double percentage);
    }
}
