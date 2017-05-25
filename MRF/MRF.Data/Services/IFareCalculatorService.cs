using MRF.Models;

namespace MRF.Data.Services
{
    public interface IFareCalculatorService
    {
        decimal Calculate(RideHistory taxRate);
    }
}