public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int[] result = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if (!frequency.ContainsKey(nums[i])) {
                frequency[nums[i]] = 1;
            }
            else {
                frequency.TryGetValue(nums[i], out int val);
                frequency[nums[i]] = val + 1;
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kvp in frequency) {
            if (buckets[kvp.Value] == null) {
                buckets[kvp.Value] = new List<int>();
            }
            buckets[kvp.Value].Add(kvp.Key);
        }
        
        int index = 0;
        for (int i = buckets.Length - 1; i >= 0 && index < k; i--) {
            if (buckets[i] != null) {
                foreach (int num in buckets[i]) {
                    result[index++] = num;
                    if (index == k) break;
                }
            }
        }
        return result;
    }
}
