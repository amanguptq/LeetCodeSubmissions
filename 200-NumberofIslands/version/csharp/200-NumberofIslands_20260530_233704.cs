// Last updated: 5/30/2026, 11:37:04 PM
// dfs
1public class Solution {
2    private static readonly int[][] directions = new int[][] {
3        new int[] {1, 0}, new int[] {-1, 0},
4        new int[] {0, 1}, new int[] {0, -1}
5    };
6
7    public int NumIslands(char[][] grid) {
8        int ROWS = grid.Length, COLS = grid[0].Length;
9        int islands = 0;
10
11        for (int r = 0; r < ROWS; r++) {
12            for (int c = 0; c < COLS; c++) {
13                if (grid[r][c] == '1') {
14                    Dfs(grid, r, c);
15                    islands++;
16                }
17            }
18        }
19
20        return islands;
21    }
22
23    private void Dfs(char[][] grid, int r, int c) {
24        if (r < 0 || c < 0 || r >= grid.Length ||
25            c >= grid[0].Length || grid[r][c] == '0') {
26            return;
27        }
28
29        grid[r][c] = '0';
30        foreach (var dir in directions) {
31            Dfs(grid, r + dir[0], c + dir[1]);
32        }
33    }
34}