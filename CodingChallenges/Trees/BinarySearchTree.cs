namespace CodingChallenges.Trees
{
    public class BinarySearchTree
    {
        public Node? Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }

            var currentNode = Root;

            while (true)
            {
                if (value < currentNode.Value && currentNode.Left == null)
                {
                    currentNode.Left = new Node(value);
                    break;
                }

                if (value < currentNode.Value && currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                    continue;
                }

                if (value > currentNode.Value && currentNode.Right == null)
                {
                    currentNode.Right = new Node(value);
                    break;
                }

                if (value > currentNode.Value && currentNode.Right != null)
                {
                    currentNode = currentNode.Right;
                    continue;
                }

                break;
            }
        }

        public Node? Lookup(int value)
        {
            if (Root == null) return null;

            var currentNode = Root;

            while (true)
            {
                if (currentNode.Value == value) return currentNode;
                if (currentNode.Left?.Value == value) return currentNode.Left;
                if (currentNode.Right?.Value == value) return currentNode.Right;

                if (value < currentNode.Value && currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                    continue;
                }

                if (value > currentNode.Value && currentNode.Right != null)
                {
                    currentNode = currentNode.Right;
                    continue;
                }

                return null;
            }
        }

        public void Remove(int value)
        {

        }

        public List<int> BreadthFirstSearch()
        {
            var result = new List<int>();
            var queue = new Queue<Node>();

            if (Root == null) return result;

            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                if (currentNode.Right != null) queue.Enqueue(currentNode.Right);

                result.Add(currentNode.Value);
            }

            return result;
        }
    }

    public class Node
    {
        public int Value { get; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
