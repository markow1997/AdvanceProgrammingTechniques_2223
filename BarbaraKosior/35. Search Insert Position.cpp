class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
         
        int i=0;
        int b = nums.size()-1;

        while (i<b){
            int srednia = (i+b)/2;
            if (nums[srednia] == target)
            {
                return srednia;
            }
            else if (nums[srednia] > target)
            {
                b = srednia -1;
            }
            else
            {
                i = srednia +1;
            }
        }
        if (nums[i]>=target)
        {
            return i;
        }
        else 
        {
            return i+1;
        }

    }
};
