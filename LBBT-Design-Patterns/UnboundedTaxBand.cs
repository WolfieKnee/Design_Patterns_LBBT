namespace LBBT_Design_Patterns
{
    public class UnboundedTaxBand(double TaxRate, int LowerThreshold) : ITaxStrategy
    {
        private double Tax;

        public double TaxRate { get; set; } = TaxRate;
        public int LowerThreshold { get; set; } = LowerThreshold;

        public int ApplyTax(int Price)
        {
            if (Price < LowerThreshold)
            {
                return 0;
            }
            else
            {
                Tax = (Price - LowerThreshold) * TaxRate;
                return (int)Math.Ceiling(Tax);
            }
        }
    }
}