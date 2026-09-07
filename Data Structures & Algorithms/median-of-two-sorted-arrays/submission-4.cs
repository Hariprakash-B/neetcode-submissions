public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {       
        if(nums1.Length > nums2.Length){
            return FindMedianSortedArrays(nums2, nums1);
        }
        int m = nums1.Length;
        int n = nums2.Length;
        int leftPartitionSize = (m+n+1)/2;
        int left = 0;
        int right = m;
        while(left <= right)
        {
            int i = left + (right - left )/2;
            int j = leftPartitionSize - i;
            int Aleft = i==0 ? int.MinValue : nums1[i-1];
            int Aright = i==m ? int.MaxValue : nums1[i];
            int Bleft = j==0 ? int.MinValue : nums2[j-1];
            int Bright = j == n ? int.MaxValue : nums2[j];
            if(Aleft > Bright){
                right = i-1;
            }
            else if(Bleft > Aright){
                left = i+1;
            }
            else{
                if((m+n)%2 ==0){
                    return (Math.Max(Aleft,Bleft)+Math.Min(Aright,Bright))/2.0;
                }
                else{
                    return Math.Max(Aleft, Bleft);
                }
            }
        }
        return 0.0;
    }
}
