public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] result = new int[2];
        for(int i=0; i<nums.Length; i++)
        {
            int diff = target - nums[i];
            for(int j = 0; j< nums.Length && j!= i; j++)
            {
                if(diff == nums[j])
                {
                    result[0] = j;
                    result[1] = i;
                }
            }
        }
        return result;
    }
}
