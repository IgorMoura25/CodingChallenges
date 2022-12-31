namespace CodingChallenges.Graphs
{
    public class UndirectedUnweightedCyclicGraph
    {
        public int NumberOfNodes { get; private set; } = 0;
        public Dictionary<int, List<int>?> AdjacentList { get; private set; } = new Dictionary<int, List<int>?>();

        public void AddVertex(int node)
        {
            AdjacentList.Add(node, null);

            NumberOfNodes++;
        }

        public void AddEdge(int nodeA, int nodeB)
        {
            if (AdjacentList.ContainsKey(nodeA) == false || AdjacentList.ContainsKey(nodeA) == false) return;

            if (AdjacentList[nodeA] == null) AdjacentList[nodeA] = new List<int>();

            if (AdjacentList[nodeB] == null) AdjacentList[nodeB] = new List<int>();

            AdjacentList[nodeA]?.Add(nodeB);
            AdjacentList[nodeB]?.Add(nodeA);
        }
    }
}
