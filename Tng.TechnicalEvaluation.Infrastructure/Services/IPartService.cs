using System.Collections.Generic;
using System.Threading.Tasks;
using Tng.TechnicalEvaluation.Infrastructure.Models;

namespace Tng.TechnicalEvaluation.Infrastructure.Services
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetAllPartsAsync();

        Task<decimal> GetTotalCost(long partIndex, int amount = 1);
    }
}