public class Solution {
    public int MaxProfit(int[] prices) {
      int buy=0, sell=0, max=0;
      for(int i=0; i<prices.Length; i++) {
        buy = prices[i];
        for(int j=i+1; j<prices.Length;j++){
            sell = prices[j];
            max = Math.Max(max, (sell-buy));
        }        
      }
      return max; 
    }
}
