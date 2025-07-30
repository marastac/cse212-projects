using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public static class SetsAndMaps
{
    // ===========================
    // PROBLEM 1: FindPairs
    // ===========================
    public static HashSet<(int, int)> FindPairs(int[] numbers, int target)
    {
        var seen = new HashSet<int>();
        var pairs = new HashSet<(int, int)>();

        foreach (var num in numbers)
        {
            int complement = target - num;
            if (seen.Contains(complement))
            {
                var orderedPair = num < complement ? (num, complement) : (complement, num);
                pairs.Add(orderedPair);
            }
            seen.Add(num);
        }

        return pairs;
    }

    // ===========================
    // PROBLEM 2: SummarizeDegrees
    // ===========================
    public static Dictionary<string, int> SummarizeDegrees(List<(string name, int degrees)> temperatures)
    {
        var summary = new Dictionary<string, int>();

        foreach (var item in temperatures)
        {
            if (summary.ContainsKey(item.name))
            {
                summary[item.name] += item.degrees;
            }
            else
            {
                summary[item.name] = item.degrees;
            }
        }

        return summary;
    }

    // ===========================
    // PROBLEM 3: IsAnagram
    // ===========================
    public static bool IsAnagram(string word1, string word2)
    {
        if (word1 == null || word2 == null) return false;
        if (word1.Length != word2.Length) return false;

        var countMap = new Dictionary<char, int>();

        foreach (var c in word1)
        {
            if (!countMap.ContainsKey(c))
                countMap[c] = 1;
            else
                countMap[c]++;
        }

        foreach (var c in word2)
        {
            if (!countMap.ContainsKey(c)) return false;

            countMap[c]--;
            if (countMap[c] == 0)
                countMap.Remove(c);
        }

        return countMap.Count == 0;
    }

    // ===========================
    // PROBLEM 5: EarthquakeDailySummary
    // ===========================
    public static Dictionary<string, int> EarthquakeDailySummary(string filePath)
    {
        var result = new Dictionary<string, int>();

        string json = File.ReadAllText(filePath);
        var data = JsonConvert.DeserializeObject<FeatureCollection>(json);

        foreach (var feature in data.Features)
        {
            string date = feature.Properties.Time.ToString("yyyy-MM-dd");
            if (result.ContainsKey(date))
                result[date]++;
            else
                result[date] = 1;
        }

        return result;
    }
}
