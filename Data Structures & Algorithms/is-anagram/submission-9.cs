public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sHash = new Dictionary<char, int>();
        Dictionary<char, int> tHash = new Dictionary<char, int>();

        if (s.Length != t.Length) {
            return false;
        }
        
        for (int i = 0; i < s.Length; i++) {
            if (!sHash.ContainsKey(s[i])) {
                sHash.Add(s[i], 1);
            }
            else {
                sHash.TryGetValue(s[i], out int val);
                sHash[s[i]] = val + 1;
            }
        }
        
        for (int i = 0; i < t.Length; i++) {
            if (!tHash.ContainsKey(t[i])) {
                tHash.Add(t[i], 1);
            }
            else {
                tHash.TryGetValue(t[i], out int val);
                tHash[t[i]] = val + 1;
            }
        }

        foreach (var sTuple in sHash) {
            if (!tHash.TryGetValue(sTuple.Key, out int tCount) || sTuple.Value != tCount) {
                return false;
            }
        }
        return true;
    }
}
