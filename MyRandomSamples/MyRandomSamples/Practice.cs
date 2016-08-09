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

            //Console.WriteLine(p.isPatternMatch("abba", "redbluebluered"));
            //Console.WriteLine(p.isPatternMatch("aaaa", "asdasdasdasd"));
            //Console.WriteLine(p.isPatternMatch("aabb", "xyzabcxzyabc"));
            //Console.WriteLine(p.isPatternMatch("aabba", "catcatgogocat"));

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

            //Console.WriteLine(p.reverseWords("hello world"));
            //Console.WriteLine(p.reverseWords("helloworld"));
            //Console.WriteLine(p.reverseWords("  hello world"));
            //Console.WriteLine(p.reverseWords("hello world  "));
            //Console.WriteLine(p.reverseWords("hello   world"));

            //int[,] matrix = { { 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3 }, { 4, 4, 4, 4, 4 }, { 5, 5, 5, 5, 5 } };
            //int[,] matrix = { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
            //p.RotateMatrix(matrix);
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrix = {
            //                {0, 1, 0, 1, 0}, 
            //                {2, 0, 0, 0, 2}, 
            //                {0, 0, 0, 0, 0}, 
            //                {4, 0, 0, 0, 4}, 
            //                {5, 5, 0, 5, 5}
            //                };

            //p.maxZeroSubMatrix(matrix);

            //int[] result = p.longMultiplication(new int[] { 1, 2, 3, 4 }, new int[] { 9, 1 });
            //foreach (int i in result)
            //{
            //    Console.Write(i);
            //}

            //p.getParanCombination(3);

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //Console.WriteLine(p.minJumps(arr));

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            int[] nums = { 1, 2, 3, 4, 5 };
            p.MoveZeroes(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }

        public void moveZeroes(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int offset = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    offset++;
                else
                {
                    if (offset != 0)
                    {
                        array[i - offset] = array[i];
                    }
                }
            }

            for (int i = array.Length - offset; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        public int minJumps(int[] steps)
        {
            if (steps == null || steps.Length == 0)
                return -1;

            int[] jumps = new int[steps.Length];
            jumps[jumps.Length - 1] = 0;

            for (int i = jumps.Length - 2; i >= 0; i--)
            {
                if (steps[i] == 0)
                    jumps[i] = Int32.MaxValue;
                else if (i + steps[i] >= steps.Length - 1)
                    jumps[i] = 1;
                else
                {
                    int min = Int32.MaxValue;
                    for (int j = 1; j <= steps[i]; j++)
                    {
                        min = (jumps[i + j] < min) ? jumps[i + j] : min;
                    }
                    jumps[i] = (min == Int32.MaxValue) ? Int32.MaxValue : min + 1;
                }
            }

            foreach (int q in jumps)
            {
                Console.Write(q + " ");
            }

            return jumps[0];
        }

        public void getParanCombination(int n)
        {
            if (n <= 0)
                return;

            List<string> combinations = new List<string>();

            getParanCombinationsInner(n, n, new StringBuilder(), combinations);

            foreach (string s in combinations)
            {
                Console.WriteLine(s);
            }
        }

        private void getParanCombinationsInner(int numOpen, int numClose, StringBuilder currState, List<string> combinations)
        {
            if (numOpen == 0 && numClose == 0)
            {
                combinations.Add(currState.ToString());
                return;
            }

            if (numOpen > 0)
            {
                StringBuilder sb = new StringBuilder(currState.ToString());
                sb.Append("(");
                getParanCombinationsInner(numOpen - 1, numClose, sb, combinations);
            }
            if (numClose > numOpen)
            {
                StringBuilder sb = new StringBuilder(currState.ToString());
                sb.Append(")");
                getParanCombinationsInner(numOpen, numClose - 1, sb, combinations);
            }

        }

        public int[] longMultiplication(int[] x, int[] y)
        {
            if (x == null || y == null)
                return null;

            List<int> result = new List<int>();

            for (int i = 0; i < y.Length; i++)
            {
                int carry = 0;
                int pos = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    int prod = (x[j] * y[i]) + carry;

                    pos = j + i;
                    while (result.Count <= pos)
                    {
                        result.Add(0);
                    }

                    int sum = result[pos] + prod;
                    carry = sum / 10;
                    sum = sum % 10;

                    result[pos] = sum;
                }
                pos++;
                while (carry != 0)
                {
                    while (result.Count <= pos)
                    {
                        result.Add(0);
                    }
                    int sum = result[pos] + carry;
                    result[pos] = sum % 10;
                    carry = sum / 10;
                    pos++;
                }
            }

            return result.ToArray();
        }

        public int maxZeroSubMatrix(int[,] matrix)
        {
            if (matrix == null)
                return 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int max = 0;
            int[,] memo = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (matrix[i, j] == 0)
                            memo[i, j] = 1;
                        max = (max > 0) ? max : 1;
                    }
                    else
                    {
                        if (matrix[i, j] == 0)
                        {
                            int l = memo[i, j - 1];
                            int u = memo[i - 1, j];
                            int d = memo[i - 1, j - 1];

                            int min = l;
                            min = (min < u) ? min : u;
                            min = (min < d) ? min : d;

                            min++;

                            memo[i, j] = min;

                            max = (max < min) ? min : max;
                        }
                        else
                        {
                            memo[i, j] = 0;
                        }
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

            return max;
        }

        public void RotateMatrix(int[,] matrix)
        {
            if (matrix == null)
                return;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
                return;

            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = i; j < cols - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, cols - i - 1];
                    matrix[j, cols - i - 1] = matrix[rows - i - 1, cols - j - 1];
                    matrix[rows - i - 1, cols - j - 1] = matrix[rows - j - 1, i];
                    matrix[rows - j - 1, i] = temp;
                }
            }
        }

        public string reverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            char[] revChars = s.Reverse().ToArray();

            int start = 0;
            int end = 0;

            while (end < s.Length)
            {
                if (revChars[end] == ' ')
                {
                    if (start != end)
                    {
                        reverseSubstring(revChars, start, end - 1);
                    }
                    end++; 
                    start = end;                    
                }
                else
                {
                    end++;
                }
            }

            if (start != end)
            {
                reverseSubstring(revChars, start, s.Length - 1);
            }

            return new string(revChars);
        }

        private void reverseSubstring(char[] chars, int start, int end)
        {
            int mid = (start + end)/2;

            for (int i = start; i <= mid; i++)
            {
                char c = chars[i];
                chars[i] = chars[end - i + start];
                chars[end - i + start] = c;
            }
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

    public class TSNode
    {
        public int value;
        public List<TSNode> incomingNodes;
        public List<TSNode> outgoingNodes;

        public TSNode(int v)
        {
            this.value = v;
            incomingNodes = new List<TSNode>();
            outgoingNodes = new List<TSNode>();
        }
    }

    public class TopologicalSort
    {
        private Dictionary<int, TSNode> nodesMap;
        private LinkedList<TSNode> nodesList;

        public TopologicalSort()
        {
            nodesMap = new Dictionary<int, TSNode>();
            nodesList = new LinkedList<TSNode>();
        }

        public void AddPair(int x, int y)
        {
            if (!nodesMap.ContainsKey(x))
            {
                TSNode node = new TSNode(x);
                nodesMap.Add(x, node);
                nodesList.AddFirst(node);
            }
            if (!nodesMap.ContainsKey(y))
            {
                TSNode node = new TSNode(y);
                nodesMap.Add(y, node);
                nodesList.AddFirst(node);
            }

            TSNode nodeX = nodesMap[x];
            TSNode nodeY = nodesMap[y];

            nodeX.outgoingNodes.Add(nodeY);
            nodeY.incomingNodes.Add(nodeX);
        }

        public void DoTopologicalSort()
        {
            Queue<int> processingQueue = new Queue<int>();

            foreach (TSNode node in nodesList)
            {
                if (node.incomingNodes.Count == 0)
                {
                    processingQueue.Enqueue(node.value);
                }
            }

            while (processingQueue.Count != 0)
            {
                int val = processingQueue.Dequeue();
                TSNode node = nodesMap[val]; // possible exception - key not found?!

                //process node
                Console.WriteLine(node.value);

                foreach (TSNode n in node.outgoingNodes)
                {
                    n.incomingNodes.Remove(node);
                    if (n.incomingNodes.Count == 0)
                    {
                        processingQueue.Enqueue(n.value);
                    }
                }

                nodesMap.Remove(val);
                nodesList.Remove(node);
            }

            if (nodesMap.Keys.Count != 0)
                Console.WriteLine("Error condition");
        }
    }
}
