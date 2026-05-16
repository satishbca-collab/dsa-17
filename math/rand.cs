/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int value = Rand7() + ((Rand7() - 1) * 7);
        if(value > 40) return Rand10();
        return (value % 10)+1;
    }
}