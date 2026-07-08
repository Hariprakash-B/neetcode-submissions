public class Solution {
    public bool CheckInclusion(string s2, string s1) {
        char[] s2Char = s2.ToCharArray();
        Array.Sort(s2Char);
        string s2Sorted = new String(s2Char);
        int length = s1.Length - s2.Length + 1;
        for(int i=0;i<length;i++){
            string subString = s1.Substring(i,s2.Length);
            char[] charArray = subString.ToCharArray();
            Array.Sort(charArray);
            string subStringSorted = new String(charArray);
            if(s2Sorted == subStringSorted){
                return true;
            }
        }
        return false;
    }
}
