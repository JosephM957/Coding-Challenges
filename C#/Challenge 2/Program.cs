namespace Challenge2
{
    internal class Challenge2
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice <= 0 || choice >= 4)
            {
                Console.WriteLine("Enter which mode you would like to use 1 for compression and 2 for decompression.");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the string which you would like to compress");
                    Compress(Console.ReadLine());
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the string which you would like to decompress");
                    Decompress(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Error choice was not valid use 1 for compression and 2 for decompression");
                }
            }
        }
        public static void Compress(string input)
        {
            try
            {
                if (input == "" || input == null)
                {
                    throw new ArgumentException();
                }
                char[] charcters = input.ToCharArray();
                string output = "";
                bool inCompression = false;
                Dictionary<char, int> characterSets = new Dictionary<char, int>();
                char lastc;
                foreach (char c in charcters)
                {
                    lastc = c;
                    if (characterSets.ContainsKey(c))
                    {
                        characterSets[c] = characterSets.GetValueOrDefault(c) + 1;
                    }
                    else
                    {
                        characterSets.Add(c, 1);
                    }

                }
                for (int i = 0; i < characterSets.Count; i++)
                {
                    output += characterSets.ElementAt(i).ToString();

                }
                output = output.Replace(",", "");
                output = output.Replace("[", "");
                output = output.Replace("]", "");
                output = output.Replace(" ", "");
                Console.WriteLine(output);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Error input must have a value");
            }
        }
        public static void Decompress(string input)
        {
            try {
                if (input == "" || input == null)
                {
                    throw new ArgumentException();
                }
                char[] charcters = input.ToCharArray();
            Dictionary<char, int> charsets = new Dictionary<char, int>();
            char letter = '0';
            int number = 0;
            string output = "";
            for (int i = 0; i <= charcters.Length - 1; i++)
            {
                if (i % 2 == 1)
                {
                    number = Convert.ToInt32(charcters[i] - '0');
                    charsets.Add(letter, number);
                }
                else
                {
                    letter = charcters[i];
                }
            }
            for (int i = 0; i < (charcters.Length / 2); i++)
            {
                int repeater = charsets.ElementAt(i).Value;
                while (repeater != 0)
                {
                    output += charsets.ElementAt(i).Key;
                    repeater--;
                }
            }
            Console.WriteLine(output);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Error input must have a value");
            }
}
    }
}