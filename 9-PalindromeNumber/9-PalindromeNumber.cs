// Last updated: 4/6/2026, 11:49:00 PM
public class Solution {
    public bool IsPalindrome(int x) {

          int n=x, y=0;       //turn to string (easy to reverse)
    if(n<0)
    {
        return false;
    }
    else
    {
        while(n>0){
            y = (y*10) + (n%10);
            n = n/10;
        }
    }

        if (y == x)
        {return true;}
        else
        {return false;}
        
    }
}