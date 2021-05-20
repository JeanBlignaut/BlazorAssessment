using System.Collections.Generic;
using System.Threading.Tasks;
using Tng.TechnicalEvaluation.Infrastructure.Models;

namespace Tng.TechnicalEvaluation.Infrastructure.Services
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetAllPartsAsync();
        //TODO: Add your own methods here
    }
}