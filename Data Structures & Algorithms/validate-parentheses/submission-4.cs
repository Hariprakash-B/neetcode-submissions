public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2 == 1){
            return false;
        }
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> brackets = new Dictionary<char,char>();
        brackets['('] = ')';
        brackets['{'] = '}';
        brackets['['] = ']';
        foreach(char i in s){
            if(brackets.ContainsKey(i)){
                stack.Push(i);
            }
            else{
                if(stack.Count !=0){
                    char item = stack.Pop();
                    if(!(brackets[item] == i)){
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
        }
        if(stack.Count ==0){
            return true;
        }
        else{
            return false;
        }
    }
}
