public class Solution {
    // [3,2,4]
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int[][] numWithIndex = new int[n][];
        for(int i = 0; i < n; i++){
            // [0] = [3,0] 
            numWithIndex[i] = new int[] {nums[i], i};
        }
        // [[3,0],[2,1],[4,2]]
        Array.Sort(numWithIndex, (a,b) => a[0].CompareTo(b[0]));

        int left = 0, right = n-1;

        while(left < right){
            int sum = numWithIndex[left][0] + numWithIndex[right][0];

            if(sum == target){
                return new int[] {numWithIndex[left][1], numWithIndex[right][1]};
            }
            else if(sum > target){
                right--;
            }
            else {
                left++;
            }
        }
        return [-1, -1];
    }
}
// function compareTo(int[] a, int[] b){
//     return a[0].CompareTo(b[0]);
// }