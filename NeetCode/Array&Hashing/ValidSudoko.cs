public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<string, HashSet<char>> squares = new Dictionary<string, HashSet<char>>();

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {   
                char val=board[r][c];
                if(val=='.') continue ;
                string squarekey=(r/3)+","+(c/3);

                if(!rows.ContainsKey(r)) rows[r]=new HashSet<char>();
                if(!cols.ContainsKey(c)) cols[c]=new HashSet<char>();
                if(!squares.ContainsKey(squarekey)) squares[squarekey]=new HashSet<char>();
               
                if(rows[r].Contains(val)||cols[c].Contains(val)||squares[squarekey].Contains(val))
                {
                    return false;
                } 
                rows[r].Add(val);
                cols[c].Add(val);
                squares[squarekey].Add(val);

            }
        }
        return true;
    }
}