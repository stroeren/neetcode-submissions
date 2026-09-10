public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int pointer = -1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == pointer) {
                return true;
            }
            pointer = nums[i];
        }
        return false;
    }
}