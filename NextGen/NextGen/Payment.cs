namespace NextGen
{
    public class Payment
    {
        public double amount { get; }

        public Payment(double cashtendered)
        {
            amount = cashtendered;
        }
    }
}