using MRF.Models;

namespace MRF.Data.Services
{
    public interface IFareCalculatorService
    {
        decimal Calculate(TaxiRate taxRate);
    }
}