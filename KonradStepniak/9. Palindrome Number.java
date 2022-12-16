class Solution {
    public boolean isPalindrome(int x) {

        if (x<0) return false;

        int reversed=0, remainder;
        for (int i = x; i>0; i/=10)
        {
            remainder = i % 10;
            reversed = (reversed*10) + remainder;
        }

        if (x==reversed) return true;
        else return false;
    }
}
