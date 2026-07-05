public class Solution {
    public int CharacterReplacement(string s, int k) {
       int output = 0;
       int i=0,j=0;
       int[] hash = new int[26];
       int maxFreq=0;
       while(j<s.Length){
           hash[s[j]-'A']++;
           maxFreq = Math.Max(maxFreq, hash[s[j]-'A']);
           int length = (j-i+1) - maxFreq;
           if(length<=k){
               output = Math.Max(j-i+1,output);
               j++;
           }
           else{
            hash[s[i]-'A']--;
            hash[s[j]-'A']--;
            i++;
           }
       }
       return output;
    }
}
