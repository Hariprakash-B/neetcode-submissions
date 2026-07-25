public class MinStack {
    private Stack<long> stack;
    long min = long.MaxValue;
    public MinStack() {
        stack = new Stack<long>();
    }
    
    public void Push(long val) {
        if(stack.Count == 0){
            stack.Push(val);
            min = val;
        }
        else{
            if(val < min){
                stack.Push((val * 2) - min);
                min = val;
            }
            else{
                stack.Push(val);
            }
        }
    }
    
    public void Pop() {
        if(min > stack.Peek()){
            min = (2*min) - stack.Peek();
            stack.Pop();
        }
        else{
            stack.Pop();
        }
    }
    
    public long Top() {
        if(min > stack.Peek()){
            return min;
        }
        else{
            return stack.Peek();
        }
    }
    
    public long GetMin() {
        return min;
    }
}
