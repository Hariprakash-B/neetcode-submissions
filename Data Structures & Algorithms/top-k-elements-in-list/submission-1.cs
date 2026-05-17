public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var resultList = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!resultList.ContainsKey(num)){
                resultList[num] = 1;
            }
            else{
                resultList[num]+=1;
            }
        }
        return resultList.OrderByDescending(x => x.Value).Take(k).Select(c => c.Key).ToArray();
    }
}
