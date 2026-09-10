public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int[] result = new int[n];
        int rightMax = -1;
        
        // Iterate from right to left
        for (int i = n - 1; i >= 0; i--) {
            // Store current maximum to the right
            result[i] = rightMax;
            
            // Update maximum if current element is larger
            if (arr[i] > rightMax) {
                rightMax = arr[i];
            }
        }
        
        return result;
    }
}