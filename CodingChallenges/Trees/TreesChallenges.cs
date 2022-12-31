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
        }
    }
}
