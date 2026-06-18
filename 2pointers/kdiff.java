class Solution {
    public int findPairs(int[] nums, int k) {
        Arrays.sort(nums);

        int left = 0, right = 1, count = 0;
        int n = nums.length;

        while(left < n && right < n){
            int diff = nums[right] - nums[left];

            if(diff < k || left == right){
                right++;
            }
            else if(diff > k){
                left++;
            }
            else {
                count++;
                left++;
                right++;

                while(right < n && nums[right] == nums[right-1]){
                    right++;
                }
            }
        }

        return count;
    }
}

// [1,1,1,1,1] k = 0
// left = 0
// right = 1
// count = 1