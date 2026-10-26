public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] counts = new int[26];
        int left = 0;
        int maxCount = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            // Add current character to window frequency map
            counts[s[right] - 'A']++;
            maxCount = Math.Max(maxCount, counts[s[right] - 'A']);

            // If the number of characters to replace exceeds k, shrink window
            while ((right - left + 1) - maxCount > k) {
                counts[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}