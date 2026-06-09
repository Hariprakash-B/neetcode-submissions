public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i=0; i<numbers.Length;i++){
            for(int j=i; j< numbers.Length; j++){
                if(numbers[i] == numbers[j]){
                    continue;
                }
                if(numbers[i]+numbers[j] == target){
                    return[i+1,j+1];
                }
            }
        }
        return[0,0];
    }
}
