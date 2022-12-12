class Solution {
    public void reverseString(char[] s) {
        //liczymy dlugosc char s 
        int dlugosc = s.length;
        // pomocniczy char[] o dlugosci s
        char[] wynik = new char [dlugosc];
        // odwrócenie  miejsc literek
        for (int i=dlugosc-1, j=0; i>=0; i--, j++)
        {
            wynik[j]=s[i];
        }
        // przepiosanie wyniku do s 
         for (int i=0; i<dlugosc; i++)
        {
            s[i] = wynik[i];
        }
        
      // System.out.println(s);
    }
}

