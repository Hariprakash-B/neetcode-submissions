public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        for(int j=0; j< s.Length; j++)
        {
            string tempstring = "";
            for(int i=j; i<s.Length; i++){
                if(!tempstring.Contains(s[i])){
                    tempstring+=s[i];
                    if(tempstring.Length > result){
                        result = tempstring.Length;
                    }
                }
                else{
                    if(tempstring.Length > result){
                        result = tempstring.Length;
                    }
                    tempstring="";
                    tempstring+=s[i];
                }
            }
        }
        return result;
    }
}
