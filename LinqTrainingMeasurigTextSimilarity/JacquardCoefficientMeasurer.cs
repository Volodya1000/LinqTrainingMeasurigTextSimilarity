namespace LinqTrainingMeasurigTextSimilarity;

public static class JacquardCoefficientMeasurer
{
    public static double ExecuteSimilarity(Dictionary<string,int> nGramsDic1, Dictionary<string, int> nGramsDic2)
    {
        var groupedDictionaries = nGramsDic1.Keys.Intersect(nGramsDic2.Keys);
        int common = groupedDictionaries.Select(key =>
                                    Math.Min(nGramsDic1[key], nGramsDic2[key]))
                                    .Sum();
        int total = groupedDictionaries.Select(key =>
                                    Math.Max(nGramsDic1[key], nGramsDic2[key]))
                                    .Sum();
        double jacquardCoefficient = (double)common/ total;
        return jacquardCoefficient;
    }
}
