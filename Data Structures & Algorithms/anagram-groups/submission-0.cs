public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       List<List<string>> fin = new List<List<string>>();

       List<int[]> index = new List<int[]>();

       if(strs.Length<2)
        {
            List<string> res = new List<string>();
            res.Add(strs[0]);
            fin.Add(res);
        }
        else
        {
         foreach(string s in strs)
         {
            int[] freq = new int[26];
            for(int i=0; i< s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }
            index.Add(freq);
         }
         
         bool[] visited = new bool[strs.Length];
         
         for(int i=0;i<index.Count;i++)
         {
            if (visited[i]) continue;

            List<string> res = new List<string>();
            res.Add(strs[i]);
            visited[i] = true;
            for(int j=0; j<index.Count; j++)
            {
                if (j == i) continue;

                if(!visited[j] && index[i].SequenceEqual(index[j]))
                {
                    res.Add(strs[j]);
                    visited[j] = true;
                }
            }
            fin.Add(res);
         }
        }
        return fin;
    }
}