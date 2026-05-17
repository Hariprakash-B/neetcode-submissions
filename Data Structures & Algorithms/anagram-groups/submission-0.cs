public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            char[] strChar = str.ToCharArray();
            Array.Sort(strChar);
            string sortedStr = new string(strChar);
            if(!res.ContainsKey(sortedStr)){
                res[sortedStr] = new List<string>();
            }
            res[sortedStr].Add(str);
        }
        return res.Values.ToList<List<String>>();
    }
}
