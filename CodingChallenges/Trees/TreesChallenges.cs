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

            var tree2 = new BinarySearchTree();

            tree2.Root = new Node(32)
            {
                Left = new Node(26)
                {
                    Left = new Node(19)
                    {
                        Left = null,
                        Right = new Node(27)
                    },
                    Right = null
                },
                Right = new Node(47)
                {
                    Left = null,
                    Right = new Node(56)
                }
            };

            var teste4 = tree2.ValidateBST(tree.Root, tree.Root.Value, null);

            var teste5 = tree.Iterations;
        }
    }
}
