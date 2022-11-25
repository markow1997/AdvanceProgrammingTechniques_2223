class Solution {
    public String longestPalindrome(String s) {
        String result = "";
        boolean OK;
        String mySubstr;
        int p,q;
        for (int i=0; i<s.length(); i++)
        {
            OK = true;
            p = 0;
            q = i;
            mySubstr = s.substring(p, i+1);
            while (p<q)
            {
                if (mySubstr.charAt(p) != mySubstr.charAt(q)){
                    
                    if(mySubstr.length()>1)
                    {          
                    mySubstr = mySubstr.substring(1, mySubstr.length());
                    p=0;
                    q = mySubstr.length()-1;
                    }
                    else
                    {
                        OK = false;
                        break;
                    }
                }
                else {
                    p++;
                    q--;
                }
            }
            if (OK && (result.length() < mySubstr.length()))
                result = mySubstr;
        }
        return result;
    }
}
