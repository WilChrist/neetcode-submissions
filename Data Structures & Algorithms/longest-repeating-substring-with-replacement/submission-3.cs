public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;

        // Try every candidate character from 'A' to 'Z'
        for (char target = 'A'; target <= 'Z'; target++) {
            int left = 0;
            int replacementsUsed = 0;

            for (int right = 0; right < s.Length; right++) {
                if (s[right] != target) {
                    replacementsUsed++;
                }

                // Shrink window from the left if replacements exceed k
                while (replacementsUsed > k) {
                    if (s[left] != target) {
                        replacementsUsed--;
                    }
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }
        }

        return maxLength;
    }
}