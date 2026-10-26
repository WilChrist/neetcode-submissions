public class Solution {
    public bool IsPalindrome(string s) {
        char [] arr = Array.FindAll<char>(s.ToCharArray(),(c=>char.IsLetterOrDigit(c)));
        if(arr.Length<2) return true;
        for(int i = 0, j=arr.Length-1; i<=arr.Length/2;i++,j--){
            if(Char.ToLower(arr[i])!=Char.ToLower(arr[j])){
                return false;
            }
        }
        return true;
    }
}
