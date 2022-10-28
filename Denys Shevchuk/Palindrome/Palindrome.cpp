class Solution {
public:
    bool isPalindrome(int x) {
        string s = to_string(x);
        bool result = true;
        for(int i = 0; i < s.length(); i++){
            if(s[i] != s[s.length()-i-1]){
                result = false;
                break;
            }
        }
        return result;
    }
};
