using LinqTrainingMeasurigTextSimilarity;

string workingDirectory = Environment.CurrentDirectory;
string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

InputHandler inputHandler = new (projectDirectory);

string firstText= inputHandler.GetFileText("Enter the name of the first file:" );
string secondText= inputHandler.GetFileText("Enter the name of the second file:");

int nGramLength= inputHandler.GetNGramsLength();
 
ParserFacade parserFacade = new(firstText, secondText, nGramLength);

Console.WriteLine($"Number of N-grams in the first text: {parserFacade.FirstTextNGramNumber}");

Console.WriteLine($"Number of N-grams in the second text: {parserFacade.SecondTextNGramNumber}");

Console.WriteLine($"Jacquard Coefficient: {parserFacade.JacquardCoefficient}");






