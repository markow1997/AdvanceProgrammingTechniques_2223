public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int placer = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[placer-1] < nums[i])
            {
                nums[placer] = nums[i];
                placer++;
            }
        }
        
        return placer;
    }
}
