// Last updated: 4/6/2026, 11:48:10 PM
public class StockSpanner {

    Stack<(int price,int res)> FullST;

    public StockSpanner() {

        FullST = new Stack<(int, int)>();
        
    }
    
    public int Next(int price) {
                int res=1;

                while(FullST.Count>0 && FullST.Peek().price<=price)
                {
                    var previous = FullST.Pop();
                    res += previous.res;
                }
                FullST.Push((price,res));
                return res;

            }
        }
        
    


/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */