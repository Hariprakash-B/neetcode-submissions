public class Solution {
    public int CharacterReplacement(string s, int k) {
       int output = 0;
       for(int i=0; i<s.Length; i++){
           int[] hash = new int[26];
           int maxFreq = 0;
           for(int j=i; j<s.Length; j++){
               hash[s[j]-'A']++;
               maxFreq = Math.Max(maxFreq, hash[s[j]-'A']);
               int length = (j-i+1) - maxFreq;
               if(length<=k){
                    output = Math.Max(j-i+1, output);
               }
               else{
                    break;
               }
           }
       }
       return output;
    }
}
