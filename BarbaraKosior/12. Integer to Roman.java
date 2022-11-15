class Solution {
    public String intToRoman(int num) {
         String I[] = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"}; //jednosci
         String X[] = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"}; //dziesiatki
         String C[] = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}; //setki
         String M[] = {"", "M", "MM", "MMM"}; // TYSIACE
         return M[num/1000] + C[(num%1000)/100] + X[(num%100)/10] + I[num%10];
    }
}
