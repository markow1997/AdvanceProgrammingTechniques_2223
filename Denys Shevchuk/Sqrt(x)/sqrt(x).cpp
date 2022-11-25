class Solution {
public:
    int mySqrt(int x) {
        unsigned int i = 1;
        unsigned int lastNum = 0;
        unsigned int tempResult = 1;
        while(true){
            tempResult = i * i;
            if(tempResult == x)
                return i;
            if(tempResult > x)
                return lastNum;
            lastNum = i;
            i++;
        }  
    }
};
