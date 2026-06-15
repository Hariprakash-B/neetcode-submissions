public class Solution {
    public int MaxArea(int[] heights) {
      int left=0;
      int right=0;
      int result=0;
      for(int i=0; i<heights.Length; i++){
         for(int j=i;j<heights.Length;j++){
               int max = Math.Min(heights[i],heights[j]);
               int tempResult = max * Math.Abs(i-j);
               if(tempResult > result){
                  result = tempResult;
               }
         }
      }
      return result;
    }
}
