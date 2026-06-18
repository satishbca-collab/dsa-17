public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        Helper(nums, 0, result, new List<int>());
        return result;
    }

    private void Helper(int[] nums, int index, IList<IList<int>> result, List<int> cur){
        result.Add(new List<int>(cur));

        for(int i = index; i < nums.Length; i++){
            cur.Add(nums[i]);
            Helper(nums, i+1, result, cur);
            cur.RemoveAt(cur.Count-1);
        }
    }
}