namespace Calculator.Interfaces
{
    public interface ICalculatorService<T>
    {
        T Add(T a, T b);
       
        double SquareRoot(double a);
        
    }
}
