public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        HashSet<int> result = new HashSet<int>();
        int[][] postionSpeed = new int[position.Length][];
        for(int i=0; i < position.Length; i++){
            postionSpeed[i] = new int[] {position[i] , speed[i]};
        }
        Array.Sort(postionSpeed, (a,b) => b[0].CompareTo(a[0]));
        double time=-1;
        int count=0;
        for(int i=0; i<position.Length; i++){
            double x = (double)(target - postionSpeed[i][0]) / postionSpeed[i][1];
            // if(time == -1){
            //     time = x;
            // }
            if(x > time || time == -1){
                count++;
                time = x;
            }
        }
        return count;
    }
}
