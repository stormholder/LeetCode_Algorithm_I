using System.Collections;

namespace Permutation;

public class Solution
{
    private void SequenceAppend(ref Dictionary<char, int> seqence, char c)
    {
        if (seqence.ContainsKey(c))
        {
            seqence[c]++;
        }
        else
        {
            seqence.Add(c, 1);
        }
    }
    private bool SequenceEquals(ref Dictionary<char, int> dict1, ref Dictionary<char, int> dict2)
    {
        if (dict1.Count != dict2.Count)
            return false;
        bool criteria = true;
        foreach (var key in dict1.Keys)
        {
            if (!dict2.ContainsKey(key) || !dict1[key].Equals(dict2[key]))
            {
                criteria = false;
                break;
            }
        }
        return criteria;
    }

    public bool CheckInclusion(string s1, string s2)
    {
        int left = 0;
        int right = s1.Length;
        Dictionary<char, int> s1Sequence = new();
        foreach (char c in s1)
        {
            SequenceAppend(ref s1Sequence, c);
        }
        bool result = false;
        while (right <= s2.Length)
        {
            Dictionary<char, int> s2Sequence = new();
            for (int i = left; i < right; i++)
            {
                SequenceAppend(ref s2Sequence, s2[i]);
            }

            if (SequenceEquals(ref s1Sequence, ref s2Sequence))
            {
                result = true;
                break;
            }
            left++;
            right++;
            continue;
        }

        return result;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}