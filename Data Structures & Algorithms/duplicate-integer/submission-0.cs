public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> duplicateNums = new List<int>();
        for(int i=0; i < nums.Length; i++){
            if(duplicateNums.Contains(nums[i]))
            {
                return true;
            }
            else{
                duplicateNums.Add(nums[i]);
            }
        }
        return false;
    }
}