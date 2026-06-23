public class Solution {
    public int MaxProfit(int[] prices) {
        int left=0;
        int right=1;
        int max=0;
        while(right<prices.Length){
            if(prices[left]<prices[right]){
                max = Math.Max(max,(prices[right]-prices[left]));
            }
            else{
                left=right;
            }
            right++;
        }
        return max;
    }
}
