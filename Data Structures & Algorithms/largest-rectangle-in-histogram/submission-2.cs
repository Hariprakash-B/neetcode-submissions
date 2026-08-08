public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        Stack<int> heightIndex = new Stack<int>();
        for(int i=0; i<heights.Length; i++){
            while(heightIndex.Count > 0 && heights[heightIndex.Peek()] > heights[i]){
                int currentIndex = heightIndex.Pop();
                int height = heights[currentIndex];
                int right = i;
                int left = 0;
                if(heightIndex.Count == 0){
                    left = -1;
                }
                else{
                    left = heightIndex.Peek();
                }
                int width = right - left -1;
                maxArea = Math.Max(maxArea, height * width);             
            }
            heightIndex.Push(i);
        }
        int rightIndex = heightIndex.Peek()+1;
        while(heightIndex.Count != 0){
            int currentIndex = heightIndex.Pop();
            int height = heights[currentIndex];
                int left = 0;
                if(heightIndex.Count == 0){
                    left = -1;
                }
                else{
                    left = heightIndex.Peek();
                }
            int width = rightIndex - left -1;
            maxArea = Math.Max(maxArea, height * width);  
        }
        return maxArea;
    }
}
