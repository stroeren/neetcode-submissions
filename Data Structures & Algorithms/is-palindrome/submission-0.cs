public class Solution {
    public bool IsPalindrome(string s) {
        //two pointer
        string cleaned = Regex.Replace(s.ToLowerInvariant(), @"[^a-z0-9]", "");
        int end = cleaned.Length - 1;
        for (int i = 0; i < cleaned.Length; i++) {
            if (cleaned[i] != cleaned[end]) {
                return false;
            }
            end--;
        }
        return true;
    }
}
