public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int totalSum;
        int i, n;

        for (i = 0; i < nums.Length; i++) {
            for (n = 0; n < nums.Length; n++) {
                if (n != i) {
                    totalSum = nums[i] + nums[n];
                    if (totalSum == target) {
                        return new int[] { i, n };
                    }
                }
            }
        }

        return new int[] { }; 
    }
}
