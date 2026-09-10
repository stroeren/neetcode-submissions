public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answerArray = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (((nums[i] + nums[j]) == target) && (i != j)) {
                    answerArray[0] = i;
                    answerArray[1] = j;
                    return answerArray;
                }
            }
        }
        return answerArray;
    }
}
