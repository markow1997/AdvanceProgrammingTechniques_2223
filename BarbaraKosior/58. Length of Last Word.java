class Solution {
    public int lengthOfLastWord(String s) {
        s = s.trim();
        int dlugosc = s.length(); 
        int ostatni= s.lastIndexOf(" ")+1;
        int x = dlugosc - ostatni;
        return x;
    }
}
