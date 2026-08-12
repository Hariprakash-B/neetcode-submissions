public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0;
        int columns = matrix[0].Length;
        int rows = matrix.Length;
        int right = rows * columns -1;
        while(left <= right)
        {
            int mid = left + (right - left)/2;
            if(matrix[mid/columns][mid % columns] == target){
                return true;
            }
            else if(matrix[mid/columns][mid % columns] > target){
                right = mid -1 ;
            }
            else{
                left = mid + 1;
            }
        }
        return false;
    }
}
