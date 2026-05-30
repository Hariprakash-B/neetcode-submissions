public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> result = new HashSet<int>();
        foreach(int i in nums){
            if(!result.Add(i)){
                return true;
            }
            else{
                result.Add(i);
            }
        }
        return false;
    }
}