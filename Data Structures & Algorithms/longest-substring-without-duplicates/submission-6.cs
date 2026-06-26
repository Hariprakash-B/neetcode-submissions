public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        for(int i=0; i<s.Length; i++){
            HashSet<char> set = new HashSet<char>();
            for(int j=i; j<s.Length;j++){
                if(set.Contains(s[j])){
                    break;
                }
                set.Add(s[j]);
                result = Math.Max(result, j-i+1);
            }
        }
        return result;
    }
}
