public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> numbers = new Stack<int>();
        HashSet<string> operators = new() {"+","-","*","/"};
        for(int i=0; i < tokens.Length; i++){
            if(!operators.Contains(tokens[i])){
                numbers.Push(Convert.ToInt32(tokens[i]));
            }
            else{
                int newnum = calculate(numbers.Pop(), numbers.Pop(), tokens[i]);
                numbers.Push(newnum);
            }
        }
        return numbers.Pop();
    }

    private int calculate(int b, int a, string operatorValue){
        int result;
        switch(operatorValue){
            case "+": 
                result = a+b;
                break;
            case "-":
                result = a-b;
                break;
            case "*":
                result = a*b;
                break;
            case "/":
                result = a/b;
                break;
            default:
                result = 0;
                break;
        }
        return result;
    }
}
