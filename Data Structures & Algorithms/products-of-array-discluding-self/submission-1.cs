public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultnums = new int[nums.Length];
        if(nums.Where(c => c == 0).Count() > 1){
            return resultnums;
        }
        int wholeProduct = 1;
        foreach(int i in nums){
            if(i != 0){
                wholeProduct *=i;
            }
        }
        for(int i = 0; i< nums.Length; i++){
            if(!nums.Contains(0)){
                resultnums[i] = wholeProduct / nums[i];
            }
            else if(nums[i] == 0){
                resultnums[i] = wholeProduct;
            }
        }
        return resultnums;
    }
}
