public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultnums = new int[nums.Length];
        int zeroCount = 0;
        int wholeProduct = 1;
        foreach(int i in nums){
            if(i != 0){
                wholeProduct *=i;
            }
            else{
                zeroCount++;
            }
        }
        if(zeroCount > 1){
            return resultnums;
        }
        for(int i = 0; i< nums.Length; i++){
            if(zeroCount > 0){
                resultnums[i] = (nums[i] == 0) ? wholeProduct : 0;
            }
            else{
                resultnums[i] = wholeProduct / nums[i];
            }
        }
        return resultnums;
    }
}
