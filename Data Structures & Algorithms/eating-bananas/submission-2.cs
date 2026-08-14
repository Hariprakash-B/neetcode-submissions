public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int mid=0;
        int k=int.MaxValue;
        while(left <=right){
            mid = left + (right-left)/2;
            int pileHour = 0;
            for(int i=0; i<piles.Length; i++){
                pileHour += (piles[i] + (mid-1))/mid;
            }
            if(pileHour > h){
                left = mid + 1;
            }
            else{
                right = mid -1;
                k = Math.Min(k, mid);
            }
        }
        return k;
    }
}
