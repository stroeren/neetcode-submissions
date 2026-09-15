public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dupMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (!dupMap.ContainsKey(nums[i])) {
                dupMap.Add(nums[i], 1);
            }
            else {
                dupMap.TryGetValue(nums[i], out int val);
                dupMap[nums[i]] = val + 1;
            }
        }
        
        foreach (var count in dupMap.Values) {
            if (count >= 2) {
                return true;
            }
        }
        return false;
    }
}