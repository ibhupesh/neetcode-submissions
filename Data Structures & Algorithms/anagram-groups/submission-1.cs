public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       if (strs == null || strs.Length == 0) 
            return new List<List<string>>();

        // HashMap: Key is the canonical sorted representation, Value is the group
        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            // 1. Sort the characters to produce the canonical key
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // 2. Insert into the hash map
            if (!map.TryGetValue(key, out var list)) {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(s);
        }

        // 3. Return all grouped values
        return new List<List<string>>(map.Values);
    }
}