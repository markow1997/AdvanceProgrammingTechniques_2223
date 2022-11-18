class Solution {
    public int lengthOfLongestSubstring(String s) {
        int k = 0;
        int length = 0;
        int resultLength = 0;
        boolean checkSign = true;
        char[] tab = new char[s.length()];

        for (int i=0; i<s.length(); i++)
        {   
            while (tab[k] != '\0')
            {
                if (tab[k] == s.charAt(i))
                {
                    i = i - length + k;
                    checkSign = false;
                    break;
                }           
                k++;
            }
            if (checkSign)
            {    
                tab[k] = s.charAt(i);
                k = 0;
                length++;
            }
            else 
            {
                checkSign = true;
                k=length;
                while (k > 0)
                {
                    tab[k-1] = '\0';
                    k--;
                }
                if (resultLength < length)
                    resultLength = length;   
                length = 0;
            }
        }
        if (resultLength < length)
            resultLength = length;    
        return resultLength;
    }
}
