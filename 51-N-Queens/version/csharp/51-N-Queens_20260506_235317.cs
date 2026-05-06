// Last updated: 5/6/2026, 11:53:17 PM
1public class Solution {
2    HashSet<int> col = new HashSet<int>();
3    HashSet<int> posDiag = new HashSet<int>();
4    HashSet<int> negDiag = new HashSet<int>();
5    List<IList<string>> res = new List<IList<string>>();
6
7    public List<IList<string>> SolveNQueens(int n) {
8        char[][] board = new char[n][];
9        for (int i = 0; i < n; i++) {
10            board[i] = new char[n];
11            Array.Fill(board[i], '.');
12        }
13
14        Backtrack(0, n, board);
15        return res;
16    }
17
18    private void Backtrack(int r, int n, char[][] board) {
19        if (r == n) {
20            List<string> copy = new List<string>();
21            foreach (char[] row in board) {
22                copy.Add(new string(row));
23            }
24            res.Add(copy);
25            return;
26        }
27
28        for (int c = 0; c < n; c++) {
29            if (col.Contains(c) || posDiag.Contains(r + c) ||
30                negDiag.Contains(r - c)) {
31                continue;
32            }
33
34            col.Add(c);
35            posDiag.Add(r + c);
36            negDiag.Add(r - c);
37            board[r][c] = 'Q';
38
39            Backtrack(r + 1, n, board);
40
41            col.Remove(c);
42            posDiag.Remove(r + c);
43            negDiag.Remove(r - c);
44            board[r][c] = '.';
45        }
46    }
47}