public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length){
            return false;
        }
        int[] s1Hash = new int[26];
        int[] s2Hash = new int[26];
        for(int i=0; i<s1.Length; i++){
            s1Hash[s1[i]-'a']++;
            s2Hash[s2[i]-'a']++;
        }
        int l=0;
        while(l<s2.Length - s1.Length){
            if(s1Hash.SequenceEqual(s2Hash)){
                return true;
            }
            s2Hash[s2[l]-'a']--;
            s2Hash[s2[l+s1.Length]-'a']++;
            l++;
        }
        return s1Hash.SequenceEqual(s2Hash);
    }
}
