public class Solution {
    public int Trap(int[] height) {
    int result = 0;
    int[] prefix = new int[height.Length];
    int[] suffix = new int[height.Length];
    prefix[0]=height[0];
    suffix[height.Length-1]=height[height.Length-1];
    for(int i=height.Length-2; i>=0; i--){
        if(height[i]>suffix[i+1]){
            suffix[i]=height[i];
        }
        else{
            suffix[i]=suffix[i+1];
        }
    }
    for(int i=1; i<height.Length-1;i++){
       if(height[i]>prefix[i-1]){
            prefix[i] = height[i];
        }
        else{
            prefix[i] = prefix[i-1];
        }
        if(height[i] < prefix[i] && height[i] < suffix[i]){
            result += Math.Min(prefix[i],suffix[i])-height[i];
        }
    }
    return result;
    }
}
