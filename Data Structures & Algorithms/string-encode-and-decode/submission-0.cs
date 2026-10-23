public class Solution {

    public string Encode(IList<string> strs) {
     string encoded="";
     foreach(string s in strs)
     {
        encoded = encoded + Encode(s);
     }
     return encoded;
    }

    public List<string> Decode(string s) {
        List<string> decoded = new List<string>();
        string sub="";
        for(int i =0; i<s.Length; i++)
        {
            if(char.IsWhiteSpace(s[i]))
            {
                sub = DecodeString(sub);
                decoded.Add(sub);
                sub ="";
            }
            else
            {
                sub = sub + s[i];
            }
        }
        return decoded;
   }
   private string Encode(string original)
   {
        byte[] bytes = Encoding.UTF8.GetBytes(original);
        string base64String = Convert.ToBase64String(bytes);

        return base64String + " ";
   }
   private string DecodeString(string original)
   {
        byte[] data = Convert.FromBase64String(original);
        string decodedString = Encoding.UTF8.GetString(data);

        return decodedString;
   }
}
