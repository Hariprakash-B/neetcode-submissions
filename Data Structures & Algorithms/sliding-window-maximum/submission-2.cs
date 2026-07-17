public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] output = new int[nums.Length-k+1];
        for(int i=0;i<(nums.Length-k+1);i++){
            output[i]=int.MinValue;
            for(int j=i; j<i+k; j++){
                output[i] = Math.Max(nums[j],output[i]);
            }
        }
        return output;
    }
}
