namespace LBBT_Design_Patterns
{
    internal interface ILBBTCalculator
    {
        int TotalTax { get; }

        int CalculateTotalTax(int price);
    }
}