public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hs = new HashSet<int>(nums);
        List<int> seqStarts = new List<int>();
        foreach (int n in hs)
        {
            if (!hs.Contains((n - 1)))
            {
                seqStarts.Add(n);
            }
        }
        List<int> prevList = new List<int>();

        foreach (int sq in seqStarts)
        {
            List<int> currList = new List<int>();
            int curr = sq;
            currList.Add(curr);
            while (true)
            {
                curr++;
                if (hs.Contains(curr))
                {
                    currList.Add(curr);
                }
                else
                {
                    break;
                }
            }
            if (currList.Count > prevList.Count)
            {
                var temp = currList;
                currList = new List<int>();
                prevList = temp;
            }
        }
        return prevList.Count;
    }
}
