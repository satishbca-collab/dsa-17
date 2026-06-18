class Solution {
    public bool isPalindrome(string s) {
        // code here
        int n = s.Length;
        if(n <= 1) return true;
        return checkPal(s,0,n-1);
    }
    
    private bool checkPal(string s, int left, int right){
        if(left >= right) return true;
        if(s[left] != s[right]) return false;
        return checkPal(s, left + 1, right - 1);
    }
}