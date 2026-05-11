namespace CalculatorLibrary
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            long result = (long)start + amount;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException("Integer overflow occurred.");
            }

            return (int)result;
        }

        public int Subtract(int start, int amount)
        {
            long result = (long)start - amount;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException("Integer overflow occurred.");
            }

            return (int)result;
        }
    }
}