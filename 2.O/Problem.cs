namespace DesignPatternSOLID._2.O
{
    //here we have a class does math calculation with 3 operations, how would we do if need to include others?
    public class MathCalculate
    {
        public double Calculate(double numberA, double numberB, CalculationType calculationType)
        {
            double result = 0;
            switch (calculationType)
            {
                case CalculationType.Addition:
                    result = numberA + numberB;
                    break;
                case CalculationType.Multiplication:
                    result = numberA * numberB;
                    break;
                case CalculationType.Subtraction:
                    result = numberA - numberB;
                    break;
            }
            return result;
        }
    }

    public enum CalculationType
    {
        Addition,
        Multiplication,
        Subtraction
    }
}
