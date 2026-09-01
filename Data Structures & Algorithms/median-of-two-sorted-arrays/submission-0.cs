public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        foreach(int i in nums1){
            result.Add(i);
        }
        foreach(int i in nums2){
            result.Add(i);
        }
        result.Sort();
        int left = 0;
        int right = result.Count-1;
        if(result.Count % 2 == 0){
            int firstmid = left + (right-left)/2;
            int rightmid = firstmid+1;
            return (result[firstmid]+result[rightmid])/2.0;
        }
        else{
            int mid = left + (right-left)/2;
            return result[mid];
        }
    }
}
