// User function Template for Java
class Solution {
    // Function to find the maximum value of the given expression.
    public int maxValueOfExpression(int[] arr) {
        // Write Code Here
        int n = arr.length;
        
        int minSum = arr[0], maxSum = arr[0];
        int minDiff = arr[0], maxDiff = arr[0];
        
        for(int i = 1; i < n; i++){
            minSum = Math.min(minSum, arr[i] + i);
            maxSum = Math.max(maxSum, arr[i] + i);
            minDiff = Math.min(minDiff, arr[i] - i);
            maxDiff = Math.max(maxDiff, arr[i] - i);
        }
        
        return Math.max(Math.abs(maxSum-minSum), Math.abs(maxDiff - minDiff));
    }
}