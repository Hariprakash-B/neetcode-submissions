public class MinStack {
    private Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        Stack<int> temp = new Stack<int>();
        int minimum = stack.Peek();
        while(stack.Count > 0){
            minimum = Math.Min(minimum, stack.Peek());
            temp.Push(stack.Pop());
        }
        while(temp.Count>0){
            stack.Push(temp.Pop());
        }
        return minimum;
    }
}
