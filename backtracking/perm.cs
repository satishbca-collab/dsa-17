public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var visited = new bool[nums.Length];
        Helper(nums, result, visited, new List<int>());
        return result;
    }

    private void Helper(int[] nums, IList<IList<int>> result, bool[] visited, List<int> cur){
        if(cur.Count == nums.Length){
            result.Add(new List<int>(cur));
            return;
        }
        for(int i = 0; i < nums.Length; i++){
            if(!visited[i]){
                cur.Add(nums[i]);
                visited[i] = true;
                Helper(nums, result, visited, cur);
                // backtracking
                visited[i] = false;
                cur.RemoveAt(cur.Count-1);
            }
        }
    }
}