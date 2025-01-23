namespace LinqTrainingMeasurigTextSimilarity;

public class ParserFacade
{
    public int FirstTextNGramNumber {get; private set;}

    public int SecondTextNGramNumber { get; private set; }

    public double JacquardCoefficient { get; private set; }

    public ParserFacade(string text1, string text2, int NGramsLength)
    {
        var wordsText1=TextWordExtractor.GetWords(text1);
        var wordsText2 = TextWordExtractor.GetWords(text2);
        var nGrams1 = NGramCounter.GetNGrams(wordsText1, NGramsLength);
        var nGrams2 = NGramCounter.GetNGrams(wordsText2, NGramsLength);
        FirstTextNGramNumber = nGrams1.Count();
        SecondTextNGramNumber = nGrams2.Count();
        JacquardCoefficient = JacquardCoefficientMeasurer.ExecuteSimilarity(nGrams1, nGrams2);
    }
}
