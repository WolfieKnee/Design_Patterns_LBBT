namespace LBBT_Design_Patterns
{
    internal interface ITaxCalculator
    {
        /// <summary>
        ///   Applies the tax bands for this instance to calculate the tax for the specified amount.
        /// </summary>
        /// <param name="price">
        ///   The value to be taxed.
        /// </param>
        /// <returns>
        ///   Total tax calculated.
        /// </returns>
        int CalculateTotalTax(int price);
    }
}