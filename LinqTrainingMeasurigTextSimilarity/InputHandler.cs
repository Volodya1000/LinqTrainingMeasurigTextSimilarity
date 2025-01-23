namespace LinqTrainingMeasurigTextSimilarity;

public class InputHandler(string projectDirectory)
{
    public  string GetFileText(string requestText)
    {
        string fileName = "";
        bool notCorrect = true;
        while (notCorrect)
        {
            Console.WriteLine(requestText);
            fileName = Console.ReadLine();
            try
            {
                using var file1 = File.OpenText($"{projectDirectory}/Texts/{fileName}");
                return file1.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Could not find file with name \"{fileName}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an error occurred: {ex.Message}");
            }
        }
        return "";
    }

    public int GetNGramsLength()
    {
        int nGramLength = 0;
        string nGramLengthString;
        bool notCorrect = true;
        while (notCorrect)
        {
            Console.WriteLine("Enter N-gram length:");
            nGramLengthString = Console.ReadLine();
            try
            {
                nGramLength = Convert.ToInt32(nGramLengthString);
                notCorrect = false;
            }
            catch
            {
                Console.WriteLine("Your input is not correct");
            }
        }
        return nGramLength;
    }
}
