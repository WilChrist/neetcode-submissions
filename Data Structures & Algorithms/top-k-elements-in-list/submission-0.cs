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

        // build a list of lists where the index represents the frequency
        List<int>[] frequencyList = new List<int>[nums.Length + 1];
        foreach (var kvp in frequencyDict)
        {
            int num = kvp.Key;
            int freq = kvp.Value;
            if (frequencyList[freq] == null)
            {
                frequencyList[freq] = new List<int>();
            }
            frequencyList[freq].Add(num);
        }

        // collect the top k frequent elements
        List<int> result = new List<int>();
        for (int i = frequencyList.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (frequencyList[i] != null)
            {
                result.AddRange(frequencyList[i]);
            }
        }

        return result.ToArray();
    }
}
