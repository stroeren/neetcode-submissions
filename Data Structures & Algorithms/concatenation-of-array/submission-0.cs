public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[(2 * nums.Length)];
        int k = 0;
        for (int i = 0; i < nums.Length; i++) {
            ans[k] = nums[i];
            k++;
        }
        for (int i = 0; i < nums.Length; i++) {
            ans[k] = nums[i];
            k++;
        }
        return ans;
    }
}