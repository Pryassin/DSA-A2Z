public class StockSpanner {
    private Stack<(int price, int span)> stack;


    public StockSpanner() {
     stack = new Stack<(int, int)>();
    }
    
    public int Next(int price) {
         int Span=1;
       while(stack.Count>0&&stack.Peek().price<=price)
       {
          Span+=stack.Pop().span;
       }
       stack.Push((price,Span));

       return Span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */