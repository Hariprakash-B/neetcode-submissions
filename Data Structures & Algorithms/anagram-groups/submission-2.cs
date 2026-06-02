public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] count = new int[26];
            foreach(char c in str){
                count[c - 'a']++;
            }
            string key = string.Join(",",count);
            if(!result.ContainsKey(key)){
                result[key]= new List<string>();
            }
            result[key].Add(str);
        }
        return result.Values.ToList<List<string>>();
    }
}
