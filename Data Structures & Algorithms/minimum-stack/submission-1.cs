public class MinStack {
    private Stack<int> stack;
    private Stack<int> tempstack;
    public MinStack() {
        stack = new Stack<int>();
        tempstack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        tempstack.Push(Math.Min(val, tempstack.Count == 0 ? val: tempstack.Peek()));

    }
    
    public void Pop() {
        stack.Pop();
        tempstack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return tempstack.Peek();
    }
}
