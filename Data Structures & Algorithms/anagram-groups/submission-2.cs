public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string, List<string>> map = new();

        foreach (string word in strs) {

            int[] count = new int[26];

            foreach (char c in word) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(word);
        }

        return map.Values.ToList();
    }
}