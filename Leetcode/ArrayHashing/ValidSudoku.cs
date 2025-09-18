using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char> rows = new HashSet<char>();
            HashSet<char> columns = new HashSet<char>();
            HashSet<char> boxes = new HashSet<char>();

            for (int i = 0; i< board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!rows.Add(board[i][j])) return false;
                    }
                    if (board[j][i] != '.')
                    {
                        if (!columns.Add(board[j][i])) return false;
                    }
                    if (board[i / 3 * 3 + j / 3][i % 3 * 3 + j % 3] != '.')
                    {
                        if (!boxes.Add(board[i / 3 * 3 + j / 3][i % 3 * 3 + j % 3])) return false;

                    }
                }
                rows.Clear();
                columns.Clear();
                boxes.Clear();
            }
            return true;
        }       
    }
}
