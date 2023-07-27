namespace _2285._Maximum_Total_Importance_of_Roads
{
    internal class Program
    {
         static public long MaximumImportance(int n, int[][] roads)
        {
            var citiesAndRoads = new Dictionary<int, int>();
            var result = 0;
            for(int i = 0; i < n; i++)
            {
                citiesAndRoads.Add(i, 0);
            }

            foreach (var road in roads)
            {
                citiesAndRoads[road[0]]++;
                citiesAndRoads[road[1]]++;
            }
            var sortedCitiesAndRoads = citiesAndRoads.OrderBy(v => v.Value).ToDictionary(c => c.Key , c => c.Value);
            Dictionary<int,int> citiesAndImportance = new Dictionary<int,int>();
            int imp = 1;
            foreach (var city in sortedCitiesAndRoads)
            {
                citiesAndImportance.Add(city.Key, imp);
                imp++;
            }
            
           

            for (int i = 0; i < roads.Length; i++)
            {
                result += citiesAndImportance[roads[i][0]] + citiesAndImportance[roads[i][1]];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[][] roads = new int[][] {
                new int[]{ 0, 1},
                new int[]{1, 2},
                new int[]{2, 3},
                new int[]{0, 2},
                new int[]{1, 3},
                new int[]{2, 4}
            };
            Console.WriteLine(MaximumImportance(5, roads));
        }
    }
}