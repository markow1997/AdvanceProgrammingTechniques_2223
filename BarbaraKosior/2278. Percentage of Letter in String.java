class Solution {
    public int percentageLetter(String s, char letter) {
        int dlugosc = s.length();
        int x=0; // pomocnicza do zliczania liter
        for (int i=0 ; i<dlugosc; i++)
        {
            if (s.charAt(i) == letter)
            {
                x=x+1;
            }
            else {};
        }
        int procent=Math.round((x*100)/dlugosc);
        return procent;
    }
}

