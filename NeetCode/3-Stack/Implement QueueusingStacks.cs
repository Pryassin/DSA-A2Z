public class MyQueue {
    Stack<int> _input;
     Stack<int> _output;
    public MyQueue() {
        _input=new Stack<int>();
        _output=new Stack<int>();
    }
    
    public void Push(int x) {
        _input.Push(x);
    }
    
    public int Pop() {
        MoveInputToOutput();
        return _output.Pop();
    }
    
    public int Peek() {
        MoveInputToOutput();
        return _output.Peek();
    }
    
    public bool Empty() {
        return _input.Count==0&&_output.Count==0;
    }
    private void MoveInputToOutput()
    {
      if(_output.Count==0)
      {
        while(_input.Count>0)
        {
          _output.Push(_input.Pop());
        }
      }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */