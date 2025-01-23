namespace LinqTrainingMeasurigTextSimilarity;

public class NGramCounter
{
    public static Dictionary<string, int> GetNGrams(IEnumerable<IEnumerable<string>> text, int nGramLength)
    {
        return text.SelectMany(n =>
                Enumerable.Range(0, n.Count() - nGramLength + 1)
                .Select(j => n.Skip(j).Take(nGramLength)))
                .GroupBy(ng => string.Join(" ", ng)) 
                .ToDictionary(
                    g => g.Key, 
                    g => g.Count()
                );
    }

}
