public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                counter++;
            }
            if (nums[i] != 1 || i == nums.Length - 1) {
                if (counter > max) {
                    max = counter;
                    counter = 0;
                }
                else {
                    counter = 0;
                }
            }
            Console.WriteLine(counter);
        }
        return max;
    }
}