public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        for(int i=0; i<temperatures.Length-1; i++){
            result[i] = 0;
            int current_temp = temperatures[i];
            for(int j=i+1; j<temperatures.Length; j++){
                if(temperatures[j]>current_temp){
                    result[i] = j-i;
                    break;
                }
            }
        }
        return result;
    }
}
