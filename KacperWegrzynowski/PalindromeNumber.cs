public class Solution {
    public bool IsPalindrome(int x) {
        int r;
        int temp = x;
        int sum = 0;
        while(temp > 0)
        {
            r = temp%10;
            sum = (sum*10)+r;
            temp /= 10;
        }
        return x == sum;
    }
}
