class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergedTab = new int[nums1.length + nums2.length];
        int i=0, j=0, k=0, pos;
        double result = 0;
        
        while (i<nums1.length && j<nums2.length)
        {
            if (nums1[i] < nums2[j])
            {
                mergedTab[k]=nums1[i];
                i++;
            }  
            else if (nums1[i] > nums2[j])
            {
                mergedTab[k]=nums2[j];
                j++;
            }  
            else {
                mergedTab[k] = nums1[i];
                k++;
                mergedTab[k] = nums2[j];
                i++;
                j++;
            } 
            k++;  
        }
        while (i<nums1.length)
        {
            mergedTab[k] = nums1[i];
            k++;
            i++;
        }
        while (j<nums2.length)
        {
            mergedTab[k] = nums2[j];
            k++;
            j++;
        }

        if (mergedTab.length == 0)
            return 0;
        else if (mergedTab.length == 1)
            return mergedTab[0];
        else {
            if (mergedTab.length%2 == 1)
                {
                    pos = mergedTab.length/2;
                    result = mergedTab[pos];
                    return result;
                }
            else
                {
                    pos = mergedTab.length/2;
                    result = (mergedTab[pos] + mergedTab[pos-1]) / 2.0;
                    return result;
                }
        }
    } 
}
