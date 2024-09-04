public class Solution
{
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        int[,] directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        
        var obstacleMap = new Dictionary<(int, int), bool>();
        foreach (var obstacle in obstacles)
        {
            obstacleMap[(obstacle[0], obstacle[1])] = true;
        }

        int x = 0, y = 0; 
        int directionIndex = 0;
        int maxDistance = 0;

        foreach (var command in commands)
        {
            if (command == -1)
            {
                directionIndex = (directionIndex + 1) % 4;
            }
            else if (command == -2)
            {
                directionIndex = (directionIndex + 3) % 4;
            }
            else
            {
                for (int i = 0; i < command; i++)
                {
                    int nextX = x + directions[directionIndex, 0];
                    int nextY = y + directions[directionIndex, 1];

                    if (!obstacleMap.ContainsKey((nextX, nextY)))
                    {
                        x = nextX;
                        y = nextY;
                        maxDistance = Math.Max(maxDistance, x * x + y * y);
                    }
                    else
                    {
                        break;  // Stop moving in this direction if an obstacle is encountered
                    }
                }
            }
        }

        return maxDistance;
    }
}