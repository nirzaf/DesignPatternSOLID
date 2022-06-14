namespace DesignPatternSOLID._3.L.Problem
{
    public class AdditionCalculation
    {
        public AdditionCalculation(int numberA, int numberB)
        {
            NumberB = numberB;
            NumberA = numberA;
        }
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public virtual int Calculate()
        {
            return NumberA + NumberB;
        }
    }
    public class SubtractionCalculation : AdditionCalculation
    {
        public SubtractionCalculation(int numberA, int numberB) : base(numberA, numberB)
        {
        }

        public new int Calculate()
        {
            return NumberA - NumberB;
        }
    }
}
