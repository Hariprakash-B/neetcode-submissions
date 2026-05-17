public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length == t.Length){
            char[] charS = s.ToCharArray();
            char[] charT = t.ToCharArray();
            Array.Sort(charS);
            Array.Sort(charT);
            return new String(charS) == new String(charT);
        }
        else{
            return false;
        }
    }
}
