public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
      HashSet<Tuple<int,int,int>> uniqueTriplets= new HashSet<Tuple<int,int,int>>();
      List<List<int>> result = new List<List<int>>();
      Array.Sort(nums);
      for(int i=0; i < nums.Length; i++){
        for(int j=i+1; j < nums.Length; j++){
            for(int k=j+1; k< nums.Length; k++){
                if(nums[i]+nums[j]+nums[k]==0){
                    var tuple = Tuple.Create(nums[i],nums[j],nums[k]);
                    uniqueTriplets.Add(tuple);
                }
            }
        }
      }
      foreach(var i in uniqueTriplets){
        result.Add(new List<int> {i.Item1, i.Item2, i.Item3});
      }
      return result;
    }
}
