class Solution {
    public int lengthOfLongestSubstring(String s) {
        int max = 0;
        for(int i = 0; i < s.length(); i++){
            Set<Character> set = new HashSet<>();
            int iterator = i;
            while (iterator < s.length() &&  !set.contains(s.charAt(iterator))) {
                set.add(s.charAt(iterator));
                iterator++;
            }
            if((iterator-i) > max){
                max = iterator - i;
            }
        }
        return max;
    }
}
