class Solution {
    public int reverse(int x) {
        long result = 0;
        while (x != 0)
        {
            result += (long)x%10;
            x = x/10;

            if (Math.abs(x) > 0)
                result *= 10;
            else
                break;

            if ((long)Integer.MAX_VALUE <= result || 
                (long)Integer.MIN_VALUE >= result)
            {
                result = 0;
                break;
            }

        }
        return (int)result;
    }
}
