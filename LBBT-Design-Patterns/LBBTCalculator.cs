using System.Collections.Concurrent;

namespace LBBT_Design_Patterns;

/// <summary>
///   Tax calculator using tax bands with rates.
/// </summary>
/// <param name="taxStrategies">
///   Tax strategies to use in calculations,
///   or will use default strategies specified in <see cref="CreateDefaultStrategies"/> if null.
/// </param>
public class LBBTCalculator(IList<ITaxStrategy>? taxStrategies = null) : ITaxCalculator
{
    private readonly IList<ITaxStrategy> _taxBands = taxStrategies ?? CreateDefaultStrategies();
    private ConcurrentBag<int> _taxCalculationResults = [];
    private List<Thread> _threadStore = [];

    private static IList<ITaxStrategy> CreateDefaultStrategies()
    {
        TaxBand taxBand2Pc = new(0.02, 145001, 250000);
        TaxBand taxBand5Pc = new(0.05, 250001, 325000);
        TaxBand taxBand10Pc = new(0.10, 325001, 750000);
        TaxBand taxBand12Pc = new(0.12, 750001);
        return
        [
            taxBand2Pc,
            taxBand5Pc,
            taxBand10Pc,
            taxBand12Pc
        ];
    }

    private int ApplyTaxBands(int price)
    {
        // Create a new thread for each taxStrategy
        foreach (var taxBand in _taxBands)
        {
            _threadStore.Add(new Thread(() => taxBand.ApplyTax(price, _taxCalculationResults)));
        }

        // Start all the threads
        foreach (var thread in _threadStore)
        {
            thread.Start();
        }

        // Bring the threads back here after 1s - this is blocking
        foreach (var thread in _threadStore)
        {
            thread.Join(millisecondsTimeout: 1000);
        }

        var summedResults = _taxCalculationResults.Sum();

        _threadStore = [];
        _taxCalculationResults = [];

        return summedResults;
    }

    public int CalculateTotalTax(int price)
    {
        var totalTax = ApplyTaxBands(price);
        return totalTax;
    }
}