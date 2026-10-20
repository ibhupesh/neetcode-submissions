public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(int i=0; i<nums.Length;i++)
        {
            int count =0;
            for(int j=0;j<nums.Length; j++)
            {
                if(j == i)
                continue;
                if(nums[i] == nums[j])
                count++;
                if(count > 0)
                return true;             
            }
        }
        return false;
    }
}