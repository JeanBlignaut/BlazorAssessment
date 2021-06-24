using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tng.TechnicalEvaluation.Infrastructure.Contexts;
using Tng.TechnicalEvaluation.Infrastructure.Models;
using Tng.TechnicalEvaluation.Infrastructure.Services;

namespace Tng.TechnicalEvaluation.Services
{
    public class PartService : IPartService
    {
        private readonly BOMContext _context;

        public PartService(BOMContext context)
        {
            _context = context;
        }
    
        public async Task<IEnumerable<Part>> GetAllPartsAsync()
        {
            return await _context.Parts.ToListAsync();
        }

        public async Task<decimal> GetTotalCost(long partIndex)
        {
            //var part = await _context.Parts.FromSqlInterpolated("Create me a children CTE??");
            var part = await _context.Parts.FindAsync(partIndex);

            return await GetChildCost(part);
        }

        private async Task<decimal> GetChildCost(Part part)
        {
            _context.Entry(part).Collection(e => e.Children).Query().Load();

            var children = await Task.WhenAll(part.Children.Select(async childPart => (childPart.Cost + await GetChildCost(childPart)) * childPart.Quantity));

            return children.Any() ? children.Sum() : 0;
        }
    }
}