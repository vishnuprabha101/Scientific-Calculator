using Calculator.Interfaces;

namespace Calculator.Services
{
    public class CalculatorService : ICalculatorService<int>
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;
       
        public int Multiply(int a, int b) => a * b;
        
        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public double SquareRoot(double a)
        {
            if (a < 0) throw new ArgumentOutOfRangeException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(a);
        }

        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);

        public double Percentage(double total, double percentage) => (total * percentage) / 100;

        public double Exponent(double x) => Math.Exp(x);
         public int Modulus(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a % b;
        }

        

    }   
    
}
