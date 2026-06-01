using System.Linq.Expressions;
namespace Challenge1 {
    internal class Challenge1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result;
            Console.WriteLine("Enter what text you would like to create tags for");
            string text = Console.ReadLine();
            Console.WriteLine("Enter how many tags you would like this article to have");
            int items = Convert.ToInt32(Console.ReadLine());
            result = GetTopWords(text, items);
            foreach (var pair in result)
            {
                Console.WriteLine($"Key: \"{pair.Key}\", Value: {pair.Value}");
            }
        }
        public static Dictionary<string, int> GetTopWords(string text, int topN)
        {
            string[] words;
            Dictionary<string, int> wordAppearances = [];
            Dictionary<string, int> finalwords = [];
            int[] values = [];
            string[] punctuation = { "!", ",", ".", "?" };
            Dictionary<string, int> results = [];
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
            foreach (KeyValuePair<string, int> word in wordAppearances.OrderByDescending(key => key.Value).ThenBy(word => word.Key))
            {
                finalwords.Add(word.Key, word.Value);
            }
            if (finalwords.Count != 0)
            {
                int instances = finalwords.Count;
                for (int i = 0; i < instances && i < topN; i++)
                {
                    var pair = finalwords.ElementAt(i);
                    results.Add(pair.Key, pair.Value);

                }
            }
            else
            {
                Console.WriteLine($"Count = {results.Count}");
                Console.WriteLine("Test Case 3: N is larger than unique words");
            }
            return results;
        }
    }
}