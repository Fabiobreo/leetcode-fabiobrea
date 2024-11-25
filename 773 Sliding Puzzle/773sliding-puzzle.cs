public class Solution
{
    // 0  1  2
    // 3  4  5
    private static readonly int[][] Adjiacents = new int[][]
    {
        new int[] { 1, 3 },
        new int[] { 0, 2, 4 },
        new int[] { 1, 5 },
        new int[] { 0, 4 },
        new int[] { 1, 3, 5 },
        new int[] { 2, 4 },
    };

    public int SlidingPuzzle(int[][] _board)
    {
        var sb = new StringBuilder();

        sb.Append((char)(_board[0][0] + '0'));
        sb.Append((char)(_board[0][1] + '0'));
        sb.Append((char)(_board[0][2] + '0'));
        sb.Append((char)(_board[1][0] + '0'));
        sb.Append((char)(_board[1][1] + '0'));
        sb.Append((char)(_board[1][2] + '0'));

        var target = sb.ToString();

        var visited = new HashSet<string>();

        var queue = new Queue<(string, int, int)>();
        queue.Enqueue(("123450", 5, 0));

        while (queue.Count > 0)
        {
            var (board, offset, count) = queue.Dequeue();

            if (board == target)
            {
                return count;
            }

            if (!visited.Contains(board))
            {
                visited.Add(board);

                foreach (var o2 in Adjiacents[offset])
                {
                    var newBoard = this.Switch(board, offset, o2);

                    if (!visited.Contains(newBoard))
                    {
                        queue.Enqueue((newBoard, o2, count + 1));
                    }
                }
            }
        }

        return -1;
    }

    private string Switch(string board, int i, int j)
    {
        var arr = board.ToCharArray();
        var tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
        return new string(arr);
    }
}