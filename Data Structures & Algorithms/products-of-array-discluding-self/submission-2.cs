public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
     int[] prod = new int[nums.Length];
     int p =1;
     int zeroIndex =-1;
     int count=0;
     for(int i=0;i<nums.Length;i++)   
     {
        int a= nums[i];
        if(a==0 && count >0)
        {
            for(int j=0;j<prod.Length;j++)
            prod[j]=0;
            return prod;
        }
        else if(a == 0)
        {
            zeroIndex = i;
            count++;
        }
        else
        p=p*a;
     }
     for(int j=0; j<prod.Length;j++)
     {
        if(zeroIndex != -1)
        {
            prod[j] = 0;
            prod[zeroIndex] = p;
        }
        else
        {
            prod[j] = p/nums[j];
        }
     }
     return prod;
    }
}
