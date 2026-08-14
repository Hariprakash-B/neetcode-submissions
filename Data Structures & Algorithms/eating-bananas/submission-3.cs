public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        while(left <=right){
            int mid = left + (right-left)/2;
            int pileHour = 0;
            for(int i=0; i<piles.Length; i++){
                pileHour += (piles[i] + (mid-1))/mid;
            }
            if(pileHour > h){
                left = mid + 1;
            }
            else{
                right = mid -1;
            }
        }
        return left;
    }
}
