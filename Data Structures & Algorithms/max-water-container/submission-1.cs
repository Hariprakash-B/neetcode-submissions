public class Solution {
    public int MaxArea(int[] heights) {
      int left=0;
      int right=heights.Length-1;
      int result=0;
      while(left < right){
         int max = (right - left) * Math.Min(heights[left],heights[right]);
         if(max > result){
            result = max;
         }
         if(heights[left]<heights[right]){
            left++;
         }
         else{
            right--;
         }
      }
      return result;
   }
}
