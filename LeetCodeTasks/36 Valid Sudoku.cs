using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _36_Valid_Sudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            
            for(var i = 0; i < 9; i++)
            {
                int[] ints = new int[10];
                for(var j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.') 
                    {
                        ints[(int)board[i][j]]++;
                        if ((int)board[i][j] > 1) return false;
                    }
                }
                    
            }
            for (var i = 0; i < 9; i++)
            {
                int[] ints = new int[10];
                for (var j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        ints[(int)board[j][i]]++;
                        if (board[j][i] > 1) return false;
                    }
                }
            }
            return true;
            
        }
        public static void Main()
        {
            string[][] input =
            {
                new string[] {"5", "3", ".", ".", "7", ".", ".", ".", "." },
                 new string[] {"6", ".", ".", "1", "9", "5", ".", ".", "." },
                 new string[] {".", "9", "8", ".", ".", ".", ".", "6", "." },
                 new string[] {"8", ".", ".", ".", "6", ".", ".", ".", "3" },
                 new string[] {"4", ".", ".", "8", ".", "3", ".", ".", "1" },
                 new string[] {"7", ".", ".", ".", "2", ".", ".", ".", "6" },
                 new string[] {".", "6", ".", ".", ".", ".", "2", "8", "." },
                 new string[] {".", ".", ".", "4", "1", "9", ".", ".", "5" },
                 new string[] {".", ".", ".", ".", "8", ".", ".", "7", "9" }
            };
        }
    }
}
