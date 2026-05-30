public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        var current = new StringBuilder();
        generate(0,0,n,current, result);
        return result;
    }

    private void generate(int open, int closed, int max, StringBuilder current, List<string> result){
        if(current.Length == max*2){
            result.Add(current.ToString());
            return;
        }

        if(open < max){
            current.Append('(');
            generate(open+1, closed, max, current, result);
            current.Length--;
        }

        if(closed < open){
            current.Append(')');
            generate(open, closed+1, max, current, result);
            current.Length--;
        }
    }
}