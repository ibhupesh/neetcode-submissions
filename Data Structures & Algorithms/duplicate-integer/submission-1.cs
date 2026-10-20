public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>();
        foreach( int n in nums)
        {
            if(check.Contains(n))
            return true;
            
            check.Add(n);
        }
        return false;
    }
}