public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (!haystack.Contains(needle)) return -1;

        int indexCount = 0;
        string haystackStringByString = "";

        for (int i = 0; i < haystack.Length; i++)
        {
           haystackStringByString += haystack[i];
           if (haystackStringByString.Contains(needle))
           {
            return (indexCount+1-needle.Length);
           }
           indexCount ++;
        }
        return indexCount;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        string test = "test";
        string test2 = "test" + "1";
        // Console.WriteLine(test[2]);
        // Console.WriteLine("test2 ->" + test2);
        Console.WriteLine("0 -> " + s.StrStr("sadbutsad", "sad"));
        Console.WriteLine("-1 -> " + s.StrStr("leetcode", "leeto"));
        Console.WriteLine("4 -> " + s.StrStr("leetcode", "code"));
        Console.WriteLine("mississippi");
        Console.WriteLine("4 -> " + s.StrStr("mississippi", "issip"));
    }
}
