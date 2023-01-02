namespace CodingChallenges.Trees
{
    public static class TreesChallenges
    {
        public static void RunBinarySearchTree()
        {
            var tree = new BinarySearchTree();
            var lookup1 = tree.Lookup(9);

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            var lookup2 = tree.Lookup(9);
            var lookup3 = tree.Lookup(170);
            var lookup4 = tree.Lookup(50);

            var teste = tree.BreadthFirstSearch();

            var teste1 = tree.DepthFirstSearchInOrderRecursive(tree.Root, new List<int>());

            var teste2 = tree.DepthFirstSearchPreOrderIterative();
            var teste3 = tree.DepthFirstSearchPreOrderRecursive(tree.Root, new List<int>());

            var teste4 = tree.DepthFirstSearchPostOrderRecursive(tree.Root, new List<int>());
        }
    }
}
