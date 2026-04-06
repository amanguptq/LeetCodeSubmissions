// Last updated: 4/6/2026, 11:48:46 PM
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int []> st = new Stack<int[] >();
        int maxArea = 0;
        for(int i=0; i<heights.Length; i++){
        int index = i;
        while(st.Count>0 && st.Peek()[1]>heights[i])
        {
            var pair = st.Pop();
            var Area = pair[1] * (i - pair[0]);
            maxArea = Math.Max(maxArea, Area);
            index = pair[0];
        }
        st.Push(new int[] {index, heights[i]});
        }

        foreach (int[] pair in st) {
            int index = pair[0];
            int height = pair[1];
            maxArea = Math.Max(maxArea, height * (heights.Length - index));
        }
        return maxArea;
        
    }
}