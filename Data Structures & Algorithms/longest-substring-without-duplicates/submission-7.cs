public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0, l=0, r=0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        while(r<s.Length){
            if(!map.ContainsKey(s[r])){
                map[s[r]]=r;
            }
            else{
                if(map[s[r]]>=l){
                    l=map[s[r]]+1;
                    map[s[r]] = r;
                }
                else{
                    map[s[r]]=r;
                }
            }
            result = Math.Max(result, r-l+1);
            r++;
        }
        return result;
    }
}
