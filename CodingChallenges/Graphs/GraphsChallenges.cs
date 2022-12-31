namespace CodingChallenges.Graphs
{
    public static class GraphsChallenges
    {
        public static void RunGraphs()
        {
            var graph = new UndirectedUnweightedCyclicGraph();

            // 3 --- 4 --- 5
            // |     |     |
            // |     |     |
            // 1 --- 2     6
            //  \   /
            //   \ /
            //    0

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);

            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(6, 5);
        }
    }
}
