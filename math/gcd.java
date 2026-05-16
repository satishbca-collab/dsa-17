// User function Template for Java

class Solution {
    public int gcd(int n, int arr[]) {
        // code here.
        int result = arr[0];
        for(int i = 1; i < arr.length; i++){
            result = gcdhelper(result, arr[i]);
        }
        return result;
    }
    
    private int gcdhelper(int x, int y){
        int a = Math.min(x,y);
        int b = Math.max(x,y);
        if(a == 0) return b;
        return gcdhelper(a, b%a);
    }
}