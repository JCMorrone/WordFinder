using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WordFinderChallenge.Extensions;

namespace WordFinderChallenge
{
    public class WordFinder
    {
        public IEnumerable<string> horizontalMatrix;

        public IEnumerable<string> verticalMatrix;

        public IEnumerable<string> fullDuplicatedMatrix;
        
        public WordFinder(IEnumerable<string> matrix)
        {
            horizontalMatrix = matrix;
            verticalMatrix = matrix.Pivot().Select(x => string.Concat(x));
            fullDuplicatedMatrix = horizontalMatrix.Concat(verticalMatrix);
        }

        public IEnumerable<string> Find(IEnumerable<string> wordStream)
        {
            var foundValues = wordStream.Distinct().Select(src => new KeyValuePair<string, int>(src, fullDuplicatedMatrix.Select(mtrx => Regex.Matches(mtrx, src, RegexOptions.IgnoreCase).Count).Sum()));
            return foundValues.Where(x => x.Value > 0).OrderByDescending(x => x.Value).Select(y => y.Key);
        }
    }
}
