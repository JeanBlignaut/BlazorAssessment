using System.Threading.Tasks;

namespace Tng.TechnicalEvaluation.Infrastructure.Services
{
    public interface ISortService
    {
        string BubbleSort(string input);
        string SelectSort(string input);
    }
}