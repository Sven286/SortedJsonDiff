using System;
using System.Collections.Generic;

namespace SortedJsonDiff
{
    public static class MyersDiffAlgorithm
    {
        public static List<DiffResult> Compute(List<string> original, List<string> revised)
        {
            int[,] matrix = new int[original.Count + 1, revised.Count + 1];
            List<DiffResult> diffResults = new List<DiffResult>();

            for (int i = 0; i <= original.Count; i++)
            {
                matrix[i, 0] = i;
            }

            for (int j = 0; j <= revised.Count; j++)
            {
                matrix[0, j] = j;
            }

            for (int i = 1; i <= original.Count; i++)
            {
                for (int j = 1; j <= revised.Count; j++)
                {
                    if (original[i - 1] == revised[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = 1 + Math.Min(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            int row = original.Count;
            int col = revised.Count;

            while (row > 0 || col > 0)
            {
                if (row > 0 && col > 0 && original[row - 1] == revised[col - 1])
                {
                    diffResults.Insert(0, new DiffResult { Status = DiffStatus.Common, Elements = new List<string> { original[row - 1] } });
                    row--;
                    col--;
                }
                else if (col > 0 && (row == 0 || matrix[row, col - 1] <= matrix[row - 1, col]))
                {
                    diffResults.Insert(0, new DiffResult { Status = DiffStatus.Added, Elements = new List<string> { revised[col - 1] } });
                    col--;
                }
                else if (row > 0 && (col == 0 || matrix[row, col - 1] > matrix[row - 1, col]))
                {
                    diffResults.Insert(0, new DiffResult { Status = DiffStatus.Deleted, Elements = new List<string> { original[row - 1] } });
                    row--;
                }
            }

            return diffResults;
        }
    }
}

