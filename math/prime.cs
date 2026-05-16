// User function Template for C#

class Solution {
    // Function to check if a number is prime or not.
    public bool isPrime(int n) {
        // code here
        for(int i = 2; i*i <= n; i++){
            if(n % i == 0){
                return false;
            }
        }
        
        return true;
    }
}