public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int count=1;
        int maxcount=1;
        int length = nums.Length;
        if(length == 0){
            return 0;
        }
        for(int i=0; i< length-1;i++){
            if(nums[i+1]-nums[i]==1){
                count++;
            }
            else if(nums[i+1] == nums[i]){
                continue;
            }
            else{
                count=1;
            }
            if(count>maxcount){
                maxcount=count;
            }
        }
        return maxcount;
    }
}
