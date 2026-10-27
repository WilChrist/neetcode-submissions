public class Solution
{
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
    public int BinarySearch(int[] arr, int l, int r, int t)
    {
        int x = -1;
        if(l > r)
        {
            return x;
        }
        int m = (l + r) / 2;

        if (arr[m] == t)
        {
            return m;
        }
        else if (arr[m] > t)
        {
            x = BinarySearch(arr, l, m - 1, t);
        }
        else
        {
            x = BinarySearch(arr, m + 1, r, t);
        }
        return x;
    }
}