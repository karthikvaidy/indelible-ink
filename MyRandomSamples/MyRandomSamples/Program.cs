using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyRandomSamples
{
    class Program
    {
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

        class Pair
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
            int capacity;
            Dictionary<int, LRUNode> keyNodeMap;
            LinkedList<LRUNode> lruNodeList;
            int numNodes;

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

        static void Main(string[] args)
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

            //p.QuickSort(sortedNums);
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
 
            */
            #endregion

            //List<int> complements = p.numberComplements(new List<int>() { });
            //p.printList(complements);

            //complements = p.numberComplements(null);
            //p.printList(complements);

            //complements = p.numberComplements(new List<int>() { 1, 2, 3, 4, 5, 6, -3, -5 });
            //p.printList(complements);

            Console.WriteLine(p.minWindow("ADOBECODEBANC", "ABC"));
            Console.WriteLine(p.minWindow("75902135791158897", "159"));
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

            return node1;
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
