public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        for (int i = 0; i <= n; i++)
        {
            // Use height 0 at the end to force flush remaining bars in stack
            int currentHeight = (i == n) ? 0 : heights[i];

            while (stack.Count > 0 && heights[stack.Peek()] > currentHeight)
            {
                int h = heights[stack.Pop()];
                int w = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, h * w);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}