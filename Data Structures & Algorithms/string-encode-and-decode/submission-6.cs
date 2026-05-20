public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) return "";
        string temp = "";
        foreach(string s in strs){
            temp += s.Length.ToString();
            temp += "#";
            temp += s;
        }
        return temp;
    }

    public List<string> Decode(string s) {
        if(s.Length == 0){
            return new List<string>();
        }
        int i = 0;
        int j = 0;
        List<string> resarray = new List<string>();
        while(i < s.Length){
            j = i;
            while(s[j] != '#'){
                j++;
            }
            int tempnumsize = int.Parse(s.Substring(i,j-i));
            j++;
            string tempstring = s.Substring(j,tempnumsize);
            resarray.Add(tempstring);
            i=j+tempnumsize;
        }    
        return resarray;
   }
}
