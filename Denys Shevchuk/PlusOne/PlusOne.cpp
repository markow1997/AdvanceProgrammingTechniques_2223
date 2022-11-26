class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        int currentPosition = digits.size()-1;
        if(digits[currentPosition] != 9){
            digits[currentPosition] += 1;
            return digits;
        }
        digits[currentPosition] = 0;
        currentPosition--;
        while(1){
            if(currentPosition < 0){
                vector<int> newDigits = vector<int>();
                newDigits.push_back(1);
                for(int i = 0; i < digits.size(); i++){
                    newDigits.push_back(digits[i]);
                }
                return newDigits;
            }
            if(digits[currentPosition] != 9){
                digits[currentPosition] += 1;
                return digits;
            }
        digits[currentPosition] = 0;
        currentPosition--;
        }
    }
};
