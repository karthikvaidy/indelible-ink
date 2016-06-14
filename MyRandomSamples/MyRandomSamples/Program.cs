using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace MyRandomSamples
{
    internal class Program
    {
        #region Classes and Enums

        public ColorsEnum color;

        public enum ColorsEnum
        {
            Red = 1,
            Green = 2,
            Black = 3
        }

        public class Node
        {
            public int value;
            public Node leftNode;
            public Node rightNode;

            public Node(int v, Node l, Node r)
            {
                this.value = v;
                this.leftNode = l;
                this.rightNode = r;
            }
        }

        private class Pair
        {
            public int row;
            public int col;

            public Pair(int r, int c)
            {
                row = r;
                col = c;
            }
        }

        public class NaryNode
        {
            public int value;
            public List<NaryNode> children;

            public NaryNode(int v)
            {
                value = v;
                children = new List<NaryNode>();
            }
        }

        public class LRUCache
        {
            private int capacity;
            private Dictionary<int, LRUNode> keyNodeMap;
            private LinkedList<LRUNode> lruNodeList;
            private int numNodes;

            public class LRUNode
            {
                public int key;
                public int value;

                public LRUNode(int k, int v)
                {
                    key = k;
                    value = v;
                }
            }

            public LRUCache(int cap)
            {
                capacity = cap;
                keyNodeMap = new Dictionary<int, LRUNode>();
                lruNodeList = new LinkedList<LRUNode>();
                numNodes = 0;
            }

            public int Get(int key)
            {
                if (keyNodeMap == null)
                {
                    return -1;
                }

                if (keyNodeMap.ContainsKey(key))
                {
                    LRUNode node = keyNodeMap[key];
                    lruNodeList.Remove(node);
                    lruNodeList.AddFirst(node);
                    return node.value;
                }
                else
                {
                    return -1;
                }
            }

            public void Set(int key, int value)
            {
                if (numNodes == capacity)
                {
                    LinkedListNode<LRUNode> node = lruNodeList.Last;
                    lruNodeList.RemoveLast();
                    if (keyNodeMap.ContainsKey(node.Value.key))
                    {
                        keyNodeMap.Remove(node.Value.key);
                    }
                    else
                    {
                        //ERROR CONDITION
                    }
                }

                LRUNode node1 = new LRUNode(key, value);
                lruNodeList.AddFirst(node1);
                keyNodeMap.Add(key, node1);
                numNodes++;
            }

            public override string ToString()
            {
                string s = string.Empty;
                foreach (LRUNode node in lruNodeList)
                {
                    s += (node.key + "  " + node.value + "\n");
                }

                return s;
            }
        }

        public class AStarUnit
        {
            public int row;
            public int col;
            public int cost;

            public AStarUnit(int r, int c, int cs)
            {
                row = r;
                col = c;
                cost = cs;
            }
        }

        public class QueueUsingStacks
        {
            private Stack<int> enqueueStack;
            private Stack<int> dequeueStack;
            private int count;

            public QueueUsingStacks()
            {
                enqueueStack = new Stack<int>();
                dequeueStack = new Stack<int>();
                count = 0;
            }

            public void Enqueue(int i)
            {
                enqueueStack.Push(i);
                count++;
            }

            public int Dequeue()
            {
                if (count == 0)
                    return 0; // throw exception

                if (dequeueStack.Count == 0)
                {
                    while (enqueueStack.Count != 0)
                    {
                        int val = enqueueStack.Pop();
                        dequeueStack.Push(val);
                    }
                }

                if (dequeueStack.Count == 0)
                {
                    return 0; //throw exception - something went wrong.
                }
                int i = dequeueStack.Pop();
                count--;
                return i;
            }

            public bool isEmpty()
            {
                return count == 0;
            }

            public int Count
            {
                get
                {
                    return count;
                }
            }
        }

        public class Person
        {
            public int birth;
            public int death;
            public Person(int b, int d)
            {
                birth = b;
                death = d;
            }
        }

        public class DLLNode
        {
            public int value;
            public DLLNode prev;
            public DLLNode next;

            public DLLNode()
                : this(0)
            {
            }

            public DLLNode(int v)
            {
                value = v;
                prev = null;
                next = null;
            }

            public DLLNode(int v, DLLNode p, DLLNode n)
            {
                value = v;
                prev = p;
                next = n;
            }
        }

        public class DoublyLinkedList
        {
            public DLLNode head;
            public DLLNode tail;
            private int count;

            public DoublyLinkedList()
            {
                head = null;
                tail = null;
                count = 0;
            }

            public void CreateSortedDLL()
            {
                DLLNode node0 = new DLLNode(0, null, null);
                DLLNode node1 = new DLLNode(1, node0, null);
                DLLNode node2 = new DLLNode(2, node1, null);
                DLLNode node3 = new DLLNode(3, node2, null);
                DLLNode node4 = new DLLNode(4, node3, null);
                DLLNode node5 = new DLLNode(5, node4, null);
                DLLNode node6 = new DLLNode(6, node5, null);
                DLLNode node7 = new DLLNode(7, node6, null);
                DLLNode node8 = new DLLNode(8, node7, null);
                DLLNode node9 = new DLLNode(9, node8, null);

                node8.next = node9;
                node7.next = node8;
                node6.next = node7;
                node5.next = node6;
                node4.next = node5;
                node3.next = node4;
                node2.next = node3;
                node1.next = node2;
                node0.next = node1;

                head = node0;
                tail = node9;
            }

            public void InsertInSortedDLL(DLLNode node)
            {
                if (head == null)
                {
                    InsertAtBeginning(node);
                }
                else
                {
                    DLLNode n = head;
                    while (true)
                    {
                        if (n == null)
                            break;
                        if (n == tail)
                        {
                            InsertAtEnd(node);
                            break;
                        }
                        else
                        {
                            if (n.value < node.value && n.next.value >= node.value)
                            {
                                node.next = n.next;
                                node.prev = n;
                                n.next.prev = node;
                                n.next = node;
                                break;
                            }
                            else
                            {
                                n = n.next;
                            }
                        }
                    }
                }
            }

            public void InsertAtBeginning(DLLNode node)
            {
                if (head == null)
                {
                    head = node;
                    tail = node;
                    count = 1;
                }
                else
                {
                    head.prev = node;
                    node.next = head;
                    node.prev = null;

                    head = node;

                    count++;
                }
            }

            public void InsertAtEnd(DLLNode node)
            {
                if (head == null)
                {
                    head = node;
                    tail = node;
                    count = 1;
                }
                else
                {
                    tail.next = node;
                    node.prev = tail;

                    tail = node;
                    count++;
                }
            }

            public DLLNode DeleteAtBeginning()
            {
                if (head == null)
                {
                    return null;
                }

                DLLNode node = head;

                if (head.next == null)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.next;
                    head.prev = null;
                }
                count--;

                node.next = null;
                return node;
            }

            public DLLNode DeleteAtEnd()
            {
                if (head == null)
                {
                    return null;
                }

                DLLNode node = tail;

                if (tail.prev == null)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail = tail.prev;
                    tail.next = null;
                }

                node.prev = null;
                count--;
                return node;
            }

            public int Count
            {
                get 
                { 
                    return count; 
                }
            }

        }

        public class TopologicalSort
        {

            public class TSNode
            {
                public int value;
                public List<TSNode> incomingNodes;
                public List<TSNode> outgoingNodes;

                public TSNode(int v)
                {
                    value = v;
                    outgoingNodes = new List<TSNode>();
                    incomingNodes = new List<TSNode>();
                }

                public void AddOutgoingNode(TSNode n)
                {
                    outgoingNodes.Add(n);
                }

                public void RemoveOutgoingNode(TSNode n)
                {
                    outgoingNodes.Remove(n);
                }

                public void AddIncomingNode(TSNode n)
                {
                    incomingNodes.Add(n);
                }

                public void RemoveIncomingNode(TSNode n)
                {
                    incomingNodes.Remove(n);
                }

            }

            Dictionary<int, TSNode> adjacencyMap;
            List<TSNode> adjacencyNodes;

            // takes string in this format:
            // 1 2;1 3;1 4;3 5;2 5;4 5; 
            public TopologicalSort(string list)
            {
                adjacencyMap = new Dictionary<int, TSNode>();
                adjacencyNodes = new List<TSNode>();
                string[] segments = list.Split(';');
                foreach (string segment in segments)
                {
                    string[] parts = segment.Split(' ');
                    int v0 = Convert.ToInt32(parts[0]);
                    int v1 = Convert.ToInt32(parts[1]);
                    if (!adjacencyMap.ContainsKey(v0))
                    {
                        TSNode n = new TSNode(v0);
                        adjacencyMap.Add(v0, n);
                        adjacencyNodes.Add(n);
                    }
                    if (!adjacencyMap.ContainsKey(v1))
                    {
                        TSNode n = new TSNode(v1);
                        adjacencyMap.Add(v1, n);
                        adjacencyNodes.Add(n);
                    }

                    TSNode incomingNode = adjacencyMap[v0];
                    TSNode outgoingNode = adjacencyMap[v1];

                    incomingNode.AddOutgoingNode(outgoingNode);
                    outgoingNode.AddIncomingNode(incomingNode);
                }
            }

            public string DoTopologicalSort()
            {
                StringBuilder sb = new StringBuilder();
                Queue<int> queue = new Queue<int>();

                foreach (TSNode n in adjacencyNodes)
                {
                    if (n.outgoingNodes.Count == 0)
                    {
                        queue.Enqueue(n.value);
                    }
                }

                while (queue.Count() > 0)
                {
                    int value = queue.Dequeue();
                    TSNode node = adjacencyMap[value];

                    //process that node
                    sb.Append(value);

                    foreach (TSNode n in node.incomingNodes)
                    {
                        n.RemoveOutgoingNode(node);
                        if (n.outgoingNodes.Count == 0)
                        {
                            queue.Enqueue(n.value);
                        }
                    }

                }

                return sb.ToString();

            }

        }

        public class TicTacToe
        {
            private int[,] board;
            private const int dimension = 3;

            private int oneWinner;
            private int twoWinner;

            private List<int> columnValues;
            private List<int> rowValues;
            private int diagonalValue;
            private int reverseDiagonalValue;

            private Dictionary<int, int> map;

            public TicTacToe()
            {
                board = new int[dimension, dimension];
                columnValues = new List<int>();
                rowValues = new List<int>();
                diagonalValue = 1;
                reverseDiagonalValue = 1;

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        board[i, j] = 0;
                    }
                    columnValues.Add(1);
                    rowValues.Add(1);
                }

                map = new Dictionary<int, int>();
                map.Add(0, 2);
                map.Add(1, 3);
                map.Add(2, 5);

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        rowValues[i] *= map[board[i, j]];
                        columnValues[j] *= map[board[i, j]];

                        if (i == j)
                        {
                            diagonalValue *= map[board[i, j]];
                        }
                        else if (i == dimension - j - 1)
                        {
                            reverseDiagonalValue *= map[board[i, j]];
                        }
                    }
                }

                oneWinner = (int)Math.Pow(3, dimension);
                twoWinner = (int)Math.Pow(5, dimension);
            }

            public void initRandomBoard()
            {
                Random rand = new Random();

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        play(i, j, rand.Next(3));
                    }
                }
            }

            public void play(int row, int col, int val)
            {
                if (row < dimension && col < dimension && val > 0 && val < 3 && board[row, col] == 0)
                {
                    board[row, col] = val;

                    rowValues[row] /= map[0];
                    rowValues[row] *= map[val];

                    columnValues[col] /= map[0];
                    columnValues[col] *= map[val];
                }
            }

            public int hasWon()
            {
                int winnerValue;
                foreach (int i in rowValues)
                {
                    winnerValue = isValueWinner(i);
                    if (winnerValue != -1) return winnerValue;
                }
                foreach (int j in columnValues)
                {
                    winnerValue = isValueWinner(j);
                    if (winnerValue != -1) return winnerValue;
                }
                winnerValue = isValueWinner(diagonalValue);
                if (winnerValue != -1) return winnerValue;

                winnerValue = isValueWinner(reverseDiagonalValue);
                if (winnerValue != -1) return winnerValue;

                return -1;
            }

            private int isValueWinner(int i)
            {
                if (i == oneWinner)
                {
                    return 1;
                }
                else if (i == twoWinner)
                {
                    return 2;
                }
                return -1;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        sb.Append(board[i, j] + " ");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();
                foreach (int i in rowValues)
                {
                    sb.Append(i + "  ");
                }
                sb.AppendLine();
                sb.AppendLine();
                foreach (int i in columnValues)
                {
                    sb.Append(i + "  ");
                }
                sb.AppendLine();

                return sb.ToString();
            }
        }

        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
            public override string ToString()
            {
                return "[" + start + "," + end + "]";
            }
        }

        public class Building
        {
            public int left;
            public int right;
            public int height;

            public Building(int[] coords)
            {
                if (coords.Count() == 3)
                {
                    left = coords[0];
                    right = coords[1];
                    height = coords[2];
                }
            }

            public Building(int l,int r, int h)
            {
                    left = l;
                    right = r;
                    height = h;
            }

        }

