class Solution {
    public boolean isPalindrome(int x) {
        LinkedList<Integer> digits = new LinkedList<Integer>();
        int number = x;

        if (number < 0)
            return false;
        
        while (number > 0)
        {
            digits.push(number%10);
            number /= 10;
        }
  
        int i = 0;
        int j = digits.size()-1;
        while(i<j)
        {
            if (digits.get(i) != digits.get(j))
            return false;
            i++;
            j--;
        }
        
        return true;
    }
}
