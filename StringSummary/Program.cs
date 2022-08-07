namespace StringSummary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "We wanna summarize the code to from this long sentence that is very long long long.";
            var summary =  SummerizeText(sentence, 30);
            Console.WriteLine(summary);
        }
        
        static string SummerizeText(string text, int maxLength = 20)
        {
          
            if (text.Length < maxLength)
                return text;
           
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";

        }

    }
}