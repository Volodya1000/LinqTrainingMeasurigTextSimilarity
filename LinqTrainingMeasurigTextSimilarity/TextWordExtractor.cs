using System.Text.RegularExpressions;

namespace LinqTrainingMeasurigTextSimilarity;

public static class TextWordExtractor
{
    public static IEnumerable<IEnumerable<string>> GetWords(string text)
    {
        char[] splits = { '.', '!', '?', '(', ')', '[', ']', '{', '}' };
        var sentences = text.Split(splits, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Select(s => Regex.Matches(s, @"\p{L}+")
                .Cast<Match>()
                .Select(m => m.Value.ToLower()));
    }
}
