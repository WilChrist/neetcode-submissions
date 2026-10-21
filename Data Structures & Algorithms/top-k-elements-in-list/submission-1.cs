public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // build a frequency dictionary
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!frequencyDict.ContainsKey(num))
            {
                frequencyDict[num] = 0;
            }
            frequencyDict[num]++;
        }

        // create a min heap to store the top k frequent elements
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        
        foreach (var kvp in frequencyDict)
        {
            int num = kvp.Key;
            int freq = kvp.Value;
            minHeap.Enqueue(num, freq);
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        int[] result = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }
}
