public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        
        char[] sArray = new char[s.Length];
        char[] tArray = new char[t.Length];
        int counter = new int();
        
        for (int i = 0; i < s.Length; i++) {
            sArray[i] = s[i];
            tArray[i] = t[i];
        }
        
        Array.Sort(sArray);
        Array.Sort(tArray);

        for (int i = 0; i < s.Length; i++) {
            if (sArray[i] == tArray[i]) {
                counter++;
            }
        }

        if (counter == s.Length) {
            return true;
        }
        else {
            return false;
        }
    }
}
