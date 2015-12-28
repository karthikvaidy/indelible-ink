using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomSamples
{
    public class Practice
    {
        private static void Main(string[] args)
        {
            Practice p = new Practice();
            /*
            List<int> numbers = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            p.MergeSort(numbers);
            p.QuickSort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */
            //p.GetPermutations(new List<char> { 'a', 'b', 'c', 'd' });
            //List<char> longest = p.maxSubstring("aaaa11a11aa1aa1aaaaa".ToCharArray().ToList());
            //foreach (char ch in longest)
            //{
            //    Console.Write(ch + " ");
            //}

            //Console.WriteLine(p.LongestValidParentheses("(()"));
            //Console.WriteLine(p.LongestValidParentheses(")()())"));
            //Console.WriteLine(p.LongestValidParentheses(")))"));
            //Console.WriteLine(p.LongestValidParentheses("((("));
            //Console.WriteLine(p.LongestValidParentheses("())"));
            //Console.WriteLine(p.LongestValidParentheses("(()()()()"));
            //Console.WriteLine(p.LongestValidParentheses("(((())))"));
            //Console.WriteLine(p.LongestValidParentheses("()()()(((()()()()"));

            Console.WriteLine(p.isPatternMatch("abba", "redbluebluered"));
            Console.WriteLine(p.isPatternMatch("aaaa", "asdasdasdasd"));
            Console.WriteLine(p.isPatternMatch("aabb", "xyzabcxzyabc"));
            Console.WriteLine(p.isPatternMatch("aabba", "catcatgogocat"));

            //Console.WriteLine(p.maxProfit(new int[] { 10, 17, 5, 8, 13, 9 }));

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.MoveZeroes(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}


        }

        public void MergeSort(List<int> numbers)
        {
            if (numbers == null || numbers.Count < 2)
            {
                return;
            }

            // split the list into two parts
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            int i;
            for (i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count / 2)
                    firstHalf.Add(numbers[i]);
                else
                    secondHalf.Add(numbers[i]);
            }

            // call mergesort on each half
            this.MergeSort(firstHalf);
            this.MergeSort(secondHalf);

            // combine the two sorted lists into the original list and return it.
            int j = 0, k = 0;
            i = 0;
            while (true)
            {
                if (i < firstHalf.Count && j < secondHalf.Count)
                {
                    if (firstHalf[i] <= secondHalf[j])
                    {
                        numbers[k++] = firstHalf[i++];
                    }
                    else
                    {
                        numbers[k++] = secondHalf[j++];
                    }
                }
                else if (i < firstHalf.Count)
                {
                    numbers[k++] = firstHalf[i++];
                }
                else if (j < secondHalf.Count)
                {
                    numbers[k++] = secondHalf[j++];
                }
                else
                {
                    break;
                }
            }
        }

        public void QuickSort(List<int> numbers)
        {
            if (numbers == null || numbers.Count < 2)
            {
                return;
            }

            QuickSortInner(numbers, 0, numbers.Count - 1);
        }

        private void QuickSortInner(List<int> numbers, int lower, int upper)
        {
            if (lower >= upper)
            {
                return;
            }
            else if (lower + 1 == upper)
            {
                if (numbers[lower] > numbers[upper])
                {
                    int temp = numbers[lower];
                    numbers[lower] = numbers[upper];
                    numbers[upper] = temp;
                }
                return;
            }

            int pivot = numbers[(upper + lower) / 2];
            int minIndex = lower;
            int maxIndex = upper;

            while (minIndex < maxIndex)
            {
                while (minIndex < maxIndex && numbers[minIndex] < pivot)
                {
                    minIndex++;
                }
                while (maxIndex > minIndex && numbers[maxIndex] > pivot)
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

            QuickSortInner(numbers, lower, minIndex);
            QuickSortInner(numbers, maxIndex, upper);
        }

        public List<List<char>> GetPermutations(List<char> chars)
        {
            if (chars == null || chars.Count == 0)
            {
                return null;
            }

            List<List<char>> permutations = new List<List<char>>();
            getPermutationsInner(chars, new List<char>(), permutations);

            foreach (List<char> list in permutations)
            {
                foreach (char ch in list)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }

            return permutations;
        }

        private void getPermutationsInner(List<char> chars, List<char> currState, List<List<char>> permutations)
        {
            if (chars.Count == 0)
            {
                permutations.Add(currState);
                return;
            }

            foreach (char ch in chars)
            {
                //clone currState and add char and recurse
                List<char> stateCopy = new List<char>();
                foreach (char c in currState)
                {
                    stateCopy.Add(c);
                }
                stateCopy.Add(ch);

                List<char> charsCopy = new List<char>();
                foreach (char c in chars)
                {
                    charsCopy.Add(c);
                }
                charsCopy.Remove(ch);

                getPermutationsInner(charsCopy, stateCopy, permutations);
            }
        }

        public List<char> maxSubstring(List<char> chars)
        {
            if (chars == null || chars.Count == 0)
                return null;

            int startIndex = 0;
            int endIndex = 0;
            int count = 0;
            Dictionary<int, int> countIndexMap = new Dictionary<int, int>();
            for (int i = 0; i < chars.Count; i++)
            {
                char ch = chars[i];
                if (Char.IsLetter(ch))
                {
                    count++;
                }
                else if (Char.IsNumber(ch))
                {
                    count--;
                }
                else
                {
                    // throw exception!?
                }

                if (countIndexMap.ContainsKey(count))
                {
                    int currLongest = endIndex - startIndex;
                    int candidate = i - countIndexMap[count];
                    if (candidate > currLongest)
                    {
                        endIndex = i;
                        startIndex = countIndexMap[count];
                    }
                }
                else
                {
                    countIndexMap.Add(count, i);
                }

            }

            List<char> longest = new List<char>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                longest.Add(chars[i]);
            }

            return longest;
        }

        public bool isPatternMatch(string pattern, string text)
        {
            if (pattern == null || text == null)
                return false;

            int na = 0, nb = 0;
            foreach (char c in pattern)
            {
                switch (c)
                {
                    case 'a': na++; break;
                    case 'b': nb++; break;
                    default: break;//exception
                }
            }

            return isPatternMatchInner(pattern, text, na, nb, string.Empty, string.Empty);
        }

        private bool isPatternMatchInner(string pattern, string text, int na, int nb, string aval, string bval)
        {
            if (na == 0 && nb == 0) // pattern should be empty
            {
                if (text == string.Empty)
                {
                    return true;
                }
                return false;
            }

            if (na == 0)
            {
                if (bval == string.Empty)
                {
                    if (text.Length % nb == 0)
                    {
                        return isRepeatedMatch(text, nb);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return isRepeatedMatch(text, nb, bval);
                }
            }

            else if (nb == 0)
            {
                if (aval == string.Empty)
                {
                    if (text.Length % na == 0)
                    {
                        return isRepeatedMatch(text, na);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return isRepeatedMatch(text, na, aval);
                }
            }

            else
            {
                char ch = pattern[0];

                if (ch == 'a')
                {
                    if (aval == string.Empty)
                    {
                        int maxLen = text.Length / na;
                        for (int i = 1; i < maxLen; i++)
                        {
                            string tempval = text.Substring(0, i);
                            if (isPatternMatchInner(pattern.Substring(1), text.Substring(i), na - 1, nb, tempval, bval))
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length >= aval.Length && text.Substring(0, aval.Length) == aval)
                        {
                            return isPatternMatchInner(pattern.Substring(1), text.Substring(aval.Length), na - 1, nb, aval, bval);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (bval == string.Empty)
                    {
                        int maxLen = text.Length / nb;
                        for (int i = 1; i < maxLen; i++)
                        {
                            string tempVal = text.Substring(0, i);
                            if (isPatternMatchInner(pattern.Substring(1), text.Substring(i), na, nb - 1, aval, tempVal))
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length >= bval.Length && text.Substring(0, bval.Length) == bval)
                        {
                            return isPatternMatchInner(pattern.Substring(1), text.Substring(bval.Length), na, nb - 1, aval, bval);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        private bool isRepeatedMatch(string text, int occ, string val = null)
        {
            if (val == null)
            {
                val = text.Substring(0, text.Length / occ);
            }

            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < occ; i++)
            {
                temp.Append(val);
            }

            return (temp.ToString() == text);
        }


        public bool isPatternMatch1(string pattern, string text)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(text))
            {
                return false;
            }

            int na = 0, nb = 0;
            foreach (char ch in pattern)
            {
                switch (ch)
                {
                    case 'a': na++; break;
                    case 'b': nb++; break;
                    default: break;// throw exception!?
                }
            }

            return isPatternMatchInner1(pattern, text, na, nb, new Dictionary<char, string>());
        }

        private bool isPatternMatchInner1(string pattern, string text, int na, int nb, Dictionary<char, string> map)
        {
            if (pattern == string.Empty)
            {
                return (text == string.Empty);
            }

            char ch = pattern[0];

            if (ch == 'a')
            {
                if (nb == 0)
                {
                    if (map.ContainsKey(ch))
                    {
                        if (text.Length >= map[ch].Length && text.Substring(0, map[ch].Length) == map[ch])
                        {
                            return isPatternMatchInner1(pattern.Substring(1), text.Substring(map[ch].Length), na - 1, nb, map);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        int len = text.Length / na;
                        string val = text.Substring(0, len);
                        text = text.Substring(len);
                        na--;
                        while (text != string.Empty)
                        {
                            if (text.Substring(0, len) != val)
                            {
                                return false;
                            }
                            na--;
                            text = text.Substring(len);
                        }
                        if (text == string.Empty && na == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
                else
                {
                    if (map.ContainsKey(ch))
                    {
                        if (text.Length >= map[ch].Length && text.Substring(0, map[ch].Length) == map[ch])
                        {
                            return isPatternMatchInner1(pattern.Substring(1), text.Substring(map[ch].Length), na - 1, nb, map);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        int maxLen = text.Length / na + 1;
                        Dictionary<char, string> mapCopy = this.GetDeepCopyOfDictionary(map);
                        for (int i = 1; i < maxLen; i++)
                        {
                            mapCopy.Add(ch, text.Substring(0, i));
                            if (isPatternMatchInner1(pattern.Substring(1), text.Substring(i), na - 1, nb, mapCopy))
                            {
                                return true;
                            }
                            mapCopy.Remove(ch);
                        }
                    }
                }
            }
            else
            {
                if (na == 0)
                {
                    if (map.ContainsKey(ch))
                    {
                        if (text.Length >= map[ch].Length && text.Substring(0, map[ch].Length) == map[ch])
                        {
                            return isPatternMatchInner1(pattern.Substring(1), text.Substring(map[ch].Length), na, nb - 1, map);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        int len = text.Length / nb;
                        string val = text.Substring(0, len);
                        text = text.Substring(len);
                        nb--;
                        while (text != string.Empty)
                        {
                            if (text.Substring(0, len) != val)
                            {
                                return false;
                            }
                            nb--;
                            text = text.Substring(len);
                        }
                        if (text == string.Empty && nb == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
                else
                {
                    if (map.ContainsKey(ch))
                    {
                        if (text.Length >= map[ch].Length && text.Substring(0, map[ch].Length) == map[ch])
                        {
                            return isPatternMatchInner1(pattern.Substring(1), text.Substring(map[ch].Length), na, nb - 1, map);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        int maxLen = text.Length / nb + 1;
                        Dictionary<char, string> mapCopy = this.GetDeepCopyOfDictionary(map);
                        for (int i = 1; i < maxLen; i++)
                        {
                            mapCopy.Add(ch, text.Substring(0, i));
                            if (isPatternMatchInner1(pattern.Substring(1), text.Substring(i), na, nb - 1, mapCopy))
                            {
                                return true;
                            }
                            mapCopy.Remove(ch);
                        }
                    }
                }
            }
            return false;
        }

        private Dictionary<char, string> GetDeepCopyOfDictionary(Dictionary<char, string> map)
        {
            Dictionary<char, string> mapCopy = new Dictionary<char, string>();
            foreach (KeyValuePair<char, string> kvp in map)
            {
                mapCopy.Add(kvp.Key, kvp.Value);
            }

            return mapCopy;
        }

        public int maxProfit(int[] prices)
        {
            if (prices == null || prices.Count() == 1)
                return -1;

            int minTillNow = prices[0];
            int maxProfit = prices[1] - prices[0];

            for (int i = 2; i < prices.Count(); i++)
            {
                int candidate = prices[i];
                int potentialProfit = candidate - minTillNow;
                maxProfit = potentialProfit > maxProfit ? potentialProfit : maxProfit;

                if (candidate < minTillNow)
                    minTillNow = candidate;
            }

            return maxProfit;
        }

        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Count() == 0)
                return;

            int offset = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0)
                {
                    offset++;
                }
                else
                {
                    if (offset != 0)
                    {
                        nums[i - offset] = nums[i];
                    }
                }
            }

            for (int i = nums.Count() - offset; i < nums.Count(); i++)
            {
                nums[i] = 0;
            }

        }
    }

    public class LRUCacheV2
    {
        int Capacity;
        int numNodes;
        Dictionary<int, LRUNode> valueNodeMap;
        LinkedList<LRUNode> nodeList;

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

        public LRUCacheV2(int cap)
        {
            this.Capacity = cap;
            this.numNodes = 0;
            valueNodeMap = new Dictionary<int, LRUNode>();
            nodeList = new LinkedList<LRUNode>();
        }

        public void Set(int key, int value)
        {
            if (numNodes == Capacity)
            {
                LinkedListNode<LRUNode> node = nodeList.Last;
                nodeList.RemoveLast();
                if (valueNodeMap.ContainsKey(node.Value.key))
                {
                    valueNodeMap.Remove(node.Value.key);
                }
                else
                {
                    //exception
                }
                numNodes--;
            }
            LRUNode node1 = new LRUNode(key, value);
            nodeList.AddFirst(node1);
            valueNodeMap.Add(key, node1);
            numNodes++;
        }

        public int Get(int key)
        {
            if (valueNodeMap.ContainsKey(key))
            {
                LRUNode node = valueNodeMap[key];
                nodeList.Remove(node);
                nodeList.AddFirst(node);
                return node.value;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            string text = string.Empty;
            foreach (LRUNode node in nodeList)
            {
                text = text + node.key + "  " + node.value + "\n";
            }
            return text;
        }
    }
}
