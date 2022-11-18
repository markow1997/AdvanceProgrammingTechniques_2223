class Solution {
public:
    int diagonalSum(vector<vector<int>>& mat) {

        int sum=0;
        int size = mat.size();
        for (int i = 0; i < size ; i++)
        {
            sum = sum + mat[i][i] + mat[i][size-1-i];
        }
            
        if (size % 2)
        {
            sum = sum -mat[size/2][size/2];
        }
        return sum;
    }
};