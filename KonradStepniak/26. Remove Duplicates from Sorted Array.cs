public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        int i, j = 0;
        for (i = 1; i < nums.Length; i++)
        {
            if (nums[j] != nums[i])
            {
                j++;
                nums[j] = nums[i];
            } 
        }

        return j+1;
    }
}