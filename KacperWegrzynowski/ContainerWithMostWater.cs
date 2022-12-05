public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int result = 0;
        int minHeight = 0;

        while (left < right)
        {
            minHeight = Math.Min(height[left], height[right]);
            result = Math.Max(result, minHeight * (right - left));

            if (height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}
