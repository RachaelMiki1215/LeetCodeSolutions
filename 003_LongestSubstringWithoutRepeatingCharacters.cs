// Solution using Queue<T> class.
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int len = s.Length;

        if (len <= 1) return len;

        int max = 0;
        int i = 0;
        Queue<char> q = new Queue<char>();
        
        while (i < len) {
            if (q.Contains(s[i])) {
                max = Math.Max(max, q.Count);
                char top;
                do {
                    top = q.Dequeue();
                } while (top != s[i]);
            }
            q.Enqueue(s[i]);
            i++;
        }
        
        max = Math.Max(max, q.Count);
        
        return max;
    }
}
