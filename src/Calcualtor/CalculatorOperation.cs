namespace Calcualtor
{
    public class CalculatorOperation
    {
        public CalculatorOperation()
        {
        }

        public CalculatorOperation(int numberA, int numberB)
        {
            NumberA = numberA;  
            NumberB = numberB;
        }

        public int NumberA { get; set; }
        public int NumberB { get; set; }
        
        public int Addition()
        {
            return NumberA + NumberB;
        }
        public int Subtraction()
        {
            return NumberA - NumberB;
        }
        public int Multiplication()
        {
            return NumberA * NumberB;
        }
    }
}