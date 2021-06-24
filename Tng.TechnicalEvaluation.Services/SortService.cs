using System.Threading.Tasks;
using Tng.TechnicalEvaluation.Infrastructure.Services;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Tng.TechnicalEvaluation.Services
{
    public class SortService : ISortService
    {
        public string BubbleSort(string input)
        {
            var items = input.Split(',');

            for (int o = 0; o < items.Length - 1; o++)
            {
                for (int i = 0; i < items.Length - i - 1; i++)
                {
                    if (string.Compare(items[i], items[i + 1], System.StringComparison.InvariantCultureIgnoreCase) > 0)
                    {
                        var temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                    }

                    Debug.Print($"o={o}, i={i}");

                }
            }

            return string.Join(',', items);
        }

        public string SelectSort(string input)
        {
            string[] items = input.Split(',');
            var result = new List<string>();
            int itemsOriginalLength = items.Length;
            int selectedIndex = 0;

            while (result.Count() < itemsOriginalLength)
            {
                for (int i = 1; i < items.Length; i++)
                {
                    if (string.Compare(items[selectedIndex], items[i], System.StringComparison.InvariantCultureIgnoreCase) > 0)
                    {
                        selectedIndex = i;
                    }
                }
                result.Append(items[selectedIndex]);
                items = items.Except(result).ToArray();
            }

            return string.Join(',', items);
        }
    }
}