#endregion

        private static void Main(string[] args)
        {
            Program p = new Program();

            #region OldCode

            /*
            MySection section = (MySection)ConfigurationManager.GetSection("mySection");
            Console.WriteLine(section.MyCollection.Default);
            p.TestMethod();
            string pali = p.findLongestPalindrome("banana");
            Console.WriteLine(pali);
            p.TTS("a");
            Console.WriteLine(p.Negate(10));
            Console.WriteLine(p.Multiply(10, 2));

            int[] nums = { 100, 7, 1, 2, -3 };
            p.getZeroSumSubSequence(nums);

            int[] nums = { 4, 1, 2, 3 };
            p.getPermutations(nums, 5, new List<int>());

            p.findPatternMatch("abba", "redbluebluered");
            p.findPatternMatch("aaaa", "asdasdasdasd");
            p.findPatternMatch("aabb", "xyzabcxzyabc");

            p.findPatternMatchImproved("abba", "redbluebluered");
            p.findPatternMatchImproved("aaaa", "asdasdasdasd");
            p.findPatternMatchImproved("aabb", "xyzabcxzyabc");
            p.findPatternMatchImproved("aabba", "catcatgogocat");

            p.getPermutations(new List<int> { 1, 2, 3 });

            Console.WriteLine(p.binarySearch(new int[] { 1, 2, 3, 4, 5 }, 0, 4, 2));
            Console.WriteLine(p.binarySearch(new int[] { 1, 2, 3, 4, 5 }, 0, 4, 6));
            Console.WriteLine(p.binarySearch(new int[] { 1, 2, 3, 4 }, 0, 3, 6));
            Console.WriteLine(p.binarySearch(new int[] { 1, 2, 3, 4 }, 0, 3, 3));

            p.anagramsMatch(@"C:\VSProjects\MyRandomSamples\MyRandomSamples\wordlist1.txt");

            p.runGetPathSumTests();

            List<string> lines = p.textJustify("This is an example of text justification.", 16);

            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }

            char[,] board = new char[4, 4]{ {'o','a','a','n'},
                                            {'e','t','a','e'},
                                            {'i','h','k','r'},
                                            {'i','f','l','v'}};

            List<string> words = p.FindWords(board, new string[] { "oath", "pea", "eat", "rain" });

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            int[] result = p.longMultiplication(new int[] { 1, 2, 3, 4 }, new int[] { 2 });
            foreach (int i in result)
            {
                Console.Write(i);
            }

            Console.WriteLine(p.getShortestPalindrome("abcdcbaq"));

            LRUCache cache = new LRUCache(5);
            cache.Set(0, 10);
            cache.Set(1, 9);
            cache.Set(2, 8);
            cache.Set(3, 7);
            cache.Set(4, 6);
            Console.WriteLine(cache.ToString());
            cache.Set(5, 5);
            Console.WriteLine(cache.ToString());
            Console.WriteLine(cache.Get(2));
            Console.WriteLine(cache.ToString());
            Console.WriteLine(cache.Get(7));

            Console.WriteLine(p.subStringMatch("abcdefghijlkmnop", "defg"));
            Console.WriteLine(p.subStringMatch("abcdefghijlkmnop", ""));
            Console.WriteLine(p.subStringMatch("", "defg"));
            Console.WriteLine(p.subStringMatch("abcdefghijlkmnop", "defga"));
            Console.WriteLine(p.subStringMatch("abcdefdefgghijlkmnop", "defg"));
            Console.WriteLine(p.subStringMatch("abcdefhdefgghijlkmnop", "defg"));

            Console.WriteLine(p.subStringMatchHash("abcdefghijlkmnop", "defg"));
            Console.WriteLine(p.subStringMatchHash("abcdefghijlkmnop", ""));
            Console.WriteLine(p.subStringMatchHash("", "defg"));
            Console.WriteLine(p.subStringMatchHash("abcdefghijlkmnop", "defga"));
            Console.WriteLine(p.subStringMatchHash("abcdefdefgghijlkmnop", "defg"));
            Console.WriteLine(p.subStringMatchHash("abcdefhdefgghijlkmnop", "defg"));
             
            Console.WriteLine(p.medianOfSortedArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Console.WriteLine(p.medianOfSortedArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 }));
            Console.WriteLine(p.medianOfSortedArrays(new int[] { 1, 2, 3 }, new int[] { }));
            Console.WriteLine(p.medianOfSortedArrays(new int[] { }, new int[] { 4, 5, 6 }));

            Console.WriteLine(p.maxProfit(new int[] { 10, 17, 5, 8, 11, 9 }));

            Console.WriteLine(p.largestNonContiguousSum(new List<int> { 1, -2, 3, -1, 5, 10, 3 }));
            Console.WriteLine(p.maxConcatInt(new List<string> { "24", "35", "917", "91" }));

            Console.WriteLine(p.firstNonrepChar("aabbc"));

            Console.WriteLine(p.firstNonrepChar("aabbcjcddeeiffgghh"));

            int[,] canvas = new int[,] { 
                                        {1, 1, 2, 3},
                                        {1, 2, 4, 3},
                                        {1, 3, 1, 2},
                                        {1, 2, 2, 2}
                                       };

            p.printMatrix(canvas);
            p.floodFill(canvas, 1, 0, 6);
            p.printMatrix(canvas);

            p.getParanCombination(2);

            p.getCombinations("abcd");
            Console.WriteLine(p.multiplyWithoutStar(10, 20));

            NaryNode root = p.createNaryTree();
            p.printAlternate(root);

            List<List<int>> listOfListOfInts = new List<List<int>> {
                                                                    new List<int> {1,2,3,4},
                                                                    new List<int> {1,2},
                                                                    new List<int> {5,6,7,8,2},
                                                                    new List<int> {8,4,6,3,7,2}
                                                                };

            List<int> commonElements = p.getCommonElements(listOfListOfInts);

            foreach (int i in commonElements)
            {
                Console.WriteLine(i);
            }

                        string s = "1234";
            Console.WriteLine(s[0]);

            Console.WriteLine(p.reverseStringOfStrings("abc-efg-hij-klm-nop-qrs"));
            Console.WriteLine(p.reverseStringOfStrings("---"));
            Console.WriteLine(p.reverseStringOfStrings("abc---efg-"));

            List<int> sortedNums = new List<int> { 1, 10, 2, 9, 3, 8, 4, 7, 5, 6 };

            p.QuickSort(sortedNums);
            sortedNums = p.mergeSort(sortedNums);

            foreach (int i in sortedNums)
            {
                Console.WriteLine(i);
            }
 
            Node root = p.buildSampleTree();
            int minVal = Int32.MinValue;
            Console.WriteLine(p.isValidBST(root));
            Console.WriteLine(p.isValidBSTRange(root, Int32.MinValue, Int32.MaxValue));
            Console.WriteLine(p.isValidBSTVal(root, ref minVal));

            root = p.buildValidBinaryTree();
            minVal = Int32.MinValue;
            Console.WriteLine(p.isValidBST(root));
            Console.WriteLine(p.isValidBSTRange(root, Int32.MinValue, Int32.MaxValue));
            Console.WriteLine(p.isValidBSTVal(root, ref minVal));

            Console.WriteLine(p.minCut("ab"));
            Console.WriteLine(p.minCut("aab"));
            Console.WriteLine(p.minCut("abc"));
            Console.WriteLine(p.minCut("abbcbabc"));

            int[,] map = new int[,]
            {
                {1, 2, 3},
                {2, 3, 4},
                {2, 9, 1}
            };

            List<int> costs = p.AStarSearch(map);

            foreach (int i in costs)
            {
                Console.WriteLine(i);
            }
 
            List<int> complements = p.numberComplements(new List<int>() { });
            p.printList(complements);

            complements = p.numberComplements(null);
            p.printList(complements);

            complements = p.numberComplements(new List<int>() { 1, 2, 3, 4, 5, 6, -3, -5 });
            p.printList(complements);

            Console.WriteLine(p.minWindow("ADOBECODEBANC", "ABC"));
            Console.WriteLine(p.minWindow("75902135791158897", "159"));

            Console.WriteLine(p.evaluateExpression("1+2*3+4")); //11
            Console.WriteLine(p.evaluateExpression("1+2*3-4")); //3

            int[,] map = {
                             {1,2,3,1}, 
                             {1,2,4,5}, 
                             {1,2,3,4},
                             {1,2,1,4},
                             {2,2,1,4}
                         };

            List<int> lakes = p.fillLake(map);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j] + "\t");
                }
                Console.WriteLine();
            }

            p.printList(lakes);

            Console.WriteLine(p.IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Console.WriteLine(p.IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
            Console.WriteLine(p.IsInterleave("adbcc", "abbca", "aadbbbcacc"));

            List<string> sol = p.AddOperators("123", 6);
            List<string> sol = p.AddOperators("232", 8);
            List<string> sol = p.AddOperators("105", 5); // fails because digit combination is not accounted for
            List<string> sol = p.AddOperators("00", 0);
            List<string> sol = p.AddOperators("3456237490", 9191);

            foreach (string s in sol)
            {
                Console.WriteLine(s);
            }
              
            Console.WriteLine(p.LongestValidParentheses("(()"));
            Console.WriteLine(p.LongestValidParentheses(")()())"));
            Console.WriteLine(p.LongestValidParentheses(")))"));
            Console.WriteLine(p.LongestValidParentheses("((("));
            Console.WriteLine(p.LongestValidParentheses("())"));
            Console.WriteLine(p.LongestValidParentheses("(()()()()"));
            Console.WriteLine(p.LongestValidParentheses("(((())))"));
            Console.WriteLine(p.LongestValidParentheses("()()()(((()()()()"));

            Console.WriteLine(p.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));

            int[] nums = { 0, 1, 0, 3, 12 };
            int[] nums = { 2, 0, 1, 0, 3, 12 };
            p.MoveZeroes(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            int[] result = p.SetsUnionHash(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 5 });

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            result = p.SetsUnionMerge(new int[] { 1, 2, 3, 3 }, new int[] { 3, 3, 5 });

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Node root = p.buildValidBinaryTree();
            root = p.InvertBinaryTree(root);

            Console.WriteLine(p.IsStrobogrammatic("8"));
            Console.WriteLine(p.IsStrobogrammatic("69"));
            Console.WriteLine(p.IsStrobogrammatic("818"));
            Console.WriteLine(p.IsStrobogrammatic("801689108"));
            Console.WriteLine(p.IsStrobogrammatic("801679108"));
            Console.WriteLine(p.IsStrobogrammatic(" "));
            Console.WriteLine(p.IsStrobogrammatic(null));
            Console.WriteLine(p.IsStrobogrammatic(string.Empty));
            Console.WriteLine(p.IsStrobogrammatic("2")); 
              
                        //Node root = p.buildValidBinaryTree();
            //Console.WriteLine(p.IsBinaryTreeBalanced(root));

            //root = p.buildUnbalancedBinaryTree();
            //Console.WriteLine(p.IsBinaryTreeBalanced(root));

            //int[,] matrix = {{1, 1, 1, 1, 1}, {2, 2, 2, 2, 2}, {3, 3, 3, 3, 3}, {4, 4, 4, 4, 4}, {5, 5, 5, 5, 5}};
            //int[,] matrix = { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 }};
            //p.RotateMatrix(matrix);
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Person p1 = new Person(12, 15);
            //Person p2 = new Person(20, 90);
            //Person p3 = new Person(10, 98);
            //Person p4 = new Person(1, 72);
            //Person p5 = new Person(10, 98);
            //Person p6 = new Person(23, 82);
            //Person p7 = new Person(13, 98);
            //Person p8 = new Person(90, 98);
            //Person p9 = new Person(83, 99);
            //Person p10 = new Person(75, 94);
            //List<Person> people = new List<Person> { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            //Console.WriteLine(p.GetMaxAliveYear(people));

            //Node root = p.buildValidBinaryTree();
            //Console.WriteLine(p.findNodeInBST(root, 2));
            //Console.WriteLine(p.findNodeInBST(root, 0));
            //Console.WriteLine(p.findNodeInBST(root, 10));
            //Console.WriteLine(p.findNodeInBST(null, 2));

            //int[] result = p.longMultiplicationReverse(new int[] { 1, 2, 3, 4 }, new int[] { 2 });
            //int[] result = p.longMultiplicationReverse(new int[] { 1, 2, 3, 4 }, new int[] { 9 });
            //int[] result = p.longMultiplicationReverse(new int[] { 2, 9, 8, 8, 9, 8 }, new int[] { 3, 6, 3, 4, 5, 8, 9, 1, 2 }); //{1,0,8,6,3,7,1,4,1,8,7,8,9,7,6}
            //foreach (int i in result)
            //{
            //    Console.Write(i);
            //}

            //DoublyLinkedList dll = new DoublyLinkedList();
            //DLLNode node;
            //node = dll.DeleteAtEnd();
            //node = dll.DeleteAtBeginning();
            //dll.InsertAtBeginning(new DLLNode(5));
            //dll.InsertAtBeginning(new DLLNode(10));
            //dll.InsertAtBeginning(new DLLNode(15));
            //dll.InsertAtEnd(new DLLNode(50));
            //dll.InsertAtEnd(new DLLNode(60));
            //dll.InsertAtEnd(new DLLNode(70));
            //Console.WriteLine(dll.Count);
            //node = dll.DeleteAtEnd();
            //Console.WriteLine(node.value);
            //node = dll.DeleteAtBeginning();
            //Console.WriteLine(node.value);
            //Console.WriteLine(dll.Count);

            //dll = new DoublyLinkedList();
            //dll.CreateSortedDLL();
            //dll.InsertInSortedDLL(new DLLNode(4));
 
            */

            #endregion

            //IsBinaryTreeBalanced
            //RotateMatrix
            //TopologicalSort
            //BST to DLL

            // substring search
            // matrix update element with subsum
            // FB => FooBar
            // tic tac toe

            //Console.WriteLine(p.maxNonContinuousSum(new List<int> { 1, -2, 3, -1, 5, 10, 3 }));

            //List<int> nums = new List<int> { 4, 1, 2, 3 };
            //p.GetCombinationSums(nums, 5);

            //p.generateCombinations("star");

            //Console.WriteLine(p.isPatternMatch("FB", "FooBar"));
            //Console.WriteLine(p.isPatternMatch("FB", "FooFootBar"));
            //Console.WriteLine(p.isPatternMatch("FoBa", "FooBar"));
            //Console.WriteLine(p.isPatternMatch("FoBa", "FooBt"));
            //Console.WriteLine(p.isPatternMatch("FBr", "FooBro"));
            //Console.WriteLine(p.isPatternMatch("FBr", "FttBoo"));

            //Console.WriteLine(p.getNthLargestMultiple(new int[] { 4, 6 }, 6));
            //int[] result = p.GetMaxMergedArray(new int[] { 3, 4, 6, 5 }, new int[] { 9, 1, 2, 5, 8, 3 }, 5);
            //int[] result = p.GetMaxMergedArray(new int[] { 4, 5 }, new int[] { 9, 1, 8, 6 }, 5);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //TopologicalSort ts = new TopologicalSort("1 2;1 3;1 4;3 5;2 5;4 5");
            //Console.WriteLine(ts.DoTopologicalSort());

            //Console.WriteLine(p.isPatternMatchImproved("abba", "redbluebluered"));
            //Console.WriteLine(p.isPatternMatchImproved("aaaa", "asdasdasdasd"));
            //Console.WriteLine(p.isPatternMatchImproved("aabb", "xyzabcxzyabc"));
            //Console.WriteLine(p.isPatternMatchImproved("aabb", "xyzabcxzyabce"));
            //Console.WriteLine(p.isPatternMatchImproved("aabba", "catcatgogocat"));

            //Console.WriteLine(p.isBinaryPalindrome(0));
            //Console.WriteLine(p.isBinaryPalindrome(25));

            //Interval i0 = new Interval(1, 2);
            //Interval i1 = new Interval(3, 5);
            //Interval i2 = new Interval(6, 7);
            //Interval i3 = new Interval(8, 10);
            //Interval i4 = new Interval(12, 16);
            //List<Interval> intervals = new List<Interval> { i0, i1, i2, i3, i4 };
            //Interval i5 = new Interval(4, 9);

            //Interval i0 = new Interval(1, 3);
            //Interval i1 = new Interval(6, 9);
            //List<Interval> intervals = new List<Interval> { i0, i1 };
            //Interval i5 = new Interval(2, 5);

            //List<Interval> result = p.Insert(intervals, i5).ToList();

            //foreach(Interval i in result)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //TicTacToe ttt = new TicTacToe();
            //Console.WriteLine(ttt.ToString());
            //ttt.initRandomBoard();
            //Console.WriteLine(ttt.ToString());
            //Console.WriteLine(ttt.hasWon());

            //int[,] buildings = { { 2, 9, 10 }, { 3, 7, 15 }, { 5, 12, 12 }, { 15, 20, 10 }, { 19, 24, 8 } };
            //p.GetSkyline(buildings);

            //Console.WriteLine(p.IsScramble("great", "rgtae"));

            //int[] result = p.slidingWindowMax(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> combos = p.getWordCombinations("1234");

            //foreach (string str in combos)
            //{
            //    Console.WriteLine(str);
            //}

            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
            dictionary.Add("i", true);
            dictionary.Add("in", true);
            dictionary.Add("int", true);
            dictionary.Add("this", true);
            dictionary.Add("is", true);
            dictionary.Add("his", true);
            dictionary.Add("case", true);

            ResultSet rs = p.parseString("inthiscase", dictionary);
            Console.WriteLine(rs.numUnmatched + " " + rs.parsedString);

            Node two = new Node(2);
            Node eight = new Node(8);
            eight.left = two;
            Node six = new Node(6);
            Node negthree = new Node(-3);
            negthree.left = eight;
            negthree.right = six;
            Node one = new Node(1);
            Node three = new Node(3);
            three.left = one;
            Node negOne = new Node(-1);
            one.left = negOne;
            Node root = new Node(2);
            root.left = three;
            root.right = negthree;

            p.getPathsSum(root, 5);
        }

        public double getMaxRange(double[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0.0;

            double maxProfit = Double.MinValue;
            double currMin = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                double profit = prices[i] - currMin;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }

                if (prices[i] < currMin)
                    currMin = prices[i];
            }

            return maxProfit;
        }

        public List<List<int>> getPathsSum(Node root, int sum)
        {
            List<List<int>> paths = new List<List<int>>();

            getPathsSumInner(root, sum, 0, paths, new List<int>());

            foreach (List<int> path in paths)
            {
                foreach (int i in path)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            return paths;
        }

        private void getPathsSumInner(Node root, int sum, int currSum, List<List<int>> paths, List<int> currPath)
        {
            if (root == null)
                return;

            currPath.Add(root.Value);
            currSum += root.Value;

            if (currSum == sum)
            {
                List<int> path = new List<int>();
                foreach (int i in currPath)
                    path.Add(i);
                paths.Add(path);
            }

            List<int> path1 = new List<int>();
            List<int> path2 = new List<int>();
            foreach (int i in currPath)
            {
                path1.Add(i);
                path2.Add(i);
            }

            getPathsSumInner(root.left, sum, currSum, paths, path1);
            getPathsSumInner(root.right, sum, currSum, paths, path2);
        }

        public class Node
        {
            public int Value;
            public Node left;
            public Node right;
            public Node(int x)
            {
                Value = x;
            }
        }

        public string reverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            char[] stringAsArray = s.ToCharArray();

            for (int i = 0; i < stringAsArray.Length / 2; i++)
            {
                char temp = stringAsArray[i];
                stringAsArray[i] = stringAsArray[s.Length - i - 1];
                stringAsArray[s.Length - i - 1] = temp;
            }

            int ctr = 0;
            int startIndex = -1;
            int endIndex = -1;

            while (ctr != stringAsArray.Length)
            {
                if (stringAsArray[ctr] != ' ')
                {
                    if (startIndex == -1)
                    {
                        startIndex = ctr;
                    }
                }
                else
                {
                    endIndex = ctr - 1;
                }

                if (startIndex >= 0 && endIndex >= 0 && startIndex < endIndex)
                {
                    int numChar = endIndex - startIndex;
                    for (int i = 0; i <= numChar / 2; i++)
                    {
                        char temp = stringAsArray[startIndex + i];
                        stringAsArray[startIndex + i] = stringAsArray[endIndex - i];
                        stringAsArray[endIndex - i] = temp;
                    }
                    startIndex = -1;
                }

                ctr++;
            }

            endIndex = ctr - 1;

            if (startIndex < endIndex && startIndex >= 0)
            {
                endIndex = s.Length - 1;

                int numChar = endIndex - startIndex;
                for (int i = 0; i <= numChar / 2; i++)
                {
                    char temp = stringAsArray[startIndex + i];
                    stringAsArray[startIndex + i] = stringAsArray[endIndex - i];
                    stringAsArray[endIndex - i] = temp;
                }
            }

            return new string(stringAsArray);
        }

        public ResultSet parseString(string text, Dictionary<string, bool> dictionary)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            Dictionary<string, ResultSet> resultSetMemo = new Dictionary<string, ResultSet>();
            ResultSet result = this.parseText(text, dictionary, resultSetMemo);

            return result;
        }

        private ResultSet parseText(string text, Dictionary<string, bool> dictionary, Dictionary<string, ResultSet> resultSetMemo)
        {
            if (text.Length == 0)
            {
                return new ResultSet(0, "");
            }
            else if (resultSetMemo.ContainsKey(text))
            {
                return resultSetMemo[text];
            }

            ResultSet result = new ResultSet(text.Length, text);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
                ResultSet rs = this.parseText(text.Substring(i+1), dictionary, resultSetMemo);
                int num = sb.ToString().Length;
                if (dictionary.ContainsKey(sb.ToString()))
                {
                    num = 0;
                }

                if (num + rs.numUnmatched < result.numUnmatched)
                {
                    result.numUnmatched = num + rs.numUnmatched;
                    result.parsedString = sb.ToString() +" "+ rs.parsedString;

                    if (result.numUnmatched == 0)
                        break;
                }
            }
            resultSetMemo.Add(text, result);

            return result;
        }

        public class ResultSet
        {
            public int numUnmatched;
            public string parsedString;
            public ResultSet(int num, string ps)
            {
                this.numUnmatched = num;
                this.parsedString = ps;
            }
        }


        public List<string> getWordCombinations(string number)
        {
            if (string.IsNullOrEmpty(number))
                return new List<string>();

            List<string> combinations = new List<string>();

            if (number.Length == 1)
            {

                return new List<string>() { ((char)('a' + (int)Char.GetNumericValue(number[0]))).ToString() };
            }

            int n = number[0] - '0';
            List<string> combinations1 = getWordCombinations(number.Substring(1));
            List<string> combinedCombinations1 = new List<string>();
            foreach (string s in combinations1)
            {
                string appendedString = ((char)('a' + n)).ToString() + s;
                combinedCombinations1.Add(appendedString);
            }

            combinations.AddRange(combinedCombinations1);

            if (number.Length > 1)
            {
                int m = number[1] - '0';
                int num = n * 10 + m;
                if (num < 26)
                {
                    List<string> combinations2 = getWordCombinations(number.Substring(2));
                    List<string> combinedCombinations2 = new List<string>();
                    foreach (string s in combinations2)
                    {
                        string appendedString = ((char)('a' + num)).ToString() + s;
                        combinedCombinations2.Add(appendedString);
                    }

                    combinations.AddRange(combinedCombinations2);
                }
            }

            return combinations;
        }

        // Solution s = new Solution();
        //Console.WriteLine(s.MaxSumSubsequence(new int[] {3,-1,0,-4,0,-1,-4,2,4,1,1,3,1,0,-2,-3,-3}));
        //Console.WriteLine(s.MaxSumSubsequence(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}));
        // s.maxIncreasingSubsequence(new List<int>(){5,6,7,1,2,3,4,2,4});
                                                   // 0,0,0,3,3,3,3,7,7
        // s.maxIncreasingSubsequence(new List<int>(){5});
        // Console.WriteLine(s.rodCut(8, new int[]{1,5,8,9,10,17,17,20}));

        // cut length long rod into smaller pieces so as to optimize total price
        public int rodCut(int length, int[] prices)
        {
            if (length > prices.Length)
                return 0;

            Dictionary<int, int> memoPriceForLen = new Dictionary<int, int>();

            return this.rodCutInner(length, prices, memoPriceForLen);
        }

        private int rodCutInner(int length, int[] prices, Dictionary<int, int> memoPriceForLen)
        {
            if (memoPriceForLen.ContainsKey(length))
                return memoPriceForLen[length];

            if (length <= 0)
                return 0;

            int maxPrice = 0;
            for (int i = 0; i < length; i++)
            {
                int price = prices[i] + rodCutInner(length - i - 1, prices, memoPriceForLen);
                if (price > maxPrice)
                {
                    maxPrice = price;
                }
            }
            memoPriceForLen.Add(length, maxPrice);

            return maxPrice;
        }

        public void maxIncreasingSubsequence(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return;

            if (nums.Count == 1)
            {
                Console.WriteLine(nums[0]);
            }

            List<int> indexes = new List<int>();
            indexes.Add(0);
            int maxLen = 1;
            int endIndex = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    int lastNum = indexes[indexes.Count - 1];
                    indexes.Add(lastNum);
                    int tempLen = i - indexes[indexes.Count - 1] + 1;
                    if (tempLen > maxLen)
                    {
                        maxLen = tempLen;
                        endIndex = i;
                    }
                }
                else
                {
                    indexes.Add(i);
                }
            }

            for (int i = endIndex - maxLen + 1; i <= endIndex; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

        public int MaxSumSubsequence(int[] array)
        {
            if (array == null || array.Length == 0)
                return Int32.MinValue;

            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                    maxSum = sum;
                if (sum < 0)
                    sum = 0;
            }
            return maxSum;
        }

        public int maxZeroSubMatrix(int[,] matrix)
        {
            int maxSize = 0;

            if (matrix == null)
                return maxSize;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[,] memo = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (matrix[i, j] == 0)
                        {
                            memo[i, j] = 1;
                            if (maxSize < 1)
                                maxSize = 1;
                        }
                        else
                            memo[i, j] = 0;
                    }
                    else
                    {
                        if (matrix[i, j] == 0)
                        {
                            int d = memo[i - 1, j - 1];
                            int u = memo[i - 1, j];
                            int l = memo[i, j - 1];

                            int min = d;
                            if (l < d) min = l;
                            if (u < l) min = u;

                            min++;

                            memo[i, j] = min;
                            if (min > maxSize)
                                maxSize = min;
                        }
                        else
                            memo[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(memo[i, j] + " ");
                }
                Console.WriteLine();
            }

            return maxSize; ;
        }


        /*
        https://leetcode.com/problems/sliding-window-maximum/

        Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

        For example,
        Given nums = [1,3,-1,-3,5,3,6,7], and k = 3.

        Window position                Max
        ---------------               -----
        [1  3  -1] -3  5  3  6  7       3
         1 [3  -1  -3] 5  3  6  7       3
         1  3 [-1  -3  5] 3  6  7       5
         1  3  -1 [-3  5  3] 6  7       5
         1  3  -1  -3 [5  3  6] 7       6
         1  3  -1  -3  5 [3  6  7]      7
        Therefore, return the max sliding window as [3,3,5,5,6,7].

        Note: 
        You may assume k is always valid, ie: 1 ≤ k ≤ input array's size for non-empty array.

        Follow up:
        Could you solve it in linear time?
        */
        public int[] slidingWindowMax(int[] array, int w)
        {
            int[] ans = new int[array.Length - w + 1];
            LinkedList<int> q = new LinkedList<int>();

            for (int i = 0; i < array.Length; i++)
            {
                // 1. remove element from head until first number within window
                if (q.Count != 0 && q.ElementAt(0) + w <= i)
                {
                    q.RemoveFirst();
                }

                // 2. before inserting i into queue, remove from the tail of the queue indices with smaller value they array[i]
                while (q.Count !=0 && array[q.ElementAt(q.Count - 1)] <= array[i])
                {
                    int val = q.ElementAt(q.Count - 1);
                    q.Remove(val);
                }
                q.AddLast(i);

                // 3. set the max value in the window 
                if (i + 1 >= w)
                {
                    ans[i + 1 - w] = array[q.ElementAt(0)];
                }
            }
            return ans;
        }

        /*
            https://leetcode.com/problems/scramble-string/
            Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.

            Below is one possible representation of s1 = "great":

                great
               /    \
              gr    eat
             / \    /  \
            g   r  e   at
                       / \
                      a   t
            To scramble the string, we may choose any non-leaf node and swap its two children.

            For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".

                rgeat
               /    \
              rg    eat
             / \    /  \
            r   g  e   at
                       / \
                      a   t
            We say that "rgeat" is a scrambled string of "great".

            Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".

                rgtae
               /    \
              rg    tae
             / \    /  \
            r   g  ta  e
                   / \
                  t   a
            We say that "rgtae" is a scrambled string of "great".

            Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.
            */
        public bool IsScramble(string s1, string s2)
        {
            // error cases
            if (s1 == null || s2 == null || s1.Length != s2.Length)
            {
                return false;
            }

            // validation cases
            s1 = s1.ToLowerInvariant();
            s2 = s2.ToLowerInvariant();

            int[] charCount = new int[26];
            foreach (int i in charCount)
            {
                charCount[i] = 0;
            }

            foreach (char ch in s1)
            {
                charCount[ch - 'a']++;
            }

            foreach (char ch in s2)
            {
                charCount[ch - 'a']--;
            }

            foreach (int i in charCount)
            {
                if (charCount[i] != 0)
                {
                    return false;
                }
            }

            // call inner recursive method
            return isScrambleInner(s1, s2);
        }

        private bool isScrambleInner(string s1, string s2)
        {
            // base case
            if (s1.Length != s2.Length)
                return false;

            if (s1.Length == 1)
            {
                if (s1[0] == s2[0])
                {
                    return true;
                }
                return false;
            }

            // algo
            int len = s1.Length;
            for (int i = 1; i < len; i++)
            {
                if (isScrambleInner(s1.Substring(0, i), s2.Substring(0, i)) && isScrambleInner(s1.Substring(i), s2.Substring(i)))
                {
                    return true;
                }

                if (isScrambleInner(s1.Substring(0, i), s2.Substring(len - i)) && isScrambleInner(s1.Substring(i), s2.Substring(0, len - i)))
                {
                    return true;
                }
            }

            return false;
        }

        /*
            https://leetcode.com/problems/the-skyline-problem/
            A city's skyline is the outer contour of the silhouette formed by all the buildings in that city when viewed from a distance. Now suppose you are given the locations and height of all the buildings as shown on a cityscape photo (Figure A), write a program to output the skyline formed by these buildings collectively (Figure B).
            The geometric information of each building is represented by a triplet of integers [Li, Ri, Hi], where Li and Ri are the x coordinates of the left and right edge of the ith building, respectively, and Hi is its height. It is guaranteed that 0 ≤ Li, Ri ≤ INT_MAX, 0 < Hi ≤ INT_MAX, and Ri - Li > 0. You may assume all buildings are perfect rectangles grounded on an absolutely flat surface at height 0.
            For instance, the dimensions of all buildings in Figure A are recorded as: [ [2 9 10], [3 7 15], [5 12 12], [15 20 10], [19 24 8] ] .
            The output is a list of "key points" (red dots in Figure B) in the format of [ [x1,y1], [x2, y2], [x3, y3], ... ] that uniquely defines a skyline. A key point is the left endpoint of a horizontal line segment. Note that the last key point, where the rightmost building ends, is merely used to mark the termination of the skyline, and always has zero height. Also, the ground in between any two adjacent buildings should be considered part of the skyline contour.
            For instance, the skyline in Figure B should be represented as:[ [2 10], [3 15], [7 12], [12 0], [15 10], [20 8], [24, 0] ].
         */
        public IList<int[]> GetSkyline(int[,] buildings)
        {
            List<Building> listOfBuildings = new List<Building>();
            List<Tuple<int, int>> listOfEdges = new List<Tuple<int, int>>();

            int numBuildings = buildings.GetLength(0);
            for (int i = 0; i < numBuildings; i++)
            {
                Building b = new Building(buildings[i, 0], buildings[i, 1], buildings[i, 2]);
                listOfBuildings.Add(b);
            }

            //Sort by left value
            listOfBuildings.Sort(BuildingCompare);

            foreach (Building b in listOfBuildings)
            {
                List<Building> buildingsCopy = new List<Building>();
                foreach (Building bldg in listOfBuildings)
                {
                    buildingsCopy.Add(bldg);
                }
                buildingsCopy.Remove(b);

                if (isBuildingEdgeVisible(buildingsCopy, b.left, b.height))
                {
                    listOfEdges.Add(new Tuple<int, int>(b.left, b.height));
                }
                if (isBuildingEdgeVisible(buildingsCopy, b.right, b.height))
                {
                    listOfEdges.Add(new Tuple<int, int>(b.right, b.height));
                }
            }

            foreach (Tuple<int, int> t in listOfEdges)
            {
                Console.WriteLine(t.Item1 + "  " + t.Item2);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Tuple<int, int>> skyline = new List<Tuple<int, int>>();
            // Collapse
            skyline.Add(listOfEdges[0]);
            for (int i = 1; i < listOfEdges.Count(); i++)
            {
                Tuple<int, int> t = listOfEdges[i];
                Tuple<int, int> prevT = listOfEdges[i - 1];
                if (t.Item2 == prevT.Item2)
                {
                    continue;
                }
                skyline.Add(t);
            }

            foreach (Tuple<int, int> t in skyline)
            {
                Console.WriteLine(t.Item1 + "  " + t.Item2);
            }

            return null;

        }

        private int BuildingCompare(Building a, Building b)
        {
            return (a.left - b.left);
        }

        private bool isBuildingEdgeVisible(List<Building> listOfBuildings, int edge, int height)
        {
            foreach (Building b in listOfBuildings)
            {

                if (b.left > edge)
                    break;

                if (b.left <= edge && b.right >= edge && b.height >= height)
                {
                    return false;
                }
            }
            return true;
        }

        // https://leetcode.com/problems/insert-interval/
        /*
        Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).

        You may assume that the intervals were initially sorted according to their start times.

        Example 1:
        Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9].
        
        Example 2:
        Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].

        This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].
        */
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            // error checks
            // intervals is null
            // newInterval is null

            Interval mergedInterval = new Interval();
            int startIndex = -1;
            int endIndex = -1;

            for (int i = 0; i < intervals.Count(); i++)
            {
                Interval interval = intervals[i];
                if (startIndex == -1)
                {
                    if (
                        ((interval.start <= newInterval.start) && (interval.end >= newInterval.start)) ||
                        (interval.start > newInterval.start)
                        )
                    {
                        startIndex = i;
                        mergedInterval.start = (interval.start < newInterval.start) ? interval.start : newInterval.start;
                        i--;
                    }
                }
                else if (endIndex == -1)
                {
                    if((interval.start <= newInterval.end) && (interval.end >= newInterval.end))
                    {
                        endIndex = i;
                        mergedInterval.end = interval.end;
                        break;
                    }
                    else if (interval.start > newInterval.end)
                    {
                        if (i == 0)
                        {
                            endIndex = 0;
                            mergedInterval.end = interval.end;
                        }
                        else
                        {
                            endIndex = i - 1;
                            mergedInterval.end = newInterval.end;
                        }
                    }
                }
            }

            intervals[startIndex] = mergedInterval;
            startIndex++;
            for (int i = startIndex; i <= endIndex; i++)
            {
                intervals.RemoveAt(startIndex);
            }

            return intervals;
        }

        public bool isBinaryPalindrome(int x)
        {
            int mask1 = 1 << 31;
            int mask2 = 1;
            for (int i = 0; i < 16; i++)
            {
                if ((x & mask1) != (x & mask2))
                {
                    return false;
                }
                mask1 = mask1 >> 1;
                mask2 = mask2 << 1;
            }
            return true;
        }

        public bool isPatternMatchImproved(string pattern, string text)
        {
            int na = countChars(pattern, 'a');
            int nb = pattern.Length - na;
            char firstChar = pattern[0];
            char altChar = (firstChar == 'a') ? 'b' : 'a';
            int firstCharCount = (firstChar == 'a') ? na : nb;
            int altCharCount = (firstChar == 'a') ? nb : na;
            int maxLen = text.Length / firstCharCount;

            for (int i = 1; i < maxLen; i++)
            {
                int j = (text.Length - (i * firstCharCount));
                if (altCharCount == 0 || (j % altCharCount == 0))
                {
                    if (doesStringMatch(pattern, text, i, (altCharCount == 0) ? 0 : (j / altCharCount)))
                    {
                        return true;
                    }

                }
            }

            return false;

        }

        private int countChars(string s, char c)
        {
            int count = 0;
            foreach (char ch in s)
            {
                count = (ch == c) ? count+1 : count;
            }
            return count;
        }

        private bool doesStringMatch(string pattern, string text, int firstCharLen, int altCharLen)
        {
            Dictionary<char, string> map = new Dictionary<char, string>();
            map.Add(pattern[0], text.Substring(0, firstCharLen));
            int textIndex = 0;
            foreach (char c in pattern)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, text.Substring(textIndex, altCharLen));
                }
                int endIndex = textIndex + map[c].Length;

                if (text.Substring(textIndex, endIndex) != map[c])
                {
                    return false;
                }

            }

            return true;
        }

        /*
            You are given two arrays of length M and N having elements in range 0-9.
            Your task is to create maximum number of length K from elements of these two arrays such that relative order of elements 
            is same in the final number as in the array, they are taken from i.e. 
            If two elements a,b are taken from array1 and and a comes before b in array1 so 
            in the final number a should come before b (Relative order kept same) . 
            Example: N=4 and M =6 
            Array1 = { 3 , 4 , 6,5} 
            Array2 ={9,1,2,5,8,3} 
            Suppose K = 5, then number will be {9,8,6,5,3} 
            You can see {9,8,3} are taken from array2 in the same order as they are in Array2. Similarly {6,5} are taken from Array1 in the 
            same order and number 98653 is maximum possible number.
         */
        public int[] GetMaxMergedArray(int[] array1, int[] array2, int k)
        {
            if (array1 == null && array2 == null)
                return null;

            if (array1 == null && array2 != null)
            {
                int count = array2.Count() > k ? k : array2.Count();
                return array2.Take(count).ToList().ToArray();
            }

            if (array1 != null && array2 == null)
            {
                int count = array1.Count() > k ? k : array1.Count();
                return array1.Take(count).ToList().ToArray();
            }

            if (array1.Count() + array2.Count() < k)
            {
                //exception!?
                k = array1.Count() + array2.Count();
            }

            int[] result = GetMaxMergedArrayInner(array1, array2, 0, 0, k, k, new List<int>());
            return result;
        }

        private int[] GetMaxMergedArrayInner(int[] array1, int[] array2, int index1, int index2, int k, int remaining, List<int> currState)
        {
            if (currState != null)
            {
                Console.Write("Current state: ");
                foreach (int i in currState)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            if (remaining == 0)
            {
                if (currState.Count() == k)
                {
                    return currState.ToArray();
                }
                return new List<int>().ToArray();
            }
            int[] result = new List<int>().ToArray();

            if (index1 < array1.Length && index2 < array2.Length)
            {
                List<int> temp1 = getListCopy(currState);
                temp1.Add(array1[index1]);
                List<int> temp2 = getListCopy(currState);
                temp2.Add(array2[index2]);

                int[] candidate1 = GetMaxMergedArrayInner(array1, array2, index1 + 1, index2, k, remaining - 1, temp1); 
                int[] candidate2 = GetMaxMergedArrayInner(array1, array2, index1, index2 + 1, k, remaining - 1, temp2);
                int[] tempResult = getGreaterArray(candidate1, candidate2);

                int[] ignoredCandidate = GetMaxMergedArrayInner(array1, array2, index1 + 1, index2 + 1, k, remaining, getListCopy(currState));
                result = getGreaterArray(ignoredCandidate, tempResult);
            }
            else if (index1 < array1.Length)
            {
                List<int> temp = getListCopy(currState);
                temp.Add(array1[index1]);
                int[] tempResult = GetMaxMergedArrayInner(array1, array2, index1 + 1, index2, k, remaining - 1, temp);
                int[] ignoredCandidate = GetMaxMergedArrayInner(array1, array2, index1 + 1, index2, k, remaining, getListCopy(currState));
                result = getGreaterArray(ignoredCandidate, tempResult);
            }
            else if (index2 < array2.Length)
            {
                List<int> temp = getListCopy(currState);
                temp.Add(array2[index2]);
                int[] tempResult = GetMaxMergedArrayInner(array1, array2, index1, index2 + 1, k, remaining - 1, temp);
                int[] ignoredCandidate = GetMaxMergedArrayInner(array1, array2, index1, index2 + 1, k, remaining, getListCopy(currState));
                result = getGreaterArray(ignoredCandidate, tempResult);
            }

            return result;
        }

        private List<int> getListCopy(List<int> list)
        {
            List<int> copy = new List<int>();
            foreach (int i in list)
            {
                copy.Add(i);
            }
            return copy;
        }

        private int[] getGreaterArray(int[] a, int[] b)
        {
            if (a.Length > b.Length)
                return a;
            else if (a.Length < b.Length)
                return b;
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b[i])
                        return a;
                    else if (a[i] < b[i])
                        return b;
                }

                return a;
            }

        }

        /*
            Find the n-th smallest multiple given a set of numbers. For example, set = {4, 6}, n = 6: 
            The sequence is: 
            4, 6, 8, 12, 16, 18, etc... 
            Answer is 18
         * 
         * MODIFIED TO: return nth number that is a pure factor of given numbers.
        */
        public int getNthLargest(int[] set, int n)
        {
            if (set == null || set.Count() == 0 || n <= 0)
            {
                return -1; // exception?!
            }
            // set has negative numbers?
            // set has 1 or 0
            // set has repetitions
            // set has only 1 element, return Math.Pow(element,n)
            // n == 1, return smallest of set

            int ctr = 0;
            int val = 0;

            List<Dictionary<int,LinkedList<int>>> listOfLists = new List<Dictionary<int,LinkedList<int>>>();

            foreach (int i in set)
            {
                LinkedList<int> ll = new LinkedList<int>();
                ll.AddFirst(i);
                Dictionary<int,LinkedList<int>> dict = new Dictionary<int,LinkedList<int>>();
                dict.Add(i,ll);
                listOfLists.Add(dict);
            }

            while (ctr <= n)
            {
                int min = Int32.MaxValue;
                
                foreach (Dictionary<int,LinkedList<int>> dict in listOfLists)
                {
                    int key = dict.Keys.First();
                    LinkedList<int> ll = dict[key];
                    if (ll.First.Value < min)
                    {
                        min = ll.First.Value;
                    }
                }
                
                ctr++;
                if (ctr == n)
                {
                    val = min;
                    break;
                }

                foreach (Dictionary<int, LinkedList<int>> dict in listOfLists)
                {
                    int key = dict.Keys.First();
                    LinkedList<int> ll = dict[key];
                    if (ll.First.Value == min)
                    {
                        ll.RemoveFirst();
                    }
                    ll.AddLast(min * key);
                }
            }

            return val;
        }

        public int getNthLargestMultiple(int[] set, int n)
        {
            if (set == null || set.Count() == 0)
            {
                return -1;
            }

            List<Tuple<int, int>> listOfTuples = new List<Tuple<int, int>>();

            foreach (int i in set)
            {
                Tuple<int, int> t = new Tuple<int, int>(i, i);
                listOfTuples.Add(t);
            }

            int ctr = 0;
            int val = -1;
            int prevVal = -1;

            while (ctr < n)
            {
                prevVal = val;
                Tuple<int, int> minTuple = listOfTuples[0];
                foreach (Tuple<int, int> t in listOfTuples)
                {
                    if (t.Item2 < minTuple.Item2)
                    {
                        minTuple = t;
                    }
                }

                val = minTuple.Item2;

                if (val != prevVal)
                {
                    ctr++;
                }

                Console.WriteLine(ctr + "  " + val);

                if (ctr == n)
                {
                    break;
                }

                Tuple<int, int> updatedTuple = new Tuple<int, int>(minTuple.Item1, minTuple.Item1 * ((minTuple.Item2 / minTuple.Item1) + 1));
                listOfTuples.Remove(minTuple);
                listOfTuples.Add(updatedTuple);
            }

            return val;
        }

        public bool isPatternMatch(string pattern, string text)
        {
            if (string.IsNullOrEmpty(pattern))
            {
                if (string.IsNullOrEmpty(text))
                {
                    // both are empty.
                    return true;
                }
                return false; // only pattern is empty
            }
            if (string.IsNullOrEmpty(text)) // tex is empty, pattern is not
                return false;

            int patternCtr = 0;
            int textCtr = 0;
            bool isMatch = false;
            bool shouldIgnoreSmallLetter = true;

            while (true)
            {
                if (textCtr == text.Length)
                {
                    if (patternCtr == pattern.Length)
                    {
                        isMatch = true; // both pattern and text are at end, and has matched till now.
                    }
                    else
                    {
                        isMatch = false; // text is at end but pattern still has characters
                    }
                    break;
                }

                if (patternCtr == pattern.Length) // pattern is done, text still has characters. ensure all remaining characters are small, if not no match.
                {
                    while (textCtr != text.Length)
                    {
                        if (text[textCtr] >= 'a' && text[textCtr] <= 'z')
                        {
                            textCtr++;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    isMatch = true;
                    break;
                }

                if (pattern[patternCtr] >= 'a' && pattern[patternCtr] <= 'z')
                {
                    shouldIgnoreSmallLetter = false;
                }
                else if (pattern[patternCtr] >= 'A' && pattern[patternCtr] <= 'Z')
                {
                    shouldIgnoreSmallLetter = true;
                }

                if (text[textCtr] >= 'a' && text[textCtr] <= 'z')
                {
                    if (shouldIgnoreSmallLetter) //pattern char is caps, so ignore all small letters
                    {
                        textCtr++;
                    }
                    else // pattern has small letter. see if there's a match
                    {
                        if (text[textCtr] == pattern[patternCtr]) // match found. increment both ctrs
                        {
                            textCtr++;
                            patternCtr++;
                        }
                        else //no match. increment only text ctr.
                        {
                            textCtr++;
                        }
                    }
                }
                else if (text[textCtr] >= 'A' && text[textCtr] <= 'Z')
                {
                    if (shouldIgnoreSmallLetter) // if true, we're matching a caps text char with caps pattern char
                    {
                        if (text[textCtr] == pattern[patternCtr]) // match found. increment both counters
                        {
                            textCtr++;
                            patternCtr++;
                        }
                        else // both are caps, but no match. set isMatch to false and break;
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    else // if set to false, then pattern has small char, but text has caps letter, so isMatch = false.
                    {
                        isMatch = false;
                        break;
                    }
                }
            }

            return isMatch;
        }

        public void generateCombinations(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            List<string> combinations = new List<string>();
            combinations.Add(new string(str[0], 1));

            generateCombinationsInner(str, combinations, 1);

            foreach (string s in combinations)
            {
                Console.WriteLine(s);
            }

        }

        private void generateCombinationsInner(string str, List<string> combinations, int currIndex)
        {
            if (currIndex >= str.Length)
                return;

            char c = str[currIndex];

            List<string> combos = new List<string>();
            combos.Add(new string(c, 1));
            foreach (string s in combinations)
            {
                combos.Add(s + c);
            }
            combinations.AddRange(combos);

            generateCombinationsInner(str, combinations, currIndex + 1);
        }

        public int[] longMultiplicationReverse(int[] num1, int[] num2)
        {
            // error check
            if (num1 == null || num1.Count() == 0 || num2 == null || num2.Count() == 0)
            {
                return null;
            }

            List<int> result = new List<int>();
            int offset = 0;
            for (int i = num1.Count()-1; i >=0; i--)
            {
                int index = 0;
                int carry = 0;
                for (int j = num2.Count()-1; j >= 0; j--)
                {
                    int temp = num1[i] * num2[j];
                    temp += carry;

                    while (result.Count <= index + offset)
                    {
                        result.Add(0);
                    }
                    temp += result[index + offset];

                    int unitsPlace = temp % 10;
                    carry = temp / 10;

                    result[index + offset] = unitsPlace;
                    index++;

                }
                while(carry != 0)
                {
                    while (result.Count <= index + offset)
                    {
                        result.Add(0);
                    }
                    int temp = result[index + offset] + carry;
                    result[index + offset] = temp % 10;
                    carry = temp / 10;
                    index++;
                }
                carry = 0;
                offset++;
                index = 0;
            }
            result.Reverse();
            return result.ToArray();
        }

        public bool findNodeInBST(Node root, int target)
        {
            if (root == null)
                return false;
            if (root.value == target)
            {
                return true;
            }
            else if (root.value > target)
            {
                return findNodeInBST(root.leftNode, target);
            }
            else
            {
                return findNodeInBST(root.rightNode, target);
            }
        }

        public int GetMaxAliveYear(List<Person> people)
        {
            if (people == null)
                return -1;

            List<int> sortedBirths = sortPersonByAttribute(people, false);
            List<int> sortedDeaths = sortPersonByAttribute(people, true);

            int maxAlive = 0;
            int maxYear = -1;
            int birthIndex = 0, deathIndex = 0;
            int currAlive = 0;

            while (birthIndex < sortedBirths.Count)
            {
                if (sortedBirths[birthIndex] <= sortedDeaths[deathIndex])
                {
                    currAlive++;
                    if (currAlive > maxAlive)
                    {
                        maxAlive = currAlive;
                        maxYear = sortedBirths[birthIndex];
                    }
                    birthIndex++;
                }
                else
                {
                    currAlive--;
                    deathIndex++;
                }
            }
            return maxYear;
        }

        private List<int> sortPersonByAttribute(List<Person> people, bool useDeathYear)
        {
            List<int> years = new List<int>();
            foreach (Person p in people)
            {
                if (useDeathYear)
                {
                    years.Add(p.death);
                }
                else
                {
                    years.Add(p.birth);
                }
            }
            years.Sort();
            return years;
        }

        // does a clockwise rotate of the matrix
        public void RotateMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if ((rows != cols) || rows < 2)
                return;

            int depth = 0;
            for (int i = 0; i <= rows / 2; i++)
            {
                for (int j = depth; j < cols - depth - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[rows - j - 1, i];
                    matrix[rows - j - 1, i] = matrix[rows - i - 1, cols - j - 1];
                    matrix[rows - i - 1, cols - j - 1] = matrix[j, cols - i - 1];
                    matrix[j, cols - i - 1] = temp;
                }
                depth++;
            }
        }

        public bool IsBinaryTreeBalanced(Node root)
        {
            if (root == null)
                return false;

            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            getTreeMinMaxHeight(root, 0, ref min, ref max);
            Console.WriteLine(min + " " + max);

            if (max - min > 1)
                return false;
            return true;
        }

        private void getTreeMinMaxHeight(Node root, int currHeight, ref int minHeight, ref int maxHeight)
        {
            if (root == null)
            {
                return;
            }

            if (root.leftNode == null && root.rightNode == null) //leaf node
            {
                currHeight++;

                maxHeight = currHeight > maxHeight ? currHeight : maxHeight;
                minHeight = currHeight < minHeight ? currHeight : minHeight;
            }
            else
            {
                getTreeMinMaxHeight(root.leftNode, 1 + currHeight, ref minHeight, ref maxHeight);
                getTreeMinMaxHeight(root.rightNode, 1 + currHeight, ref minHeight, ref maxHeight);
            }

        }

        /*
            A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).
            Write a function to determine if a number is strobogrammatic. The number is represented as a string.
         */
        public bool IsStrobogrammatic(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return true;
            }

            Dictionary<char, char> stroboMap = new Dictionary<char, char>();
            stroboMap.Add('0', '0');
            stroboMap.Add('1', '1');
            stroboMap.Add('6', '9');
            stroboMap.Add('8', '8');
            stroboMap.Add('9', '6');

            for (int i = 0; i <= number.Length / 2; i++)
            {
                char ch = number[i];
                if (stroboMap.ContainsKey(ch))
                {
                    if (stroboMap[ch] != number[number.Length - i - 1])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /* https://leetcode.com/problems/invert-binary-tree/ 
                 4
               /   \
              2     7
             / \   / \
            1   3 6   9
         
            to
         
                 4
               /   \
              7     2
             / \   / \
            9   6 3   1

         */

        public Node InvertBinaryTree(Node root)
        {
            if (root == null)
                return null;

            Node temp = root.leftNode;
            root.leftNode = root.rightNode;
            root.rightNode = temp;

            root.leftNode = this.InvertBinaryTree(root.leftNode);
            root.rightNode = this.InvertBinaryTree(root.rightNode);

            return root;
        }

        // set union
        // assumptions: each list only contains unique elements - no repetitions within the same set
        // approach 1: add all elements to a hash table (key = num; value - bool) - if there's a collition, ignore. return all keys.
        // approach 2: sort both sets - do a modified merge sort that will ignore common elements - gets confused with repeated common elements
        public int[] SetsUnionHash(int[] setA, int[] setB)
        {
            // validations
            if (setA == null && setB == null)
            {
                return null;
            }
            else if (setA == null || setA.Count() == 0)
            {
                return setB;
            }
            else if (setB == null || setB.Count() == 0)
            {
                return setA;
            }

            // algo
            Dictionary<int, bool> union = new Dictionary<int, bool>();
            foreach (int a in setA)
            {
                if (!union.ContainsKey(a))
                {
                    union.Add(a, true);
                }
            }

            foreach (int b in setB)
            {
                if (!union.ContainsKey(b))
                {
                    union.Add(b, true);
                }
            }

            int[] unions = new int[union.Keys.Count];
            int ctr = 0;
            foreach (KeyValuePair<int, bool> kvp in union)
            {
                unions[ctr++] = kvp.Key;
            }

            return unions;
        }

        public int[] SetsUnionMerge(int[] setA, int[] setB)
        {
            // validations
            if (setA == null && setB == null)
            {
                return null;
            }
            else if (setA == null || setA.Count() == 0)
            {
                return setB;
            }
            else if (setB == null || setB.Count() == 0)
            {
                return setA;
            }

            //algo
            Array.Sort(setA);
            Array.Sort(setB);

            int indexA = 0, indexB = 0;
            List<int> union = new List<int>();

            while (true)
            {
                if (indexA < setA.Count() && indexB < setB.Count())
                {
                    if (setA[indexA] == setB[indexB])
                    {
                        union.Add(setA[indexA++]);
                        indexB++;
                    }
                    else if (setA[indexA] < setB[indexB])
                    {
                        union.Add(setA[indexA++]);
                    }
                    else
                    {
                        union.Add(setB[indexB++]);
                    }
                }
                else if (indexA < setA.Count())
                {
                    union.Add(setA[indexA++]);
                }
                else if (indexB < setB.Count())
                {
                    union.Add(setB[indexB++]);
                }
                else
                {
                    break;
                }
            }

            return union.ToArray();
        }

        /* https://leetcode.com/problems/move-zeroes/
            Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
            For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
            Note:
            You must do this in-place without making a copy of the array.
            Minimize the total number of operations.
         */
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Count() == 0)
                return;

            int fastIndex = 0, slowIndex = 0;

            while (fastIndex != nums.Count())
            {
                if (nums[fastIndex] != 0)
                {
                    if (fastIndex != slowIndex)
                    {
                        nums[slowIndex] = nums[fastIndex];
                    }
                    slowIndex++;
                }
                fastIndex++;
            }

            while (slowIndex != fastIndex)
            {
                nums[slowIndex++] = 0;
            }
        }

        /* https://leetcode.com/problems/largest-rectangle-in-histogram/
           Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
           For example,
           Given height = [2,1,5,6,2,3], return 10.
         */
        public int LargestRectangleArea(int[] height)
        {
            Stack<int> stack = new Stack<int>();
            Array.Resize(ref height, height.Count() + 1);
            height.SetValue(0, height.Count()-1);
            
            int index = 0, maxA = 0;
            while (index < height.Count())
            {
                if (stack.Count == 0) stack.Push(index++);
                else if (height[index] >= height[stack.Peek()]) stack.Push(index++);
                else
                {
                    int t = stack.Peek();
                    stack.Pop();
                    maxA = max(maxA, stack.Count == 0 ? height[t] * index : height[t] * (index - stack.Peek() - 1));
                }
            }
            return maxA;
        }

        /* https://leetcode.com/problems/longest-valid-parentheses/
           Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
           For "(()", the longest valid parentheses substring is "()", which has length = 2.
           Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
         */
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Stack<Tuple<char, int>> stack = new Stack<Tuple<char, int>>();
            int len = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek().Item1 == '(' && s[i] == ')')
                {
                    stack.Pop();
                }
                else
                {
                    int gap = (stack.Count() == 0) ? i : i - stack.Peek().Item2 - 1;
                    len = max(len, gap);
                    stack.Push(new Tuple<char, int>(s[i], i));
                }
            }
            len = (stack.Count() == 0) ? s.Count() : max(len, s.Count() -1 - stack.Peek().Item2);

            return len;
        }

        /*  https://leetcode.com/problems/interleaving-string/
            Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.

            For example,
            Given:
            s1 = "aabcc",
            s2 = "dbbca",

            When s3 = "aadbbcbcac", return true.
            When s3 = "aadbbbaccc", return false.
        */
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1 == null || s2 == null || s3 == null)
                return false;

            if (string.IsNullOrEmpty(s1))
            {
                if (s2 != s3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (string.IsNullOrEmpty(s2))
            {
                if (s1 != s3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            int index1 = 0, index2 = 0, index3 = 0;

            while (true) //check condition
            {
                // base cases
                if (index1 == s1.Length && index2 == s2.Length && index3 == s3.Length)
                {
                    return true;
                }
                if (index1 == s1.Length)
                {
                    if (s2.Substring(index2) == s3.Substring(index3))
                    {
                        return true;
                    }
                    return false;
                }
                if (index2 == s2.Length)
                {
                    if (s1.Substring(index1) == s3.Substring(index3))
                    {
                        return true;
                    }
                    return false;
                }
                if (index3 == s3.Length)
                    return false;

                if (s1[index1] != s2[index2])
                {
                    if (s1[index1] == s3[index3])
                    {
                        index1++;
                        index3++;
                    }
                    else if (s2[index2] == s3[index3])
                    {
                        index2++;
                        index3++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (s1[index1] == s3[index3])
                    {
                        if (IsInterleave(s1.Substring(index1 + 1), s2.Substring(index2), s3.Substring(index3 + 1)) ||
                            IsInterleave(s1.Substring(index1), s2.Substring(index2 + 1), s3.Substring(index3 + 1)))
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /* https://leetcode.com/problems/expression-add-operators/
           Given a string that contains only digits 0-9 and a target value, return all possibilities to add binary operators (not unary) +, -, or * 
           between the digits so they evaluate to the target value.

            Examples: 
            "123", 6 -> ["1+2+3", "1*2*3"] 
            "232", 8 -> ["2*3+2", "2+3*2"]
            "105", 5 -> ["1*0+5","10-5"]
            "00", 0 -> ["0+0", "0-0", "0*0"]
            "3456237490", 9191 -> []
         */
        public List<string> AddOperators(string num, int target)
        {
            if (num == null)
                return null;

            return addOperatorsInner(num, target, string.Empty, new List<string>());
        }

        private List<string> addOperatorsInner(string num, int target, string currExpression, List<string> currSolutions)
        {
            if (String.IsNullOrEmpty(num))
            {
                int evaluation;
                try
                {
                    evaluation = this.evaluateExpression(currExpression);
                }
                catch (DivideByZeroException)
                {
                    return null;
                }

                if (evaluation == target)
                {
                    if (!currSolutions.Contains(currExpression))
                    {
                        currSolutions.Add(currExpression);
                    }
                }
                return null;
            }
            char[] symbols = {'+', '-', '*', '/'};
            currExpression += num[0];

            if (num.Length > 1)
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    addOperatorsInner(num.Substring(1), target, currExpression + symbols[i], currSolutions);
                }
            }
            else
            {
                addOperatorsInner(string.Empty, target, currExpression, currSolutions);
            }

            return currSolutions;
        }
        
        public List<int> fillLake(int[,] map)
        {
            if (map == null)
            {
                return null;
            }

            List<int> lakes = new List<int>();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 1)
                    {
                        int size = getLakeSize(map, i, j);
                        lakes.Add(size);
                    }
                }
            }

            return lakes;
        }

        // 4 point connectivity
        private int getLakeSize(int[,] map, int row, int col)
        {
            int mapRows = map.GetLength(0);
            int mapCols = map.GetLength(1);

            // out of bounds or not a lake
            if (row < 0 || row >= mapRows || col < 0 || col > mapCols - 1 || map[row,col] != 1)
            {
                return 0;
            }

            int lakeSize = 1;
            map[row, col] = -1;
            lakeSize += getLakeSize(map, row + 1, col);
            lakeSize += getLakeSize(map, row - 1, col);
            lakeSize += getLakeSize(map, row, col - 1);
            lakeSize += getLakeSize(map, row, col + 1);

            return lakeSize;
        }

        // evaluates expression like: 1+2-3*4-5/6
        // assumptions:
        // only single digit numbers
        // nothing else in the string apart from digits, and +,-,*,/
        public int evaluateExpression(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                return Int32.MinValue;
            }

            int evaluationResult = 0;

            Stack<int> operandStack = new Stack<int>();
            Stack<char> operatorStack = new Stack<char>();

            foreach (char ch in expression)
            {
                if (isDigit(ch))
                {
                    operandStack.Push(ch - '0');
                }
                else
                {
                    if (operatorStack.Count == 0)
                    {
                        operatorStack.Push(ch);
                    }
                    else
                    {
                        char topOperator = operatorStack.Peek();

                        while (getPriority(topOperator) >= getPriority(ch))
                        {
                            topOperator = operatorStack.Pop();
                            if (operandStack.Count < 2)
                                return -1;// throw exception

                            int num2 = operandStack.Pop();
                            int num1 = operandStack.Pop();

                            int result = applyOperator(num1, num2, topOperator);
                            operandStack.Push(result);

                            if (operatorStack.Count > 0)
                            {
                                topOperator = operatorStack.Peek();
                            }
                            else
                            {
                                break;
                            }
                        }
                        operatorStack.Push(ch);
                    }
                }
            }

            while (operatorStack.Count != 0 && operandStack.Count != 0)
            {
                char topOperator = operatorStack.Pop();
                int num2 = operandStack.Pop();
                int num1 = operandStack.Pop();

                int val = applyOperator(num1, num2, topOperator);

                operandStack.Push(val);
            }

            if (operandStack.Count == 1 && operatorStack.Count == 0)
            {
                evaluationResult = operandStack.Pop();
            }
            else
            {
                evaluationResult = Int32.MinValue;
                //throw exception!?
            }

            return evaluationResult;
        }

        private bool isDigit(char ch)
        {
            return (ch - '0' >= 0 && ch - '0' <= 9);
        }

        private int getPriority(char op)
        {
            switch (op)
            {
                case ' ':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return -1;
            }
        }

        private int applyOperator(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    throw new DivideByZeroException();
                default:
                    return -1; // throw exception
            }
        }

        /*
            https://leetcode.com/problems/minimum-window-substring/
            Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).

            For example,
            S = "ADOBECODEBANC"
            T = "ABC"
            Minimum window is "BANC".

            Note:
            If there is no such window in S that covers all characters in T, return the empty string "".
         */
        public string minWindow(string s, string t)
        {
            // error checking
            if (s == null || t == null)
                return null;

            int[] closures = getClosures(s,t);
            return minString(closures, s);
        }

        private int[] getClosures(string s, string t)
        {
            int[] closures = new int[s.Length];
            for (int i = 0; i < t.Length; i++)
            {
                sweepForClosures(s, closures, t[i]);
            }

            return closures;
        }

        private void sweepForClosures(string s, int[] closures, char c)
        {
            int next = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    next = i;
                }

                if ((next == -1 || closures[i] < next) && closures[i] != -1)
                    closures[i] = next;
            }
        }

        private string minString(int[] closures, string s)
        {
            string str = string.Empty;
            int minLen = Int32.MaxValue;

            for (int i = 0; i < closures.Length; i++)
            {
                if (closures[i] != -1)
                {
                    if ((closures[i] - i) < minLen)
                    {
                        minLen = closures[i] - i;
                        str = s.Substring(i, minLen+1);
                    }
                }
            }

            return str;
        }

        private void printList(List<int> list)
        {
            if (list == null)
                return;

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        // input -> 1,2,3,4,5,6,-3,-5
        // output -> 3,5
        // assumes no repetitions
        public List<int> numberComplements(List<int> numbers)
        {
            if (numbers == null)
                return null;

            List<int> complements = new List<int>();
            numbers.Sort(CompareNumbersByAbsoluteValue);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] + numbers[i] == 0)
                {
                    complements.Add(Math.Abs(numbers[i]));
                }
            }
            return complements;
        }

        private int CompareNumbersByAbsoluteValue(int a, int b)
        {
            if (Math.Abs(a) == Math.Abs(b))
            {
                if (a == b)
                    return 0;
                else
                    return (a > b) ? -1 : 1;
            }
            else
                return (Math.Abs(a) > Math.Abs(b)) ? -1 : 1;
        }

        public bool isValidBST(Node root)
        {
            if (root == null)
                return true;

            if (root.leftNode != null)
            {
                if (root.leftNode.rightNode != null)
                {
                    if (root.value > root.leftNode.rightNode.value &&
                        root.leftNode.rightNode.value > root.leftNode.value)
                    {
                        return isValidBST(root.leftNode);
                    }
                    return false;
                }
                else
                {
                    if (root.value > root.leftNode.value)
                    {
                        return isValidBST(root.leftNode);
                    }
                    return false;
                }
            }

            if (root.rightNode != null)
            {
                if (root.rightNode.leftNode != null)
                {
                    if (root.value < root.rightNode.leftNode.value &&
                        root.rightNode.leftNode.value < root.rightNode.value)
                    {
                        return isValidBST(root.rightNode);
                    }
                    return false;
                }
                else
                {
                    if (root.value < root.rightNode.value)
                    {
                        return isValidBST(root.rightNode);
                    }
                    return false;
                }
            }

            return true;
        }

        public bool isValidBSTRange(Node root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.value > min && root.value < max)
            {
                return (isValidBSTRange(root.leftNode, min, root.value) &&
                        isValidBSTRange(root.rightNode, root.value, max));
            }
            return false;
        }

        public bool isValidBSTVal(Node root, ref int minVal)
        {
            if (root == null)
                return true;

            if (isValidBSTVal(root.leftNode, ref minVal))
            {
                if (minVal > root.value)
                    return false;
                minVal = root.value;
                if (isValidBSTVal(root.rightNode, ref minVal))
                    return true;
            }

            return false;
        }

        // finds least cost search from 0,0 to row-1,col-1
        // each cell has an int that represents the cost of that cell.
        // objective is to keep total cost to a minimum.
        // cells with value of 9 are walls and should not part of the final route
        // uses 4 point connectivity - no diagonal movement
        public List<int> AStarSearch(int[,] map)
        {
            int startX = 0, startY = 0, endX = map.GetLength(0) - 1, endY = map.GetLength(1) - 1;
            bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    visited[i, j] = false;
                }
            }
            List<AStarUnit> priorityList = new List<AStarUnit>();
            priorityList.Add(new AStarUnit(startX, startY, map[startX, startY]));

            return aStarSearchInner(map, map.GetLength(0), map.GetLength(1), priorityList, endX, endY, visited);
        }

        private List<int> aStarSearchInner(int[,] map, int mapRows, int mapCols, List<AStarUnit> priorityList, int endX,
            int endY, bool[,] visited)
        {
            // base cases
            if (priorityList == null || priorityList.Count == 0)
            {
                return null;
            }

            // get least cost cell from priorityList to determine startX and startY
            priorityList = priorityList.OrderBy(unit => unit.cost).ToList();

            int startX = -1;
            int startY = -1;

            AStarUnit leastCostUnit = priorityList[0];
            startX = leastCostUnit.row;
            startY = leastCostUnit.col;

            priorityList.Remove(leastCostUnit);


            // goal reached?
            if (startX == endX && startY == endY)
            {
                return new List<int>() {map[startX, startY]};
            }

            // meat
            // set visited in cell to true
            visited[startX, startY] = true;

            // get next cells to explore
            // check if cell is unexplored and within bounds
            if (startX - 1 >= 0 && map[startX - 1, startY] != 9 && visited[startX - 1, startY] == false)
                priorityList.Add(new AStarUnit(startX - 1, startY, leastCostUnit.cost + map[startX - 1, startY]));
            if (startY - 1 >= 0 && map[startX, startY - 1] != 9 && visited[startX, startY - 1] == false)
                priorityList.Add(new AStarUnit(startX, startY - 1, leastCostUnit.cost + map[startX, startY - 1]));
            if (startX + 1 < mapRows && map[startX + 1, startY] != 9 && visited[startX + 1, startY] == false)
                priorityList.Add(new AStarUnit(startX + 1, startY, leastCostUnit.cost + map[startX + 1, startY]));
            if (startY + 1 < mapCols && map[startX, startY + 1] != 9 && visited[startX, startY + 1] == false)
                priorityList.Add(new AStarUnit(startX, startY + 1, leastCostUnit.cost + map[startX, startY + 1]));

            List<int> routeFromStart = aStarSearchInner(map, mapRows, mapCols, priorityList, endX, endY, visited);

            if (routeFromStart == null)
                return null;

            List<int> fullRoute = new List<int>() {leastCostUnit.cost};
            fullRoute.AddRange(routeFromStart);

            return fullRoute;
        }

        public int minCut(string s)
        {
            if ((String.IsNullOrEmpty(s)) || s.Length < 2)
            {
                return 0;
            }
            Dictionary<string, int> memory = new Dictionary<string, int>();
            //return minCutInner(s, new List<string>(), string.Empty, memory);
            return minCutInner(s, string.Empty);
        }

        private int minCutInner(string s, string temp)
        {
            // base cases
            if (s.Length < 2)
            {
                return 0;
            }

            char ch = s[0];
            temp = temp + ch;

            int val1 = s.Length, val2 = s.Length;

            val2 = minCutInner(s.Substring(1), temp);

            if (isPalindrome(temp))
            {
                val1 = 1 + minCutInner(s.Substring(1), string.Empty);
            }
            else
            {
                val2 += temp.Length;
            }

            return Math.Min(val1, val2);
        }

        // TO BE FIXED
        private int minCutInner(string s, List<string> splits, string temp, Dictionary<string, int> memory)
        {
            if (memory.ContainsKey(s))
            {
                return memory[s];
            }
            else if ((s.Length < 2) || isPalindrome(s))
            {
                if (string.IsNullOrEmpty(temp))
                {
                    //memory.Add(s, 0);
                    splits.Add(s);
                    return 0; // or added sum?!
                }
                else
                {
                    return temp.Length;
                }
            }

            char c = s[0];
            temp += c;
            List<string> splitsCopy = new List<string>();
            int cand1 = s.Length - 1, cand2 = s.Length - 1, cand3 = s.Length - 1;
            if (isPalindrome(temp))
            {
                splitsCopy = new List<string>();
                foreach (string str in splits)
                {
                    splitsCopy.Add(str);
                } 
                splitsCopy.Add(temp);
                cand1 = 1 + minCutInner(s.Substring(1), splitsCopy, string.Empty, memory);
                if (!memory.ContainsKey(s.Substring(1)))
                {
                    //memory.Add(s.Substring(1), cand1);
                }
                else
                {
                    if (memory[s.Substring(1)] > cand1)
                    {
                        memory[s.Substring(1)] = cand1;
                    }
                }
            }

            splitsCopy = new List<string>();
            foreach (string str in splits)
            {
                splitsCopy.Add(str);
            }

            if (memory.ContainsKey(s.Substring(1)))
            {
                memory.Remove(s.Substring(1));
            }
            cand2 = minCutInner(s.Substring(1), splitsCopy, temp, memory);

            if (!memory.ContainsKey(s.Substring(1)))
            {
                //memory.Add(s.Substring(1), cand2);
            }
            else
            {
                if (memory[s.Substring(1)] > cand2)
                {
                    memory[s.Substring(1)] = cand2;
                }
            }

            return 1 + Math.Min(cand1, cand2);
        }

        private bool isPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> mergeSort(List<int> numbers)
        {
            if (numbers == null || numbers.Count <= 1)
                return numbers;

            return mergeSortInner(numbers);

        }

        public List<int> mergeSortInner(List<int> numbers)
        {
            int len = numbers.Count;

            //base cases
            if (len <= 1)
            {
                return numbers;
            }

            //merge sort algorithm
            int mid = len / 2;

            List<int> left = new List<int>();
            for (int i = 0; i < mid; i++)
            {
                left.Add(numbers[i]);
            }

            List<int> right = new List<int>();
            for (int i = mid; i < len; i++)
            {
                right.Add(numbers[i]);
            }

            List<int> sortedLeft = mergeSortInner(left);
            List<int> sortedRight = mergeSortInner(right);

            List<int> mergedList = new List<int>();

            int rightIndex = 0, leftIndex = 0;
            while (leftIndex != sortedLeft.Count && rightIndex != sortedRight.Count)
            {
                if (sortedLeft[leftIndex] < sortedRight[rightIndex])
                {
                    mergedList.Add(sortedLeft[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergedList.Add(sortedRight[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex != sortedLeft.Count)
            {
                mergedList.Add(sortedLeft[leftIndex]);
                leftIndex++;
            }

            while (rightIndex != sortedRight.Count)
            {
                mergedList.Add(sortedRight[rightIndex]);
                rightIndex++;
            }

            return mergedList;

        }

        // assumptions: 
        // unique numbers only so pivot cannot be repeated
        // in place sort
        public void QuickSort(List<int> numbers)
        {
            if (numbers == null)
            {
                return;
            }
            else if (numbers.Count < 2)
            {
                return;
            }

            quicksortInner(numbers, 0, numbers.Count - 1);
        }

        public void quicksortInner(List<int> numbers, int min, int max)
        {
            //base cases
            if(min >= max)
            {
                return;
            }
            else if (max - min == 1)
            {
                if (numbers[min] > numbers[max])
                {
                    int temp = numbers[min];
                    numbers[min] = numbers[max];
                    numbers[max] = temp;
                }
                return;
            }

            int pivot = numbers[(min + max)/2];

            int minIndex = min;
            int maxIndex = max;

            while (minIndex < maxIndex) // condition check
            {
                while (numbers[minIndex] < pivot && minIndex < maxIndex)
                {
                    minIndex++;
                }

                while (numbers[maxIndex] > pivot && maxIndex > minIndex)
                {
                    maxIndex--;
                }

                if (minIndex < maxIndex)
                {
                    int temp = numbers[minIndex];
                    numbers[minIndex] = numbers[maxIndex];
                    numbers[maxIndex] = temp;
                    minIndex++;
                    maxIndex--;
                }
            }

            quicksortInner(numbers, min, minIndex);
            quicksortInner(numbers, maxIndex, max);
        }

        public string reverseStringOfStrings(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            int start = -1;
            int end = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str.ToLower().ElementAt(i) >= 'a' && str.ToLower().ElementAt(i) <= 'z' && start == -1)
                {
                    start = i;
                }
                if (str[i] == '-')
                {
                    end = i - 1;
                    str = new string(innerReverse(str.ToCharArray(), start, end));
                    start = -1;
                }
            }

            return str;
        }

        private char[] innerReverse(char[] s, int start, int end)
        {
            if (s == null || start < 0 || start >= s.Length || end < 0 || end >= s.Length || start > end)
            {
                return s;
            }

            for (int i = 0 ; i < ((start + end) / 2 ) - start; i++)
            {
                char temp = s[i + start];
                s[start + i] = s[end - i];
                s[end - i] = temp;
            }

            return s;
        }

        private int compareListOfLists(List<int> a, List<int> b)
        {
            if ((a == null) || (b == null))
            {
                //error?
            }

            if (a.Count > b.Count)
                return -1;
            else if (a.Count < b.Count)
                return 1;
            return 0;
        }

        public List<int> getCommonElements(List<List<int>> listOfListOfInt)
        {
            if (listOfListOfInt == null)
            {
                return null;
            }
            else if (listOfListOfInt.Count == 0)
            {
                return null;
            }
            else if (listOfListOfInt.Count == 1)
            {
                return listOfListOfInt[0];
            }


            List<int> commonElements = new List<int>();

            listOfListOfInt.Sort(compareListOfLists);
            listOfListOfInt.Reverse();

            foreach (List<int> list in listOfListOfInt)
            {
                if (list == null)
                {
                    //error?!
                }
                list.Sort();
            }

            if (listOfListOfInt[0].Count == 0)
            {
                return commonElements;
            }

            foreach (int element in listOfListOfInt[0])
            {
                bool isCommon = true;
                foreach (List<int> list in listOfListOfInt)
                {
                    if (!list.Contains(element))
                    {
                        isCommon = false;
                        break;
                    }
                }
                if (isCommon)
                {
                    commonElements.Add(element);
                }
            }

            return commonElements;
        }

        public NaryNode createNaryTree()
        {
            NaryNode root = new NaryNode(1);
            
            NaryNode two = new NaryNode(2);
            NaryNode three = new NaryNode(3);
            NaryNode four = new NaryNode(4);

            NaryNode five = new NaryNode(5);
            NaryNode six = new NaryNode(6);
            NaryNode seven = new NaryNode(7);
            NaryNode eight = new NaryNode(8);
            NaryNode nine = new NaryNode(9);
            NaryNode ten = new NaryNode(10);

            two.children.Add(five);
            two.children.Add(six);

            three.children.Add(seven);
            three.children.Add(eight);

            four.children.Add(nine);
            four.children.Add(ten);

            root.children.Add(two);
            root.children.Add(three);
            root.children.Add(four);

            return root;
        }

        /*
                       1
                      /|\
                     / | \
                    /  |  \
                   2   3   4
                  /|   /\  |\
                 / |  | |  | \
                5  6  7 8  9 10
         * 
         * s1 = 1
         * s2 = -
         * 
         * s1 = -
         * s2 = 2 3 4
         * 
         * s1 = 9 10 7 8 5 6
         * s2 = -
         */
        public void printAlternate(NaryNode root)
        {
            if (root == null)
            {
                return;
            }

            List<NaryNode> first = new List<NaryNode>();
            List<NaryNode> second = new List<NaryNode>();

            first.Add(root);

            while (first.Count != 0 || second.Count != 0)
            {
                first.Reverse();
                printList(first);
                first.Reverse();
                while (first.Count != 0)
                {
                    NaryNode n = first[0];

                    for (int i = 0; i < n.children.Count; i++)
                    {
                        second.Add(n.children[i]);
                    }

                    first.Remove(n);
                }

                printList(second);

                while (second.Count != 0)
                {
                    NaryNode n = second[0];

                    for (int i = 0; i < n.children.Count; i++)
                    {
                        first.Add(n.children[i]);
                    }

                    second.Remove(n);
                }
            }
        }

        private void printList(List<NaryNode> nodes)
        {
            foreach (NaryNode node in nodes)
            {
                Console.Write(node.value + " ");
            }
            Console.WriteLine();
        }

        public int multiplyWithoutStar(int small, int large)
        {
            if (small == 0)
            {
                return 0;
            }
            else if (small == 1)
            {
                return large;
            }

            int newSmall = small >> 1;
            int prod = multiplyWithoutStar(newSmall, large);
            prod += prod;

            if (small % 2 == 1)
            {
                prod += large;
            }

            return prod;
        }

        public void getCombinations(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            List<string> combinations = new List<string>();

            combinations.Add(s[0].ToString());

            for (int i = 1; i < s.Length; i++)
            {
                int currLen = combinations.Count;
                for (int j = 0; j < currLen; j++)
                {
                    combinations.Add(combinations[j] + s[i]);
                }
                combinations.Add(s[i].ToString());
            }

            foreach (string str in combinations)
            {
                Console.WriteLine(str);
            }

        }

        public void getParanCombination(int n)
        {
            if (n <= 0)
            {
                //Nothing to create
                return;
            }
            getParanCombinationInner(n, n, string.Empty);
        }

        private void getParanCombinationInner(int numOpen, int numClose, string curr)
        {
            if (numOpen == 0 && numClose == 0)
            {
                //found a valid combo. print it!
                Console.WriteLine(curr);
                return;
            }
            string copy = curr;

            if (numOpen > 0)
            {
                copy += '(';
                getParanCombinationInner(--numOpen, numClose, copy);
            }

            if ((numClose > 0) &&  (numClose > numOpen))
            {
                copy += ')';
                getParanCombinationInner(numOpen, --numClose, copy);
            }
        }

        public void printMatrix(int[,] canvas)
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void floodFill(int[,] canvas, int row, int col, int val)
        {
            int canvasHeight = canvas.GetLength(0);
            int canvasWidth = canvas.GetLength(1);

            Queue<Pair> fillQueue = new Queue<Pair>();
            fillQueue.Enqueue(new Pair(row, col));

            while (fillQueue.Count != 0)
            {
                Pair p = fillQueue.Dequeue();

                if (p.row >= 0 && p.row <= canvasHeight && p.col >= 0 && p.col <= canvasWidth)
                {
                    if (canvas[p.row, p.col] == 1)
                    {
                        canvas[p.row, p.col] = val;

                        for (int i = p.row - 1; i <= p.row + 1; i++)
                        {
                            for (int j = p.col - 1; j <= p.col + 1; j++)
                            {
                                if (i >= 0 && i < canvasHeight && j >= 0 && j < canvasWidth)
                                {
                                    if (canvas[i, j] == 1)
                                    {
                                        Pair next = new Pair(i, j);
                                        fillQueue.Enqueue(next);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private char firstNonrepChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                //exception?!
                return ' ';
            }

            char ch = ' ';

            int first = 0, rep = 0;

            foreach (char c in s)
            {
                //check if bit in first is set
                int mask = 1 << (int)(c - 'a');

                //if not set it and continue
                if ((first & mask) == 0)
                {
                    first = first | mask;
                }

                //if it is set, set appropriate bit in rep to 1 - no need to check if its already set
                else
                {
                    rep = rep | mask;
                }
            }

            foreach (char c in s)
            {
                int mask = 1 << (int)(c - 'a');
                //check if appropriate bit in rep is set, if not, return c
                if ((rep & mask) == 0)
                {
                    return c;
                }
            }

            return ch;
        }

        public string maxConcatInt(List<string> nums)
        {
            nums.Sort(CustomCompare);
            return String.Join("", nums.ToArray());
        }

        private int CustomCompare(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return -1;
            }
            else if (a == b)
            {
                return 0;
            }

            int retVal = 0;
            int minLen = a.Length > b.Length ? b.Length : a.Length;

            for (int i = 0; i < minLen; i++)
            {
                if (a[i] > b[i])
                {
                    retVal = -1;
                    break;
                }
                else if (b[i] > a[i])
                {
                    retVal = 1;
                    break;
                }
            }

            if (retVal == 0)
            {
                if (a.Length < b.Length)
                {
                    retVal = -1;
                }
                else if (a.Length > b.Length)
                {
                    retVal = 1;
                }
            }

            return retVal;
        }

        private int max(int a, int b)
        {
            return a > b ? a : b;
        }

        private int largestNonContiguousSum(List<int> numbers)
        {
            if (numbers == null)
            {
                return -1;
            }

            Dictionary<List<int>, int> memorizedSums = new Dictionary<List<int>, int>();

            return this.largestNonContiguousSumInner(numbers, memorizedSums);
        }

        private int largestNonContiguousSumInner(List<int> numbers, Dictionary<List<int>, int> memorizedSums)
        {
            if (numbers.Count == 0)
                return 0;
            else if (numbers.Count == 1)
                return numbers[0];
            else if (numbers.Count == 2)
                return max(numbers[0], numbers[1]);

            if (memorizedSums.ContainsKey(numbers))
            {
                return memorizedSums[numbers];
            }

            List<int> numbersCopy1 = new List<int>();
            List<int> numbersCopy2 = new List<int>();

            foreach (int i in numbers)
            {
                numbersCopy1.Add(i);
                numbersCopy2.Add(i);
            }

            numbersCopy1.RemoveAt(numbersCopy1.Count - 1);
            int maxSubSumMinusOne = largestNonContiguousSumInner(numbersCopy1, memorizedSums);
            memorizedSums.Add(numbersCopy1, maxSubSumMinusOne);

            numbersCopy2.RemoveAt(numbersCopy2.Count - 1);
            numbersCopy2.RemoveAt(numbersCopy2.Count - 1);
            int maxSubSumMinusTwo = largestNonContiguousSumInner(numbersCopy2, memorizedSums);
            memorizedSums.Add(numbersCopy2, maxSubSumMinusTwo);

            int maxSumUntilEnd = numbers[numbers.Count - 1] + maxSubSumMinusTwo;
            int maxSumUntilEndMinusOne = maxSubSumMinusOne;

            return max(maxSumUntilEnd, maxSumUntilEndMinusOne);
        }

        public int maxNonContinuousSum(List<int> numbers)
        {
            if (numbers == null)
                return 0; // throw exception?!

            return maxNonContinuousSumInner(numbers, new Dictionary<List<int>, int>());
        }

        //PRACTICE
        private int maxNonContinuousSumInner(List<int> numbers, Dictionary<List<int>, int> memorizedSums)
        {
            if (numbers.Count == 0)
                return 0;
            else if (numbers.Count == 1)
                return numbers[0];
            else if (numbers.Count == 2)
                return Math.Max(numbers[0], numbers[1]);

            if (memorizedSums.ContainsKey(numbers))
                return memorizedSums[numbers];

            List<int> numbersCopy1 = new List<int>();
            List<int> numbersCopy2 = new List<int>(); 
            foreach (int i in numbers)
            {
                numbersCopy1.Add(i);
                numbersCopy2.Add(i);
            }

            numbersCopy1.RemoveAt(numbersCopy1.Count - 1);
            numbersCopy2.RemoveAt(numbersCopy2.Count - 1);
            numbersCopy2.RemoveAt(numbersCopy2.Count - 1);

            int sumPrev1 = maxNonContinuousSumInner(numbersCopy2, memorizedSums);
            memorizedSums.Add(numbersCopy2, sumPrev1);
            sumPrev1 += numbers[numbers.Count - 1];

            int sumPrev2 = maxNonContinuousSumInner(numbersCopy1, memorizedSums);
            memorizedSums.Add(numbersCopy1, sumPrev2);

            if (sumPrev1 > sumPrev2)
                return sumPrev1;

            return sumPrev2;

        }

        // Given stock prices over a set of days, get max profit
        public int maxProfit(int[] prices)
        {
            int max = -1;

            if (prices.Length < 2)
                return max;

            int minPrice = prices[0];
            max = prices[1] - prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                int potentialProfit = prices[i] - minPrice;
                max = potentialProfit > max ? potentialProfit : max;
                minPrice = minPrice < prices[i] ? minPrice : prices[i];
            }

            return max;
        }

        public int medianOfSortedArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
            {
                return -1;
            }

            int median = 0;

            int medianIndex = (arr1.Length + arr2.Length) / 2;
            bool takePrevNum = (((arr1.Length + arr2.Length) % 2) == 0) ? true : false;

            int indexA = 0;
            int indexB = 0;
            int currInd = 0;

            while (currInd <= medianIndex)
            {
                int value = 0;
                if ((indexA < arr1.Length) && (indexB < arr2.Length))
                {
                    if (arr1[indexA] < arr2[indexB])
                    {
                        value = arr1[indexA];
                        indexA++;
                    }
                    else
                    {
                        value = arr2[indexB];
                        indexB++;
                    }
                }
                else if (indexA < arr1.Length)
                {
                    value = arr1[indexA];
                    indexA++;
                }
                else if (indexB < arr2.Length)
                {
                    value = arr2[indexB];
                    indexB++;
                }
                else
                {
                    //ERROR CONDITION
                }

                if (((currInd == medianIndex - 1) && (takePrevNum)) || (currInd == medianIndex))
                {
                    median += value;
                }

                currInd++;
            }

            //if even number of elements
            if (takePrevNum)
            {
                median /= 2;
            }

            return median;
        }

        //KMP ALgorithm
        public int subStringMatch(string text, string pattern)
        {
            if (text == null || pattern == null)
            {
                return -1;
            }

            if (string.IsNullOrEmpty(text))
            {
                if (string.IsNullOrEmpty(pattern))
                    return 0;
                else
                    return -1;
            }

            if (string.IsNullOrEmpty(pattern))
                return -1;

            int indexToSearch = 0;
            int nextIndex = -1;
            int matchFoundIndex = -1;
            bool matchFound = true;

            for (int i = indexToSearch; i < text.Length; i++)
            {
                if (text[i] == pattern[0]) //start of possible match
                {
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        // matches first char of pattern, so if this try fails try next match sequence from here.
                        if ((j != 0) && (text[i + j] == pattern[0]) && nextIndex == -1)
                        {
                            nextIndex = i + j;
                        }

                        // if chars dont match, set next starting point (next index inase we found one, or the point at which we 
                        // abandoned this search, becaue we know there was no other occurrence of pattern[0] in between.
                        if (text[i + j] != pattern[j])
                        {
                            matchFound = false;
                            if (nextIndex != -1)
                            {
                                i = nextIndex - 1;
                                nextIndex = -1;
                            }
                            else
                            {
                                i += j;
                            }
                            break;
                        }
                    }
                    if (matchFound)
                    {
                        matchFoundIndex = i;
                        return matchFoundIndex;
                    }
                    matchFound = true;
                }
            }

            return -1;
        }

        //Hash based solution
        public int subStringMatchHash(string text, string pattern)
        {
            if((text == null) || (pattern == null) || (text.Length < pattern.Length))
            {
                return -1;
            }
            
            int patternHash = getHashedValue(pattern);

            int currentTextHash = -1;

            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                //first time calculation
                if (currentTextHash == -1)
                {
                    currentTextHash = getHashedValue(text.Substring(0, pattern.Length));
                }

                //repeated calculation - use previous value so as to not get O(N^2) solution
                else
                {
                    currentTextHash = currentTextHash - getHashedValue(text.Substring(i - 1, 1)) +
                                      getHashedValue(text.Substring(i + pattern.Length - 1, 1));
                }

                if (currentTextHash == patternHash)
                {
                    if (pattern == text.Substring(i, pattern.Length))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        // rudimentary hashing function - add ascii values of all chars
        // multiple strings can hash to the same value, but same string will never hash to different values.
        private int getHashedValue(string s)
        {
            int hash = 0;
            foreach (char ch in s)
            {
                hash += ch;
            }
            return hash;
        }

        public string getShortestPalindrome(string word)
        {
            // init upper and lower
            // init maxLen and longestPalindrome
            // start from middle with upper = lower
            // iterate until beginning of string - alternately reduce lower and reduce upper to cover even and odd length palindromes
            // when all chars till beginning of string match what follows "middle", reverse rest of string till end and append to front.

            int upper = (word.Length - 1) / 2;
            int lower = (word.Length - 1) / 2;

            int maxLen = 0;
            string longestPalindrome = string.Empty;

            int minLen = 0;
            string shortestPalindrome = string.Empty;

            while (upper != 0 && lower != 0)
            {
                int innerLower = lower;
                int innerUpper = upper;

                while (innerLower >= 0 && innerUpper < word.Length)
                {
                    if (word[innerUpper] == word[innerLower])
                    {
                        if (maxLen < (innerUpper - innerLower + 1))
                        {
                            maxLen = innerUpper - innerLower + 1;
                            longestPalindrome = word.Substring(innerLower, maxLen);
                        }

                        innerUpper++;
                        innerLower--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (innerLower + 1 == 0)
                {
                    char[] arr = word.Substring(innerUpper).ToCharArray();
                    Array.Reverse(arr);
                    shortestPalindrome = new string(arr) + word;

                    return shortestPalindrome;
                }

                if (upper == lower)
                {
                    lower--;
                }
                else
                {
                    upper = lower;
                }
            }

            return longestPalindrome;
        }

        public int[] longMultiplication(int[] num1, int[] num2)
        {
            List<int> result = new List<int>();
            List<int> temp = new List<int>();
            int offset = 0;
            
            foreach (int n in num1)
            {
                int carry = 0;
                foreach (int m in num2)
                {
                    if (m == 0)
                    {
                        offset++;
                        continue;
                    }
                    int product = (n * m) + carry;
                    int unitsPlace = product % 10;
                    carry = product / 10;

                    temp.Add(unitsPlace);
                }
                if (carry != 0)
                {
                    temp.Add(carry);
                }
                carry = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    int index = i + offset;
                    while (result.Count <= index)
                    {
                        result.Add(0);
                    }
                    int sum = result[index] + temp[i] + carry;
                    result[index] = sum % 10;
                    carry = sum / 10;
                }
                if (carry != 0)
                {
                    result.Add(carry);
                }

                offset++;
                temp = new List<int>();
            }

            return result.ToArray();
        }

        public List<string> FindWords(char[,] board, string[] words)
        {
            string currWord = string.Empty;
            bool[,] visited = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    visited[i, j] = false;
                }
            }
            List<string> matches = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    List<string> innerMatches = findWordsInner(board, words, 4, 4, currWord, visited, i, j);
                    matches.AddRange(innerMatches);
                }
            }

            return matches;
        }

        private List<string> findWordsInner(char[,] board, string[] words, int boardLength, int boardHeight, string currWord, bool[,] visited, int currx, int curry)
        {
            if (currx < 0 || currx >= boardHeight || curry < 0 || curry >= boardLength || visited[currx, curry] == true)
            {
                return new List<string>();
            }

            char c = board[currx, curry];
            string newCurrWord = currWord + c;

            List<string> newWords = new List<string>();
            List<string> matches = new List<string>();
            foreach (string s in words)
            {
                if (newCurrWord == s)
                {
                    matches.Add(s);
                }
                else if (s.Length >= newCurrWord.Length && s.Substring(0, newCurrWord.Length) == newCurrWord)
                {
                    newWords.Add(s);
                }
            }

            bool[,] newVisited = new bool[boardHeight, boardLength];

            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardLength; j++)
                {
                    newVisited[i, j] = visited[i, j];
                }
            }

            newVisited[currx, curry] = true;

            for (int i = currx - 1; i <= currx + 1; i++)
            {
                for (int j = curry - 1; j <= curry + 1; j++)
                {
                    List<string> innerMatches = findWordsInner(board, newWords.ToArray(), boardLength, boardHeight, newCurrWord, newVisited, i, j);
                    foreach (string s in innerMatches)
                    {
                        matches.Add(s);
                    }
                }
            }

            return matches;
        }

        private List<string> textJustify(string text, int lengthLimit)
        {
            List<string> lines = new List<string>();

            if (string.IsNullOrWhiteSpace(text) || lengthLimit <= 0)
            {
                return lines;
            }

            string[] words = text.Split(' ');
            int currLen = 0;
            int wordInLine = 0;
            int numSpacesInLine = 0;
            List<string> line = new List<string>();

            foreach (string word in words)
            {
                int l = word.Length;

                //not the first word - go through the logic
                if (currLen != 0)
                {
                    if (currLen + l <= lengthLimit)
                    {
                        currLen += l;
                        currLen++; // Account for space
                        line.Add(word);
                    }
                    else
                    {
                        //number of legitimae spaces between words
                        numSpacesInLine = line.Count - 1;
                        //find diff from lengthLimit
                        int diffLen = lengthLimit 
                            - currLen // current length of line with one space between words
                            + numSpacesInLine // one space after every word is already accounted for - so need to be discounted
                            + 1; // trailing space should be discounted
                        //find how each spaces needs to be changed - address uneven distribution of spaces
                        int numEvenSpaces = diffLen / numSpacesInLine;
                        int numOddSpaces = diffLen % numSpacesInLine;
                        string evenSpaces = "";
                        string oddSpaces = "";
                        for (int i = 0; i < numEvenSpaces; i++)
                        {
                            evenSpaces += " ";
                            oddSpaces += " ";
                        }
                        for (int i = 0; i < numOddSpaces; i++)
                        {
                            oddSpaces += " ";
                        }
                        //add additional spaces
                        StringBuilder sb = new StringBuilder();
                        for (int q = 0; q < line.Count; q++)
                        {
                            string s = line[q];
                            sb.Append(s);
                            if (q != line.Count - 1)
                            {
                                if (numOddSpaces > 0)
                                {
                                    sb.Append(oddSpaces);
                                    numOddSpaces--;
                                }
                                else if (numEvenSpaces > 0)
                                {
                                    sb.Append(evenSpaces);
                                    numEvenSpaces--;
                                }
                            }
                        }
                        //add line to listOfLines;
                        lines.Add(sb.ToString());

                        //reinitialize sb, and counts
                        line = new List<string>();
                        
                        //add current word to new string builder and update counts or this word will get lost by iteration.
                        line.Add(word);
                        currLen = l + 1;
                        wordInLine = 1;
                    }
                }
                else // first word in the line. Nothing to check here, just add to sb. Also handles single word scenarios.
                {
                    line.Add(word);
                    wordInLine++;
                    currLen += (l + 1);
                }

            }
            StringBuilder sb1 = new StringBuilder();
            foreach (string s in line)
            {
                sb1.Append(s);
                sb1.Append(" ");
            }
            lines.Add(sb1.ToString());
            return lines;
        }

        private string sortStringByChars(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        private string cleanWord(string s)
        {
            return s;//.Replace("'","");
        }

        private void anagramsMatch(string inputFile)
        {
            Dictionary<string, List<string>> stringMap = new Dictionary<string, List<string>>();

            using (StreamReader sr = new StreamReader(inputFile))
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string key = sortStringByChars(cleanWord(line.ToLowerInvariant()));

                        if (stringMap.ContainsKey(key))
                        {
                            stringMap[key].Add(line);
                        }
                        else
                        {
                            List<string> stringList = new List<string>();
                            stringList.Add(line);

                            stringMap.Add(key, stringList);
                        }
                    }
                }
            }

            int totalWordMatches = 0;
            int uniqueMatches = 0;

            foreach (KeyValuePair<string,List<string>> kvp in stringMap)
            {
                int matchCount = kvp.Value.Count;
                if (matchCount > 1)
                {
                    totalWordMatches += matchCount;
                    uniqueMatches++;
                }
            }

            Console.WriteLine(totalWordMatches + "  " + uniqueMatches);
        }

        public Node buildSampleTree()
        {
            Node node4 = new Node(4, null, null);
            Node node5 = new Node(5, null, null);
            Node node6 = new Node(6, null, null);
            Node node7 = new Node(7, null, null);

            Node node2 = new Node(2, node4, node5);
            Node node3 = new Node(3, node6, node7);

            Node node1 = new Node(1, node2, node3);

            return node1;
        }

        public Node buildValidBinaryTree()
        {
            Node node1 = new Node(1, null, null);
            Node node5 = new Node(5, null, null);
            Node node7 = new Node(7, null, null);
            Node node3 = new Node(3, null, null);

            Node node2 = new Node(2, node1, node3);
            Node node6 = new Node(6, node5, node7);

            Node node4 = new Node(4, node2, node6);            

            return node4;
        }

        public Node buildUnbalancedBinaryTree()
        {
            Node node5 = new Node(5, null, null);
            Node node7 = new Node(7, null, null);
            Node node3 = new Node(3, null, null);
            Node node9 = new Node(9, null, null);

            Node node8 = new Node(8, node9, null);
            Node node1 = new Node(1, node8, null);

            Node node2 = new Node(2, node1, node3);
            Node node6 = new Node(6, node5, node7);

            Node node4 = new Node(4, node2, node6);

            return node4;
        }

        public void runGetPathSumTests()
        {
            Node root = this.buildSampleTree();
            this.getPathSum(root, 10, new List<Node>());
        }

        private void printPath(List<Node> currPath)
        {
            foreach (Node n in currPath)
            {
                Console.Write(n.value + "->");
            }
            Console.WriteLine();
        }

        public void getPathSum(Node node, int target, List<Node> currPath)
        {
            //No checks needed for target or currpath - see implementation below

            int updateTarget = target - node.value;

            List<Node> newPath = new List<Node>();

            foreach (Node n in currPath)
            {
                newPath.Add(n);
            }

            newPath.Add(node);
            if (updateTarget == 0)
            {
                //path found. print it.
                this.printPath(newPath);
            }
            else if (updateTarget < 0)
            {
                //cannot find successful path. just return.
                return;
            }
            else
            {
                //some more work needed.
                if (node.leftNode != null)
                {
                    getPathSum(node.leftNode, updateTarget, newPath);
                    getPathSum(node.leftNode, target, new List<Node>());
                }
                if (node.rightNode != null)
                {
                    getPathSum(node.rightNode, updateTarget, newPath);
                    getPathSum(node.rightNode, target, new List<Node>());
                }
            }
        }

        private int Negate(int n)
        {
            this.printBits(n);
            int sign = ~0;
            Console.WriteLine(sign);
            this.printBits(sign);
            this.printBits(-1);

            //return (n ^ sign) + 1;
            return ~n + 1;
        }

        private int Multiply(int x, int y)
        {
            bool shouldNegate = false;
            if (x == 0 || y == 0)
            {
                return 0;
            }
            
            if (x < 0)
            {
                x = -x;
                shouldNegate = !shouldNegate;
            }
            if (y < 0)
            {
                y = -y;
                shouldNegate = !shouldNegate;
            }

            int result = 0;

            while (x!=0)
            {
                int lastBit = x & 0x1;
                if (lastBit == 1)
                {
                    result += y;
                }
                
                y = y << 1;
                x = x >> 1;
            }

            if (shouldNegate)
            {
                result = -result;
            }
            return result;
        }

        private void printBits(int num)
        {
            int n = 32;
            int mask = 1;
            int[] arr = new int[32];
            for (int i = 0; i < n; i++)
            {
                arr[n - i - 1] = num & mask;
                num = num >> 1;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
                if ((i + 1) % 8 == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        /*
        I want to buy n counts of soda. Sodas come in packs of either [1, 3, 7].
        Determine how many ways there are to buy n.

        What if sizes [1, 3, 7], can change? (Parameterize it).
        */
        private void getPermutationsSum(int[] rawNumbers, int target, List<int> currentState)
        {
            if (target < 0)
            {
                return;
            }
            else if (target == 0)
            {
                foreach (int n in currentState)
                {
                    Console.Write(n + "  ");
                }
                Console.WriteLine();
                return;
            }
            foreach (int n in rawNumbers)
            {
                if (n != 0)
                {
                    List<int> updatedState = new List<int>();
                    foreach (int x in currentState)
                    {
                        updatedState.Add(x);
                    }
                    updatedState.Add(n);
                    getPermutationsSum(rawNumbers, target - n, updatedState);
                }
            }
        }

        // PRACTICE
        public void GetCombinationSums(List<int> numbers, int target)
        {
            if (numbers == null || numbers.Count == 0 || numbers.Contains(0) || target <= 0)
                return;

            List<List<int>> solutions = new List<List<int>>();
            GetCombinationsSumsInner(numbers, target, new List<int>(), 0, solutions);

            foreach (List<int> list in solutions)
            {
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        private void GetCombinationsSumsInner(List<int> numbers, int target, List<int> currSeq, int currSum, List<List<int>> solutions)
        {
            if (currSum > target)
                return;
            else if (currSum == target)
            {
                solutions.Add(currSeq);
            }
            else
            {
                foreach (int n in numbers)
                {
                    List<int> seqCopy = new List<int>();
                    foreach (int i in currSeq)
                    {
                        seqCopy.Add(i);
                    }
                    seqCopy.Add(n);
                    GetCombinationsSumsInner(numbers, target, seqCopy, currSum + n, solutions);
                }
            }
        }

        /*
         * Question was "Given a pattern and a string input - find if the string follows the same pattern and return 0 or 1. 
         * Examples: 
         * 1) Pattern : "abba", input: "redblueredblue" should return 1. 
         * 2) Pattern: "aaaa", input: "asdasdasdasd" should return 1. 
         * 3) Pattern: "aabb", input: "xyzabcxzyabc" should return 0. 
         * I saw someone else had a similar question, but it was much much easier as the other candidate was given spaces… 
         */
        private void findPatternMatch(string pattern, string text)
        {
            bool isMatch = findPatternMatchInner(pattern, text, new Dictionary<char, string>());

            Console.WriteLine(pattern + "  " + text + "  " + isMatch);
        }

        private void findPatternMatchImproved(string pattern, string text)
        {
            /*
             * code for improved logic - counting chars in pattern
             */
            int na = 0, nb = 0;
            foreach (char ch in pattern)
            {
                switch (ch)
                {
                    case 'a': na++; break;
                    case 'b': nb++; break;
                    default: break;// throw exception?!?
                }
            }

            bool isMatch = findPatternMatchInnerImproved(pattern, na, nb, text, new Dictionary<char, string>());

            Console.WriteLine(pattern + "  " + text + "  " + isMatch);
        }

        // takes pattern length into account
        // assumes that there's only a and b in the pattern
        // if pattern is aabb and string is catcatgogo - length of a cannot be more than 5 and if a is x b <= (length(string) - na * a)/nb - if not whole number, abort
        private bool findPatternMatchInnerImproved(string pattern, int na, int nb, string text, Dictionary<char, string> charStringMap)
        {
            // base cases
            if (pattern == string.Empty && text == string.Empty)
            {
                return true;
            }
            else if ((pattern == string.Empty && text != string.Empty) || (pattern != string.Empty && text == string.Empty))
            {
                return false;
            }


            char c = pattern[0];
            if (charStringMap.ContainsKey(c))
            {
                if (text.Length < charStringMap[c].Length || text.Substring(0, charStringMap[c].Length) != charStringMap[c])
                {
                    return false;
                }
                else
                {
                    return findPatternMatchInnerImproved(pattern.Substring(1), c == 'a' ? na - 1 : na, c == 'b' ? nb - 1 : nb, text.Substring(charStringMap[c].Length), charStringMap);
                }
            }
            else
            {
                Dictionary<char, string> newMap = new Dictionary<char, string>();
                foreach (KeyValuePair<char, string> kvp in charStringMap)
                {
                    newMap.Add(kvp.Key, kvp.Value);
                }

                if (c == 'a')
                {
                    if (nb == 0)
                    {
                        if (text.Length % na != 0)
                        {
                            return false;
                        }
                        newMap.Add(c, text.Substring(0, text.Length / na));

                        return findPatternMatchInnerImproved(pattern.Substring(1), na - 1, nb, text.Substring(text.Length / na), newMap);
                    }
                    else
                    {
                        int maxLen = text.Length/na;
                        for (int i = 1; i <= maxLen; i++)
                        {
                            newMap.Add(c, text.Substring(0,i));
                            if (findPatternMatchInnerImproved(pattern.Substring(1), na - 1, nb, text.Substring(i), newMap))
                            {
                                return true;
                            }
                            newMap.Remove(c);
                        }
                    }
                }
                else if (c == 'b')
                {
                    if (na == 0)
                    {
                        if (text.Length % nb != 0)
                        {
                            return false;
                        }
                        newMap.Add(c, text.Substring(0, text.Length / nb));
                        return findPatternMatchInnerImproved(pattern.Substring(1), na, nb - 1, text.Substring(text.Length / nb), newMap);
                    }
                    else
                    {
                        int maxLen = text.Length / nb;
                        for (int i = 1; i <= maxLen; i++)
                        {
                            newMap.Add(c, text.Substring(0,i));
                            if (findPatternMatchInnerImproved(pattern.Substring(1), na, nb-1, text.Substring(i), newMap))
                            {
                                return true;
                            }
                            newMap.Remove(c);
                        }
                    }
                }
            }

            return false;
        }

        private bool findPatternMatchInner(string pattern, string text, Dictionary<char, string> charStringMap)
        {
            if ((string.IsNullOrWhiteSpace(pattern) && !string.IsNullOrWhiteSpace(text)) ||
                (!string.IsNullOrWhiteSpace(pattern) && string.IsNullOrWhiteSpace(text)))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(pattern) && string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            char c = pattern[0];
            if (charStringMap.ContainsKey(c))
            {
                string str = charStringMap[c];
                if (text.Length < str.Length)
                {
                    return false;
                }
                if (text.Substring(0, str.Length) != str)
                {
                    return false;
                }
                else
                {
                    string newPattern = pattern.Substring(1);
                    string newText = text.Substring(str.Length);
                    return findPatternMatchInner(newPattern, newText, charStringMap);
                }
            }
            else
            {
                int len = text.Length;
                for (int i = 0; i < len; i++)
                {
                    string str = text.Substring(0, i + 1);

                    Dictionary<char, string> newMap = new Dictionary<char, string>();
                    foreach (KeyValuePair<char, string> kvp in charStringMap)
                    {
                        newMap.Add(kvp.Key, kvp.Value);
                    }
                    newMap.Add(c, str);

                    string newPattern = pattern.Substring(1);
                    string newText = text.Substring(str.Length);

                    if (findPatternMatchInner(newPattern, newText, newMap))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void getZeroSumSubSequence(int[] numbers)
        {
            Dictionary<int, int> sumIndexDictionary = new Dictionary<int, int>();
            Dictionary<int, int> indexSumDictionary = new Dictionary<int, int>();

            sumIndexDictionary.Add(numbers[0], 0);
            indexSumDictionary.Add(0, numbers[0]);

            for (int index = 1; index < numbers.Length; index++)
            {
                int sum = indexSumDictionary[index - 1] + numbers[index];
                if (sumIndexDictionary.ContainsKey(sum))
                {
                    Console.WriteLine("Found at indices {0} and {1}", sumIndexDictionary[sum] + 1, index);
                    return;
                }
                else
                {
                    sumIndexDictionary.Add(sum, index);
                    indexSumDictionary.Add(index, sum);
                }
            }
        }

        private void getPermutations(List<int> numbers)
        {
            List<List<int>> listOfPermutations = new List<List<int>>();

            getPermutationsInner(numbers, new List<int>(), listOfPermutations);

            foreach(List<int> permutation in listOfPermutations)
            {
                foreach(int n in permutation)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        private void getPermutationsInner(List<int> numbers, List<int> candidate, List<List<int>> permutations)
        {
            if (numbers.Count == 0)
            {
                permutations.Add(candidate);
                return;
            }

            foreach (int n in numbers)
            {
                List<int> numbersCopy = new List<int>();
                foreach (int n1 in numbers)
                {
                    numbersCopy.Add(n1);
                }

                List<int> candidateCopy = new List<int>();
                foreach (int n2 in candidate)
                {
                    candidateCopy.Add(n2);
                }

                numbersCopy.Remove(n);
                candidateCopy.Add(n);
                getPermutationsInner(numbersCopy, candidateCopy, permutations);
            }
        }

        private int binarySearch(int[] array, int l, int u, int target)
        {
            int index = -1;

            if (array == null || array.Length < 1 || (l > u) || ((l == u) && (target != array[l])))
            {
                return index;
            }

            int mid = (l + u) / 2;
            if (target == array[mid])
            {
                return mid;
            }
            else if (target > array[mid])
            {
                return binarySearch(array, mid+1, u, target);
            }
            else
            {
                return binarySearch(array, l, mid-1, target);
            }
        }

        //private void TTS(string text)
        //{
        //    SpeechSynthesizer speaker = new SpeechSynthesizer();
        //    speaker.Rate = 1;
        //    speaker.Volume = 100;
        //    speaker.Speak(text);
        //}

        public string findLongestPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return "";

            char[] s2 = addBoundaries(s.ToCharArray());
            int[] p = new int[s2.Length];
            int c = 0, r = 0; // Here the first element in s2 has been processed.
            int m = 0, n = 0; // The walking indices to compare if two elements are the same
            for (int i = 1; i < s2.Length; i++)
            {
                if (i > r)
                {
                    p[i] = 0; m = i - 1; n = i + 1;
                }
                else
                {
                    int i2 = c * 2 - i;
                    if (p[i2] < (r - i))
                    {
                        p[i] = p[i2];
                        m = -1; // This signals bypassing the while loop below. 
                    }
                    else
                    {
                        p[i] = r - i;
                        n = r + 1; m = i * 2 - n;
                    }
                }
                while (m >= 0 && n < s2.Length && s2[m] == s2[n])
                {
                    p[i]++; m--; n++;
                }
                if ((i + p[i]) > r)
                {
                    c = i; r = i + p[i];
                }
            }
            int len = 0; c = 0;
            for (int i = 1; i < s2.Length; i++)
            {
                if (len < p[i])
                {
                    len = p[i]; c = i;
                }
            }
            char[] ss = new char[2 * len +1];
            //Array.Copy(s2, (long)(c - len), ss, (long)(2 * len - 1));
            int ctr = 0;
            for (int i = c - len; i <= 2 * len + 1; i++)
            {
                ss[ctr++] = s2[i];
            }
            // Arrays.copyOfRange(s2, c - len, c + len + 1);
            return new string(removeBoundaries(ss));
        }

        private char[] addBoundaries(char[] cs)
        {
            if (cs == null || cs.Length == 0)
                return "||".ToCharArray();

            char[] cs2 = new char[cs.Length * 2 + 1];
            for (int i = 0; i < (cs2.Length - 1); i = i + 2)
            {
                cs2[i] = '|';
                cs2[i + 1] = cs[i / 2];
            }
            cs2[cs2.Length - 1] = '|';
            return cs2;
        }

        private char[] removeBoundaries(char[] cs)
        {
            if (cs == null || cs.Length < 3)
                return "".ToCharArray();

            char[] cs2 = new char[(cs.Length - 1) / 2];
            for (int i = 0; i < cs2.Length; i++)
            {
                cs2[i] = cs[i * 2 + 1];
            }
            return cs2;
        }    

        private void ChangeList(IEnumerable<string> list)
        {
            list.ToList().Add("red");
        }
        
    }
}
