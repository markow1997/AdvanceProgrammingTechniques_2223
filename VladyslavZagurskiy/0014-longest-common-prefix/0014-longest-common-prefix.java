class Solution {
    public String longestCommonPrefix(String[] strs) {
        String max_prefix = strs[0];
        if(strs.length==0) return "";    
        for (int i = 1; i < strs.length; i++) {
        while(strs[i].indexOf(max_prefix) !=0){
            max_prefix = max_prefix.substring(0,max_prefix.length() - 1);
            }
        }
        return max_prefix;
    }
}
