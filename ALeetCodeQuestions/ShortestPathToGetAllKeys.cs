using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    //class ShortestPathToGetAllKeys
    //{
    //    int numberOfKeys = 0;
    //    public int ShortestPathAllKeys(string[] grid)
    //    {
    //        char[][] matrix = Create2DGridFromInput(grid);
    //        var startingPoint = FindStartingPoint(matrix);
    //        bool[][] visited = new bool[matrix.Length][];
    //        for(int i=0; i<visited.Length;i++)
    //        {
    //            visited[i] = new bool[matrix[0].Length];
    //            for(int j=0;j<visited[0].Length;j++)
    //            {
    //                visited[i][j] = false;
    //            }
    //        }
    //        Queue<int[]> queue = new Queue<int[]>();
    //        List<char> keyFound = new List<char>();
    //        queue.Enqueue(startingPoint);
    //        int[][] directions = new int[][]
    //        {
    //            new int[]{1,0},
    //            new int[]{0,1},
    //            new int[]{-1,0},
    //            new int[]{0,-1}
    //        };
    //        int steps = 0;

    //        while(queue.Count>0)
    //        {
    //            var count = queue.Count;
    //            for(int i=0;i<count;i++)
    //            {
    //                var currentCell = queue.Dequeue();
    //                int currentRow = currentCell[0];
    //                int currentColumn = currentCell[1];
    //                visited[currentRow][currentColumn] = true;
    //                foreach(var direction in directions)
    //                {
    //                    int nextCellRow = currentRow + direction[0];
    //                    int nextCellColumn = currentColumn + direction[1];
    //                    if (nextCellRow >=0 && nextCellColumn >=0 && nextCellRow<matrix.Length && nextCellColumn<matrix[0].Length && matrix[nextCellRow][nextCellColumn]!='#' && visited[nextCellRow][nextCellColumn]!=true)
    //                    {
    //                        if (matrix[nextCellRow][nextCellColumn] == '.')
    //                        {
    //                            queue.Enqueue(new int[] { nextCellRow, nextCellColumn });
    //                            visited[nextCellRow][nextCellColumn] = true;


    //                        }
    //                        else if (char.IsLower(matrix[nextCellRow][nextCellColumn]))
    //                        {
    //                            keyFound.Add(matrix[nextCellRow][nextCellColumn]);
    //                            queue.Enqueue(new int[] { nextCellRow, nextCellColumn });
    //                            visited[nextCellRow][nextCellColumn] = true;

    //                        }
    //                        else if (char.IsUpper(matrix[nextCellRow][nextCellColumn]) && keyFound.Contains(char.ToLower(matrix[nextCellRow][nextCellColumn])))
    //                        {
    //                            queue.Enqueue(new int[] { nextCellRow, nextCellColumn });
    //                            visited[nextCellRow][nextCellColumn] = true;

    //                        }
    //                    }

    //                }


    //            }
    //            steps++;
    //            if (keyFound.Count == numberOfKeys)
    //            {
    //                return steps;
    //            }

    //        }
    //        return -1;
    //    }
    //    private char[][] Create2DGridFromInput(string[] grid)
    //    {
    //        char[][] matrix = new char[grid.Length][];
    //        for(int i=0;i<grid.Length;i++)
    //        {
    //            matrix[i] = new char[grid[i].Length];
    //            for(int j=0;j<matrix[i].Length;j++)
    //            {
    //                matrix[i][j] = grid[i][j];
    //                if(char.IsLower(matrix[i][j]))
    //                {
    //                    numberOfKeys++;
    //                }
    //            }
    //        }
    //        return matrix;
    //    }
    //    private int[] FindStartingPoint(char[][] matrix)
    //    {
    //        for(int i=0;i<matrix.Length;i++)
    //        {
    //            for(int j=0;j<matrix[0].Length;j++)
    //            {
    //                if(matrix[i][j]=='@')
    //                {
    //                    return new int[] { i, j };
    //                }
    //            }
    //        }
    //        return new int[0];
    //    }
    //}

    public class ShortestPathToGetAllKeys
    {
        int[] dx = new int[] { 0, 1, 0, -1 };
        int[] dy = new int[] { 1, 0, -1, 0 };
        public int ShortestPathAllKeys(string[] grid)
        {
            int r = grid.Length;
            int c = grid[0].Length;
            int x = 0;
            int y = 0;
            
            var hashset = new HashSet<char>();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    var ch = grid[i][j];
                    if (ch == '@')
                    {
                        x = i; y = j;
                    }

                    if (Char.IsLower(ch))
                        hashset.Add(ch);
                }
            }

            int k = hashset.Count;
            var start = new int[k + 2];
            start[k] = x; start[k + 1] = y;
            var queue = new Queue<int[]>();
            var visited = new Dictionary<string, int>();
            queue.Enqueue(start);
            visited[string.Join(":", start)] = 0;
            while (queue.Count != 0)
            {
                var curr = queue.Dequeue();
                var currKey = string.Join(":", curr);
                x = curr[k]; y = curr[k + 1];
                int sum = 0;
                for (int i = 0; i < k; i++)
                    sum += curr[i];
                if (sum == k) 
                    return visited[currKey];
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i], ny = y + dy[i];
                    if (nx >= 0 && nx < r && ny >= 0 && ny < c && grid[nx][ny] != '#')
                    {
                        var next = (int[])curr.Clone();
                        next[k] = nx; next[k + 1] = ny;

                        if (char.IsUpper(grid[nx][ny]) && next[grid[nx][ny] - 'A'] == 0)
                            continue;
                        if (char.IsLower(grid[nx][ny]))
                            next[grid[nx][ny] - 'a'] = 1;

                        var nextKey = string.Join(":", next);
                        if (!visited.ContainsKey(nextKey))
                        {
                            visited[nextKey] = visited[currKey] + 1;
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            return -1;
        }
    }
}
