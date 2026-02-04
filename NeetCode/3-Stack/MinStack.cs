public class MinStack {
    Stack<int> _stack;
    Stack<int> _minstack;
    public MinStack() {
      _stack=new Stack<int>();    
      _minstack=new Stack<int>();   
    }
    
    public void Push(int val) {
        int min=val;
        _stack.Push(val);
        min=Math.Min(val,_minstack.Count>0?_minstack.Peek():val);
        _minstack.Push(min);
    }
    
    public void Pop() {
        _stack.Pop();
        _minstack.Pop();
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _minstack.Peek();
    }
}
