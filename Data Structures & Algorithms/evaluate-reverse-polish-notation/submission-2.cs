public class Solution {
    public int EvalRPN(string[] tokens) {
        List<int> numbers = new List<int>();
        HashSet<string> operators = new() {"+","-","*","/"};
        for(int i=0; i < tokens.Length; i++){
            if(!operators.Contains(tokens[i])){
                numbers.Add(Convert.ToInt32(tokens[i]));
            }
            else{
                int b = numbers[numbers.Count-1];
                numbers.RemoveAt(numbers.Count -1);
                int a = numbers[numbers.Count-1];
                numbers.RemoveAt(numbers.Count -1);
                int newnum = calculate(a, b, tokens[i]);
                numbers.Add(newnum);
            }
        }
        return numbers[0];
    }

    private int calculate(int a, int b, string operatorValue){
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
