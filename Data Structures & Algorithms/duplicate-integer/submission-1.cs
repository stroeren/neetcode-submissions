public class Solution {
    public bool hasDuplicate(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (nums[i] == nums[j] && i != j) {
                    Console.WriteLine(i);
                    return true;
                }
            }
        }
        return false;
    }
}