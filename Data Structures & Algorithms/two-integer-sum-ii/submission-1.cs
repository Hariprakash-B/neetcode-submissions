public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int first = 0;
        int second = numbers.Length-1;
        while(first<second){
            if((numbers[first] != numbers[second]) && 
                (numbers[first] + numbers[second] == target)){
                return [first+1,second+1];
            }
            if(numbers[first] + numbers[second] < target){
                first++;
            }
            else{
                second--;
            }
        }
        return [0,0];
    }
}
