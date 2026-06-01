//CURRENTLY IN PROGRESS NOT COMPLETED YET
using System.Linq.Expressions;
namespace Challenge1 {
    internal class Challenge1
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> result = GetTopWords("This is me testing. Punctation!,.", 5);
        }
        public static Dictionary<string, int> GetTopWords(string text, int topN)
        {
            string[] words;
            Dictionary<string, int> wordAppearances = [];
            string[] punctuation = { "!", ",", ".", "?" };
            foreach (string punct in punctuation)
            {
                text = text.Replace(punct, string.Empty);
            }
            text = text.ToLower();
            words = text.Split(" ");
            foreach (string word in words) {
                if (wordAppearances.ContainsKey(word))
                {
                    wordAppearances[word] += 1;
                }
                else
                {
                    wordAppearances.Add(word, 1);
                }
            }
            wordAppearnces = wordAppearnces.OrderByDescending(wordAppearances);
            foreach (var word in wordAppearances)
            {
            }
            return wordAppearances;
        }
    }
}