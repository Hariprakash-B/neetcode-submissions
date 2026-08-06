public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        for(int i=0; i<heights.Length; i++){
            int height = heights[i];
            for(int j=i; j<heights.Length; j++){
                int length = j-i+1;
                height = Math.Min(height,heights[j]);
                maxArea = Math.Max(maxArea, length * height);
            }
        }
        return maxArea;
    }
}
