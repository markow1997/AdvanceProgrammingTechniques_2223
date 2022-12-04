#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

int* twoSum(int* nums, int numsSize, int target, int* returnSize){
	int i, j;
	int index1, index2;
	int resultSize = 0;
	int* output;
	bool isSolutionFound = false;
	
    for (i = 0; i < numsSize; i++){
    	for (j = i + 1; j < numsSize; j++){
    		if (nums[i] + nums[j] == target){    			
    			output = malloc(sizeof(int) * 2);
    			output[0] = i;
    			output[1] = j;
    			isSolutionFound = true;
    			resultSize = 2;
    			break;
			}
		}
		if (isSolutionFound) break;
	}	
	
	*returnSize = resultSize;
	return output;
}

// --- MAIN ---
int main(){
	
	int arr[] = {4,2,6,8,3,8,2,3};
	int temp;
	int *resultSize = &temp;
	
	int* result = twoSum(arr, 8, 11, resultSize);
	
	printf("[%d, %d] returnSize = %d", result[0], result[1], temp);
	
	return 0;
}
