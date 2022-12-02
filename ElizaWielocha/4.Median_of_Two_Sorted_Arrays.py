'''
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

EXAMPLE 1:
Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

EXAMPLE 2:
Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

'''

class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        i = 0
        j = 0 
        k = 0
        arr3 = list()
        arr3 = [0 for i in range(len(nums1)+len(nums2))]

        # traverse the arr1 and insert its element in arr3
        while i < len(nums1):
            arr3[k] = nums1[i]
            k += 1
            i += 1
        
        # now traverse arr2 and insert in arr3
        while j < len(nums2):
            arr3[k] = nums2[j]
            k += 1
            j += 1
        
        
        # sort the whole array arr3 and return mediana
        arr3.sort()
        if len(arr3) % 2 == 0:
            result = ( arr3[ int( (len(arr3)/2) -1) ] + arr3[ int( len(arr3)/2) ] ) / 2
            return float(result)
        else:
            result = arr3[ ( int(( len(arr3)+1 ) / 2 ) - 1) ]
            return float(result)