public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        bool done = false;
        while (done != true) {
            if (numbers[left] + numbers[right] == target) {
                done = true;
                break;
            }
            if (numbers[left] + numbers[right] < target) {
                left++;
            }
            if (numbers[left] + numbers[right] > target) {
               right--;
            }
        }
        return [left + 1, right + 1];
    }
}
