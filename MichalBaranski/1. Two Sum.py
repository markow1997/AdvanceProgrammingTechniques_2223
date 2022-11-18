'''

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Input: nums = [3,2,4], target = 6
Output: [1,2]

Input: nums = [3,3], target = 6
Output: [0,1]

'''

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        slownik = dict()
        
        for i, val in enumerate(nums):
            numSlo = target - val
            
            if numSlo in slownik:
                return [slownik[numSlo], i]
            
            slownik[val] = i
