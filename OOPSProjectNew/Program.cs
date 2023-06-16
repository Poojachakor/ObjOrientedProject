namespace OOPSProjectNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 1, 2, 1 };

            
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            
            foreach (int element in arr)
            {
                
                if (frequencyDict.ContainsKey(element))
                {
                    
                    frequencyDict[element]++;
                }
                else
                {
                    
                    frequencyDict[element] = 1;
                }
            }

            // Display the frequency of each element
            foreach (var kvp in frequencyDict)
            {
                Console.WriteLine("Element: {0}, Frequency: {1}", kvp.Key, kvp.Value);
            }
        }
    }

}
    
