public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
      Array.Sort(nums);
      List<List<int>> result = new List<List<int>>();
      for(int i=0; i<nums.Length; i++){
        if(nums[i] > 0) break;
        if(i>0 && nums[i-1] == nums[i]) continue;
        int l=i+1;
        int r=nums.Length-1;
        while(l<r){
          if(nums[i]+nums[l]+nums[r]<0){
            l++;
          }else if(nums[i]+nums[l]+nums[r]>0){
            r--;
          }
          else{
            result.Add(new List<int>{nums[i],nums[l],nums[r]});
            l++;
            r--;
            while(l<r && nums[l] == nums[l-1]){
                l++;
            while(l<r && nums[r] == nums[r-1]){
                  r--;
              }
            }
          }
        }
      }
      return result;
    }
}
