public class Solution {
    public bool CheckInclusion(string s2, string s1) {
        char[] s2Char = s2.ToCharArray();
        Array.Sort(s2Char);
        string s2Sorted = new String(s2Char);
        for(int i=0; i<s1.Length; i++){
            string subString = "";
            for(int j=i; j<s1.Length; j++){
                subString += s1[j];
                if(j-i+1 == s2.Length){
                    char[] charArray = subString.ToCharArray();
                    Array.Sort(charArray);
                    string subStringSorted = new String(charArray);
                    if(s2Sorted == subStringSorted){
                        return true;
                    }
                    else{
                        break;
                    }
                }
            }
        }
        return false;
    }
}
