// Last updated: 5/1/2026, 11:36:48 PM
// fff
1public class Solution {
2    private int ROWS, COLS;
3
4    public bool Exist(char[][] board, string word) {
5        ROWS = board.Length;
6        COLS = board[0].Length;
7
8        for (int r = 0; r < ROWS; r++) {
9            for (int c = 0; c < COLS; c++) {
10                if (Dfs(board, word, r, c, 0)) {
11                    return true;
12                }
13            }
14        }
15        return false;
16    }
17
18    private bool Dfs(char[][] board, string word, int r, int c, int i) {
19        if (i == word.Length) {
20            return true;
21        }
22        if (r < 0 || c < 0 || r >= ROWS || c >= COLS ||
23        board[r][c] != word[i] || board[r][c] == '#') {
24            return false;
25        }
26
27        board[r][c] = '#';
28        bool res = Dfs(board, word, r + 1, c, i + 1) ||
29                   Dfs(board, word, r - 1, c, i + 1) ||
30                   Dfs(board, word, r, c + 1, i + 1) ||
31                   Dfs(board, word, r, c - 1, i + 1);
32        board[r][c] = word[i];
33        return res;
34    }
35}