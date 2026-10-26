public class Solution
{
    public int LargestRectangleArea(int[] h)
    {
        // Stack stores tuple of (height, width accumulated from the right)
        Stack<(int height, int width)> st = new Stack<(int, int)>();
        int maxArea = 0;

        for (int i = h.Length - 1; i >= 0; i--)
        {
            int accumulatedWidth = 0;

            // Maintain monotonic non-decreasing height order in stack (from top to bottom)
            while (st.Count > 0 && st.Peek().height >= h[i])
            {
                var popped = st.Pop();
                accumulatedWidth += popped.width;
                maxArea = Math.Max(maxArea, popped.height * accumulatedWidth);
            }

            // Push current bar with its total extendable width to the right
            accumulatedWidth += 1;
            st.Push((h[i], accumulatedWidth));
        }

        // Process remaining elements in the stack
        int totalWidth = 0;
        while (st.Count > 0)
        {
            var popped = st.Pop();
            totalWidth += popped.width;
            maxArea = Math.Max(maxArea, popped.height * totalWidth);
        }

        return maxArea;
    }
}