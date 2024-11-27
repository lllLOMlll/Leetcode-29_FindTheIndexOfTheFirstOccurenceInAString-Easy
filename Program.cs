public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (!haystack.Contains(needle)) return -1;

        int indexCount = 0;
        foreach (char letter in haystack)
        {
            if (letter == needle[0])
            {
                return indexCount;
            }
            else
            {
                indexCount++;
            }

        }
        return indexCount;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        // Console.WriteLine("0 -> " + s.StrStr("sadbutsad", "sad"));
        // Console.WriteLine("-1 -> " + s.StrStr("leetcode", "leeto"));
        // Console.WriteLine("4 -> " + s.StrStr("leetcode", "code"));
        Console.WriteLine("4 -> " + s.StrStr("mississippi", "issip"));
    }
}
