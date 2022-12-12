// Solution using hash set, i.e. Dictionary class for C#
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int len = nums.Length;
        
        if (len == 2) return new int[] { 0, 1 };

        Dictionary<int, int> dict = new Dictionary<int, int>() {
            { nums[0], 0 }
        };
        for (int i = 1; i < len; i++) {
            if (dict.ContainsKey(target-nums[i])) {
                return new int[] { dict[target-nums[i]], i };
            }
            if (!dict.ContainsKey(nums[i])) {
                dict.Add(nums[i], i);
            }
        }
        
        return new int[] {};
    }
}
