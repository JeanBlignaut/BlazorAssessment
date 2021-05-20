using System.Collections.Generic;
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
    }
}