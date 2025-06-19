namespace _19._6._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split("");
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            while (line != "stop")
            {
                line = Console.ReadLine();
                foreach (string part in parts)
                {
                    if (wordCount.ContainsKey(part))
                    {
                        wordCount[part]++;
                    }
                    else
                    {
                        wordCount[part] = 1;
                    }
                } 
            }

            foreach (var name in wordCount)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }

            // No idea, doesn't work correctly, Mimi somehow has 5

        }
    }
}
