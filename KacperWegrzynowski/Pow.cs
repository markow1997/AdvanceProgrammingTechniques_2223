public class Solution {
    public double MyPow(double x, int n) {
        switch(n)
        {
            case 0:
                return 1;
            case 1:
                return x;
            case -1:
                return 1/x;
            default:
                int half = n >> 1;
                double halfPow = MyPow(x, half);
                if(n%2 == 0) return halfPow*halfPow;
                return halfPow*halfPow*x;
        }
    }
}
