public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int length = nums1.Length + nums2.Length;
        int median = (length/2)+1;
        int current = 0;
        int previous = 0;
        int i=0;
        int j=0;
        int count=0;
        while(count < median){
            if(i > nums1.Length-1){
                count++;
                previous = current;
                current = nums2[j];
                j++;
            }
            else if(j > nums2.Length-1){
                count++;
                previous = current;
                current = nums1[i];
                i++;
            }
            else if(nums1[i]<nums2[j]){
                count++;
                previous = current;
                current = nums1[i];
                i++;

            }
            else{
                count++;
                previous = current;
                current = nums2[j];
                j++;
            }
        }
        if(length % 2 == 0){
            return (previous+current)/2.0;
        }
        else{
            return current;
        }
    }
}
