public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length > s.Length){
            return "";
        }
        string finalOutput = "";
        for(int i=0; i<s.Length; i++){
            string output = "";
            string s_temp = t;
            for(int j=i; j<s.Length; j++){
                output += s[j];
                int index = s_temp.IndexOf(s[j]);
                if(index != -1){
                    s_temp = s_temp.Remove(index, 1);
                }
                if(s_temp.Length == 0){
                    if(finalOutput == ""){
                        finalOutput = output;
                    }
                    finalOutput = output.Length < finalOutput.Length ? output : finalOutput;
                    break;
                }
            }
        }
        return finalOutput;
    }
}
