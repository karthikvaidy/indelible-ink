﻿using System;
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

            #region old code

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
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.MoveZeroes(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(p.longestPalindrome("banana"));
            //Console.WriteLine(p.longestCommonSubstring("abcdabcdabcd", "ebcdabcdf"));
            //Console.WriteLine(p.reverseStringNew("abcd hello sir"));
            //Console.WriteLine(p.reverseStringNew("abcd hello sir    "));
            //Console.WriteLine(p.reverseStringNew("    abcd hello sir"));

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //Console.WriteLine(p.minJumpsTest(arr));

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.MoveZeroes(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(p.isInterleave("aabcc", "dbbca", "aadbbcbcac"));
            //Console.WriteLine(p.isInterleave("aabcc", "dbbca", "aadbbbaccc"));

            //Console.WriteLine(p.LengthOfLongestSubstring("abcabcbb"));
            //Console.WriteLine(p.LengthOfLongestSubstring("bbbbb"));
            //Console.WriteLine(p.LengthOfLongestSubstring("pwwkew"));

            //KnapSack ks1 = new KnapSack(1, 1);
            //KnapSack ks2 = new KnapSack(3, 4);
            //KnapSack ks3 = new KnapSack(4, 5);
            //KnapSack ks4 = new KnapSack(5, 7);

            //List<KnapSack> list = new List<KnapSack> {ks1, ks2, ks3, ks4};

            //Console.WriteLine(p.knapSackProblem(list, 7));

            //Console.WriteLine(p.subsetSum(new int[] { 2, 3, 7, 8, 10 }, 11));
            //Console.WriteLine(p.subsetSum(new int[] { 2, 3 }, 10));

            //Console.WriteLine(p.isPatternMatchNew("abba", "redbluebluered"));
            //Console.WriteLine(p.isPatternMatchNew("aaaa", "asdasdasdasd"));
            //Console.WriteLine(p.isPatternMatchNew("aabb", "xyzabcxzyabc"));
            //Console.WriteLine(p.isPatternMatchNew("aabba", "catcatgogocat"));

            //int[,] board =
            //{
            //    {1, 2, 3, 4, 5, 6, 7, 8, 9},
            //    {4, 5, 6, 7, 8, 9, 1, 2, 3},
            //    {7, 8, 9, 1, 2, 3, 4, 5, 6},
            //    {2, 3, 4, 5, 6, 7, 8, 9, 1},
            //    {5, 6, 7, 8, 9, 1, 2, 3, 4},
            //    {8, 9, 1, 2, 3, 4, 5, 6, 7},
            //    {3, 4, 5, 6, 7, 8, 9, 1, 2},
            //    {6, 7, 8, 9, 1, 2, 3, 4, 5},
            //    {9, 1, 2, 3, 4, 5, 6, 7, 8}
            //};

            //Console.WriteLine(p.isSudokuValid(board));

            //List<List<string>> lists = p.groupShiftedStrings(new List<string> { "abc", "bcd", "acef", "xyz", "az", "ba", "a", "z" });
            //foreach (var list in lists)
            //{
            //    foreach (string s in list)
            //    {
            //        Console.Write(s + " ");
            //    }
            //    Console.WriteLine();
            //}

            //List<string> combos = p.getPhoneToStringCombinations(new int[] { 1, 2, 3, 4 });
            //foreach (string combo in combos)
            //{
            //    Console.WriteLine(combo);
            //}

            //List<string> combos = p.getCombinations("abcd");
            //foreach (var combo in combos)
            //{
            //    Console.WriteLine(combo);
            //}

            //Console.WriteLine(p.isSubstringMatch("abc","abbacabc"));
            //Console.WriteLine(p.longestPalindromeTest("banana"));

            //Console.WriteLine(p.isInterleaveTest("aabcc", "dbbca", "aadbbcbcac"));
            //Console.WriteLine(p.isInterleaveTest("aabcc", "dbbca", "aadbbbaccc"));

            //int[,] matrix = p.spiralMatrix(4);

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i,j]+ "\t");
            //    }    
            //    Console.WriteLine();
            //}

            //int[] result = p.prodArrayExceptSelf(new int[] {1, 2, 3, 4});
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //int[] arr = {5, 4, 1, 1, 1, 1, 1};
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(p.numJumps(arr));
            //Console.WriteLine(p.minJumps(arr));

            //Knapsack ks1 = new Knapsack(1, 1);
            //Knapsack ks2 = new Knapsack(3, 4);
            //Knapsack ks3 = new Knapsack(4, 5);
            //Knapsack ks4 = new Knapsack(5, 7);

            //List<Knapsack> list = new List<Knapsack> { ks1, ks2, ks3, ks4 };

            //Console.WriteLine(p.knapsack(list, 7));

            //Console.WriteLine(p.IsPerfectSquare(16));
            //Console.WriteLine(p.IsPerfectSquare(25));
            //Console.WriteLine(p.IsPerfectSquare(33));
            //Console.WriteLine(p.IsPerfectSquare(59));

            //List<List<int>> factors = p.factorCombinations(12);
            //foreach (List<int> list in factors)
            //{
            //    foreach (int i in list)
            //    {
            //        Console.Write(i +"  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(p.isListEqualSplit(new int[] {1, 2, 3, 4, 5}));
            //Console.WriteLine(p.isListEqualSplit(new int[] {1, 2, 3, 4, 6}));

            //Console.WriteLine(p.isPatternMatchNew("abba", "redbluebluered"));
            //Console.WriteLine(p.isPatternMatchNew("aaaa", "asdasdasdasd"));
            //Console.WriteLine(p.isPatternMatchNew("aabb", "xyzabcxzyabc"));
            //Console.WriteLine(p.isPatternMatchNew("aabba", "catcatgogocat"));

            //Console.WriteLine(p.evaluateExpresion("1+2*3+4")); //11
            //Console.WriteLine(p.evaluateExpresion("1+2*3-4")); //3

            //List<string> permutations = p.permuteString("abcd");
            //foreach (string s in permutations)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.moveZeroesAgain(nums);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //int[,] matrix = p.getSpiralMatrix(4);

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] colors = new int[] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
            //p.moveColors(colors);

            //foreach (int i in colors)
            //{
            //    Console.WriteLine(i);
            //}

            //p.getSmallestPairSums(new int[] { 1, 7, 11 }, new int[] { 2, 4, 6 }, 6);

            //int[] array = new int[] { 0, 0, 0, 1, 1, 2, 2, 2, 2, 3, 4, 5 };
            //p.removeDups(ref array);

            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] result = p.getIntersection(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 10, 8, 6, 4, 2 });
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int[]> result = p.getKthProduct(new int[] { 1, 7, 11 }, new int[] { 2, 4, 6 }, 6);
            //foreach (int[] array in result)
            //{
            //    Console.WriteLine(array[0] + "  " + array[1] + "  " + array[0] * array[1]);
            //}

            //int[,] dungeon = new int[,] {{-2, 	-3,	3},
            //{-5,	-10,	1},
            //    {10,	30,	-5}};

            //Console.WriteLine(p.calculateMinimumHP(dungeon));

            //DateTime now = DateTime.Now;
            //List<List<int[]>> boards = p.nQueens(8);
            //int ms = (DateTime.Now - now).Milliseconds;

            //Console.WriteLine("Found {0} solutions in {1}ms", boards.Count, ms);

            //foreach (int[] positions in boards[0])
            //{
            //    Console.WriteLine(positions[0] + " " + positions[1]);
            //}

            //Console.WriteLine(p.convertIntToRoman(1000));
            //Console.WriteLine(p.convertIntToRoman(3999));
            //Console.WriteLine(p.convertIntToRoman(1234));

            //Console.WriteLine(p.isPowerOfFour(4));
            //Console.WriteLine(p.isPowerOfFour(16));
            //Console.WriteLine(p.isPowerOfFour(64));
            //Console.WriteLine(p.isPowerOfFour(14));
            //Console.WriteLine(p.isPowerOfFour(40));
            //Console.WriteLine(p.isPowerOfFour(96));
            //Console.WriteLine(p.isPowerOfFour(40));

            //int[,] nums = new int[,] { {9,9,4},
            //                           {6,6,8},
            //                           {2,1,1} };
            //Console.WriteLine(p.longestIncreasingPathInMatrix(nums));

            //SinglyLinkedListNode head = p.CreateSampleLinkedList();
            //p.PrintSinglyLinkedList(head);
            //p.OddEvenList(head);
            //p.PrintSinglyLinkedList(head);
            //Console.WriteLine(p.MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
            //Console.WriteLine(p.MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }));
            //Console.WriteLine(p.MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" }));

            //int[,] matrix = new int[,] {
            //    {0,1,0,0,},
            //    {0,1,1,1,},
            //    {1,1,1,0,},
            //    {0,1,1,1,},
            //    {0,1,0,0,}
            //};
            //Console.WriteLine(p.numIslands(matrix));

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.moveZeroesYetAgain(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> sols = p.substringPermutationMatch("abc", "alabcsdnalscbadnlasnbacdas");
            //foreach (string s in sols)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] nums = { 0, 1, 0, 3, 12 };
            //int[] nums = { 2, 0, 1, 0, 3, 12 };
            //int[] nums = { 0, 0, 0, 0, 0 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //p.moveEmAgain(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //char[] chars = "this is a freakin test".ToCharArray();
            //p.reverse(chars);
            //Console.WriteLine(new string(chars));
            //Console.WriteLine(p.getShortestSpan("this is a this collection of word", new List<string>() { "this", "word" }));

            //Console.WriteLine(p.isWeaveString("abc", "efg", "aebfch"));

            //List<string> strings = new List<string>() { "abc", "ab", "", "a", "abc", "ab", "", "a", "abc", "ab", "", "a", "abc", "ab", "", "a" };
            //p.oddEvenListSplit(strings);
            //foreach (string s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            //EquationSolver s = new EquationSolver();
            //s.AddNode("a", "b", 2.0);
            //s.AddNode("b", "c", 3.0);
            //Console.WriteLine(s.getDivision("a", "c"));
            //Console.WriteLine(s.getDivision("b", "a"));
            //Console.WriteLine(s.getDivision("a", "e"));
            //Console.WriteLine(s.getDivision("a", "a"));
            //Console.WriteLine(s.getDivision("x", "x"));

            //int[] array = new int[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(p.findInRotatedArray(array, 2));
            //Console.WriteLine(p.findInRotatedArray(array, 5));
            //Console.WriteLine(p.findInRotatedArray(array, 9));
            //Console.WriteLine(p.findInRotatedArray(array, 1));
            //Console.WriteLine(p.findInRotatedArray(array, 10));
            //Console.WriteLine(p.findInRotatedArray(array, 0));

            //Console.WriteLine(p.maxProfitNew(new int[] { 10, 17, 5, 8, 19, 9 }));

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //Console.WriteLine(p.minJumps1(arr));
            //Console.WriteLine(p.minJumpsTest(arr));
            //Console.WriteLine(p.minJumps(arr));

            //Console.WriteLine(p.AlienDictionary(new string[] { "wrt", "wrf", "er", "ett", "rftt" }));

            //KnapSack ks1 = new KnapSack(1, 1);
            //KnapSack ks2 = new KnapSack(3, 4);
            //KnapSack ks3 = new KnapSack(4, 5);
            //KnapSack ks4 = new KnapSack(5, 7);

            //List<KnapSack> list = new List<KnapSack> { ks1, ks2, ks3, ks4 };

            //Console.WriteLine(p.knapSackProblem(list, 7));
            //Console.WriteLine(p.knapSackProblem1(list, 7));

            //Console.WriteLine(p.trapRainWater(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}));

            //int[,] matrix = new int[,] {
            //    {0,1,0,0,},
            //    {0,1,1,1,},
            //    {1,1,1,0,},
            //    {0,1,1,1,},
            //    {0,1,0,0,}
            //};

            //Console.WriteLine(p.numIslands3(matrix));

            //List<List<int>> triangle = new List<List<int>>(){new List<int> (){2},
            //    new List<int> (){3,4},
            //    new List<int> (){6,5,7},
            //    new List<int> (){4,1,8,3}};

            //Console.WriteLine(p.minTrianglePathSum(triangle));

            //List<string> perm = p.permuteString1("abcde");
            //foreach (string s in perm)
            //{
            //    Console.WriteLine(s);
            //}

            //List<List<string>> splits = p.getWordsSplit("catsanddog", new List<string> { "cat", "cats", "and", "sand", "dog" });
            //foreach (List<string> list in splits)
            //{
            //    foreach (string s in list)
            //    {
            //        Console.Write(s + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //Console.WriteLine(p.minJumps2(arr));

            //Console.WriteLine(p.maxNonContinuousSum(new int[] { 1, -2, 3, -1, 5, 10, 3 }));

            //Console.WriteLine(p.getLastNode(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3));

            //p.BitTest();

            //int[,] matrix = {
            //                {0, 0, 0, 0, 0}, 
            //                {0, 0, 0, 0, 0}, 
            //                {0, 0, 0, 0, 0}, 
            //                {0, 0, 0, 0, 0}, 
            //                {0, 0, 0, 0, 0}
            //                };

            //int[,] matrix = {
            //                {0, 0, 1, 0, 0}, 
            //                {0, 0, 1, 0, 0}, 
            //                {0, 0, 1, 0, 0}, 
            //                {0, 0, 1, 0, 0}, 
            //                {0, 0, 0, 0, 0}
            //                };

            //int[,] matrix = {
            //                {0, 1, 0, 1, 0}, 
            //                {2, 0, 0, 0, 2}, 
            //                {0, 0, 0, 0, 0}, 
            //                {4, 0, 0, 0, 4}, 
            //                {5, 5, 0, 5, 0}
            //                };

            //Console.WriteLine(p.aStarSearch(matrix, 0, 0, 0, 4));

            //Point p1 = new Point(1, 1);
            //Point p2 = new Point(-1, 1);
            //Point p3 = new Point(-1, -1);

            //Console.WriteLine(p.isReflected(new List<Point> { p1, p2 }));
            //Console.WriteLine(p.isReflected(new List<Point> { p1, p3 }));

            //Console.WriteLine(p.minReplaceNumber(233614));

            //char[,] chars = new char[,] {   {'b','a','l','l'},
            //                                {'a','r','e','a'},
            //                                {'l','e','a','d'},
            //                                {'l','a','d','y'}
            //                            };

            //Console.WriteLine(p.isWordSquare(chars));

            //Console.WriteLine(p.numStrings(3));

            //char[,] map = new char[,] {
            //                            {' ','X',' ',' '},
            //                            {'X',' ','W','X'},
            //                            {' ','X',' ',' '}
            //                          };
            //Console.WriteLine(p.bombEnemy(map));

            //Console.WriteLine(p.longestPath("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext"));
            //Console.WriteLine(p.longestPath("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext"));

            //int[] result = p.countSmaller(new int[] { 10, 2, -2, 5, 4 });
            //int[] result = p.countSmaller(new int[] { 3, 2, 2, 6, 1 });
            //foreach (int i in result)
            //{
            //    Console.Write(i + "  ");
            //}

            //int[,] matrix = new int[,] {
            //    {0,1,0,0,},
            //    {0,1,1,1,},
            //    {1,1,1,0,},
            //    {0,1,1,1,},
            //    {0,1,0,0,}
            //};
            //Console.WriteLine(p.numIslands1(matrix));

            //int[] result = p.longMult(new int[] { 1, 2, 3, 4 }, new int[] { 9, 1 });
            //foreach (int i in result)
            //{
            //    Console.Write(i);
            //}

            //Console.WriteLine(p.isWordSquare(new List<string> { "bass", "auto", "star", "sore" }));
            //Console.WriteLine(p.isWordSquare(new List<string> { "bass", "tuto", "stir", "sore" }));

            //Console.WriteLine(p.closestSequence(new List<int> { 1, 2, 6 }, new List<int> { 0, 1, 3, 4, 5 }));

            //Console.WriteLine(p.groupPoints(5, new int[,] { { 0, 1 }, { 4, 3 }, { 4, 0 } }));

            //ArrayRange range = new ArrayRange(10);
            //range.Toggle(0, 3);
            //Console.WriteLine(range.getState(2));
            //Console.WriteLine(range.getState(5));

            //range.Toggle(1, 4);
            //Console.WriteLine(range.getState(2));
            //Console.WriteLine(range.getState(5));

            //range.Toggle(2, 5);
            //Console.WriteLine(range.getState(2));
            //Console.WriteLine(range.getState(5));

            //int[] res = p.prodRange(new int[] { 1, 2, 3, 4 });
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = { 1, 3, 6, 1, 0, 9 };
            //Console.WriteLine(p.jumpMin(arr));
            //Console.WriteLine(p.minJumps(arr));

            //Console.WriteLine(p.numIslands2(matrix));


            //Console.WriteLine(p.AlienDictionary(new string[] { "wrt", "wrf", "er", "ett", "rftt" }));

            //List<int> result = p.longMultiplication(new List<int> {1, 2, 3, 4}, new List<int> {2,9});
            //foreach (int i in result)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine(p.meltTimes(new int[] { 5, 4, 3, 6, 0, 1 }));
            //Console.WriteLine(p.meltTimes(new int[] { 0, 1, 1, 1, 1, 0 }));

            //Console.WriteLine(p.isPangram("The quick brown fox jumps over the lazy dog"));
            //Console.WriteLine(p.isPangram("We promptly judged antique ivory buckles for the next prize"));
            //Console.WriteLine(p.isPangram("We promptly judged antique ivory buckles for the prize"));

            //Console.WriteLine(p.isFunny("acxz"));
            //Console.WriteLine(p.isFunny("bcxz"));

            //Console.WriteLine(p.isArraySumSplit(new int[] { 1, 2, 3 }));
            //Console.WriteLine(p.isArraySumSplit(new int[] { 1, 2, 3, 3 }));

            //int[] res = p.slidingWindowMaximum(new int[] {1, 3, -1, -3, 5, 3, 6, 7}, 3);

            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //List<List<int>> seq = p.getOrderedSequences(new List<int> { 10, 15, 25 }, new List<int> { 1, 5, 20, 30 });
            //foreach (List<int> list in seq)
            //{
            //    foreach (int i in list)
            //    {
            //        Console.Write(i + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(p.longestCommonSubstring1("qwqweabcdeqweqwe", "abcdelmlkmlkm"));

            //Line l1 = new Line(0, 0, 0, 10, 10);
            //Line l2 = new Line(1, 10, 0, 0, 10);
            //Line l3 = new Line(2, 20, 0, 50, 10);
            //Line l4 = new Line(3, 0, 0, -10, -10);
            //Line l5 = new Line(4, -10, 0, 0, -10);

            //List<Tuple<Line, Line>> intersections = p.GetIntersections(new List<Line> { l1, l2, l3, l4, l5 });

            //foreach(Tuple<Line,Line> tuple in intersections)
            //{
            //    Console.WriteLine(tuple.Item1.id + " " + tuple.Item2.id);
            //}

            //Console.WriteLine(p.rotateStr("abcde", 2));

            //Console.WriteLine(p.removeSpaces("I   live   on     earth"));

            Console.WriteLine(p.IndexToRemoveForPalindrome("aaab"));
            Console.WriteLine(p.IndexToRemoveForPalindrome("baa"));
            Console.WriteLine(p.IndexToRemoveForPalindrome("aaa"));
        }

        public int IndexToRemoveForPalindrome(string s)
        {
            if (s == null)
                return -1;

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    if (isPalin(s, i + 1, j))
                        return i;
                    else if (isPalin(s, i, j - 1))
                        return j;
                    return -1;
                }
                i++;
                j--;
            }
            return -1;
        }

        private bool isPalin(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }

        public string removeSpaces(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            List<char> chars = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                chars.Add(ch);

                while (i < s.Length && s[i] == ' ')
                {
                    i++;
                }

                if (ch == ' ')
                    i--;
            }

            return new string(chars.ToArray());
        }

        public string rotateStr(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (k < 0)
                return null; // exception!?

            if (k % s.Length == 0)
                return s;

            k = k % s.Length;
            char[] chars = s.ToCharArray();

            int currIndex = 0;
            int newIndex = k;
            char temp = chars[k];
            char currChar = chars[currIndex];
            char newChar = chars[newIndex];

            while (newIndex != 0)
            {
                chars[newIndex] = currChar;
                currIndex = newIndex;
                newIndex = (newIndex + k) % s.Length;

                currChar = newChar;
                newChar = chars[newIndex];
            }
            chars[0] = temp;

            return new string(chars);
        }

        public class LinePoint
        {
            public int lineId;
            public int x;
            public int y;
            public bool isStart;
            public LinePoint(int id, int _x, int _y, bool start)
            {
                lineId = id; x = _x; y = _y; isStart = start;
            }

            public override int GetHashCode()
            {
                return (17 * lineId + 23 * x + 97 * y);
            }

            public override bool Equals(object obj)
            {
                LinePoint lp = obj as LinePoint;
                return (lp.lineId == lineId && lp.x == x && lp.y == y);
            }
        }

        public class Line
        {
            public int id;
            public LinePoint start;
            public LinePoint end;

            public Line(int i, int startX, int startY, int endX, int endY)
            {
                id = i;
                start = new LinePoint(id, startX, startY, true);
                end = new LinePoint(id, endX, endY, false);
            }

            public override int GetHashCode()
            {
                return 7 * id + start.GetHashCode() + end.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                Line l = obj as Line;
                return (l.id == id && l.start == start && l.end == end);
            }
        }

        public List<Tuple<Line, Line>> GetIntersections(List<Line> lines)
        {
            if (lines == null || lines.Count() < 2)
                return null;

            Dictionary<int, Line> map = new Dictionary<int, Line>();
            HashSet<Line> set = new HashSet<Line>();
            List<LinePoint> list = new List<LinePoint>();

            foreach (Line l in lines)
            {
                map.Add(l.id, l);

                list.Add(l.start);
                list.Add(l.end);
            }

            list.Sort((l1, l2) => l1.x.CompareTo(l2.x));
            List<Tuple<Line, Line>> result = new List<Tuple<Line, Line>>();
            foreach (LinePoint point in list)
            {
                Line l = map[point.lineId];
                if (!set.Contains(l))
                {
                    // check for intersections,
                    List<Line> intersections = getIntersections(l, set);
                    foreach (var item in intersections)
                    {
                        Tuple<Line, Line> t = new Tuple<Line, Line>(item, l);
                        result.Add(t);
                    }
                    // add to set
                    set.Add(l);
                }
                else
                {
                    // get line id, get line and remove line from set
                    set.Remove(map[point.lineId]);
                }

            }

            return result;
        }

        private List<Line> getIntersections(Line l, HashSet<Line> lines)
        {
            List<Line> result = new List<Line>();

            foreach (Line line in lines)
            {
                if (doesIntersect(line, l) || doesIntersect(l, line))
                    result.Add(line);
            }

            return result;
        }

        private bool doesIntersect(Line a, Line b)
        {
            if (
                ((Math.Min(b.start.x, b.end.x) <= Math.Min(a.start.x, a.end.x)) && (Math.Max(b.start.x, b.end.x) >= Math.Max(a.start.x, a.end.x)))
                &&
                ((Math.Min(b.start.y, b.end.y) <= Math.Min(a.start.y, a.end.y)) && (Math.Max(b.start.y, b.end.y) >= Math.Max(a.start.y, a.end.y)))
                )
                return true;
            return false;
        }

        public string longestCommonSubstring1(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return string.Empty;

            int[,] memo = new int[s.Length, t.Length];
            int maxLen = 1;
            int endIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        memo[i, j] = (s[i] == t[j]) ? 1 : 0;
                    }
                    else
                    {
                        memo[i, j] = 0;
                        if (s[i] == t[j])
                        {
                            int temp = memo[i - 1, j - 1] + 1;
                            if (temp > maxLen)
                            {
                                maxLen = temp;
                                endIndex = i;
                            }
                            memo[i, j] = temp;
                        }

                    }
                }
            }

            return s.Substring(endIndex - maxLen + 1, maxLen);
        }

        public List<List<int>> getOrderedSequences(List<int> a, List<int> b)
        {
            List<List<int>> seq = new List<List<int>>();
            getSequences(a, b, 0, 0, true, true, seq, new List<int>());
            return seq;
        }

        private void getSequences(List<int> a, List<int> b, int i, int j, bool isA, bool canEnd, List<List<int>> seq, List<int> curr)
        {

            if (canEnd && curr.Count() > 0)
                seq.Add(curr);

            List<int> list = a;
            int ind = i;

            if (!isA)
            {
                list = b;
                ind = j;
            }

            if (ind >= list.Count())
                return;

            for (int k = ind; k < list.Count(); k++)
            {
                if (curr.Count() == 0 || list[k] > curr[curr.Count() - 1])
                {
                    List<int> currCopy = new List<int>(curr);
                    currCopy.Add(list[k]);
                    getSequences(a, b, (isA) ? i + 1 : i, (isA) ? j : j + 1, !isA, !isA, seq, currCopy);
                }
            }

        }


        public int jumpMin(int[] array)
        {
            if (array == null || array.Count() < 2)
                return 0;

            int len = array.Count();
            int[] memo = new int[len];
            memo[len - 1] = 0;

            for (int i = len - 2; i >= 0; i--)
            {
                if (array[i] <= 0)
                    memo[i] = Int32.MaxValue;
                else if (array[i] + i >= len - 1)
                    memo[i] = 1;
                else
                {
                    int min = Int32.MaxValue;
                    for (int j = 1; j <= array[i]; j++)
                    {
                        min = Math.Min(min, memo[i + j]);
                    }
                    memo[i] = (min == Int32.MaxValue) ? min : min + 1;
                }
            }
            return memo[0];
        }

        public int[] prodRange(int[] array)
        {
            if (array == null || array.Count() < 2)
                return null;

            int len = array.Count();

            int[] prodLeft = new int[len];
            int[] prodRight = new int[len];

            prodLeft[0] = 1;
            prodRight[len - 1] = 1;

            for (int i = 1; i < len; i++)
            {
                prodLeft[i] = prodLeft[i - 1] * array[i - 1];
                prodRight[len - i - 1] = prodRight[len - i] * array[len - i];
            }

            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = prodLeft[i] * prodRight[i];
            }

            return result;
        }

        public class ArrayRange
        {
            private int[] array;

            public ArrayRange(int len)
            {
                array = new int[len];
            }

            public void Toggle(int l, int h)
            {
                if (l >= 0 && l < array.Length && h >= 0 && h < array.Length && l <= h)
                {
                    array[l]++;
                    if(h < array.Length)
                        array[h + 1] = Math.Abs(array[h + 1] - 1);
                }
            }

            public bool getState(int index)
            {
                if (index >= array.Length || index < 0)
                    return false;

                int val = array[0];
                bool ret = false;
                for (int i = 1; i <= index; i++)
                {
                    val += array[i];
                }
                return (((val % 2) == 0) ? false : true);
            }

        }

        public class DisNode
        {
            public int value;
            public int groupId;
            public DisNode rep;

            public DisNode(int v, int id)
            {
                value = v;
                groupId = id;
                rep = this;
            }
        }

        public class DisGroup
        {
            public int groupId;
            public List<DisNode> nodes;
            public DisGroup(int id)
            {
                groupId = id;
                nodes = new List<DisNode>();
            }
            public void Merge(DisGroup group)
            {
                DisNode newRep = nodes[0].rep;
                foreach (DisNode node in group.nodes)
                {
                    node.groupId = groupId;
                    node.rep = newRep;
                    nodes.Add(node);
                }
            }
        }

        public int groupPoints(int n, int[,] friends)
        {
            Dictionary<int, DisNode> nodeMap = new Dictionary<int, DisNode>();
            Dictionary<int, DisGroup> groupMap = new Dictionary<int, DisGroup>();

            for (int i = 0; i < n; i++)
            {
                DisGroup group = new DisGroup(i);
                DisNode node = new DisNode(i, i);
                group.nodes.Add(node);
                nodeMap.Add(i, node);
                groupMap.Add(i, group);
            }

            for (int i = 0; i < friends.GetLength(0); i++)
            {
                int a = friends[i, 0];
                int b = friends[i, 1];
                DisGroup gA = findGroup(a, groupMap, nodeMap);
                DisGroup gB = findGroup(b, groupMap, nodeMap);
                if (gA.nodes[0].rep != gB.nodes[0].rep)
                {
                    if (gA.nodes.Count() > gB.nodes.Count())
                    {
                        int oldId = nodeMap[b].groupId;
                        gA.Merge(gB);
                        groupMap.Remove(oldId);
                    }
                    else
                    {
                        int oldId = nodeMap[a].groupId;
                        gB.Merge(gA);
                        groupMap.Remove(oldId);
                    }
                }
            }

            return groupMap.Keys.Count();
        }

        private DisGroup findGroup(int a, Dictionary<int, DisGroup> groupMap, Dictionary<int, DisNode> nodeMap)
        {
            DisNode node = nodeMap[a];
            return groupMap[node.groupId];
        }

        public int closestSequence(List<int> list1, List<int> list2)
        {
            return closestSequenceInner(list1, 0, list2, 0);
        }

        private int closestSequenceInner(List<int> list1, int index1, List<int> list2, int index2)
        {
            if (index1 == list1.Count() && index2 == list2.Count())
                return 0;
            if ((index1 >= list1.Count()) || (index2 >= list2.Count()) || (list1.Count() - index1 > list2.Count() - index2))
                return Int32.MaxValue;
            int val1 = closestSequenceInner(list1, index1 + 1, list2, index2 + 1);
            int val2 = closestSequenceInner(list1, index1, list2, index2 + 1);
            if (val1 == Int32.MaxValue && val2 == Int32.MaxValue)
                return val1;
            if (val1 == Int32.MaxValue)
                return val2;
            if (val2 == Int32.MaxValue)
                return Math.Abs(list1[index1] - list2[index2]) + val1;
            return Math.Min(Math.Abs(list1[index1] - list2[index2]) + val1, val2);
        }


        public bool isWordSquare(List<string> words)
        {
            if (words == null || words.Count() == 0)
                return false;

            TrieNode root = new TrieNode();
            int len = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length != len)
                    return false;
                this.addWordToTrie(root, word);
            }

            char[,] wordSquare = new char[len, len];

            return isWordSquareCheck(wordSquare, 0, words, root);
        }

        private bool isWordSquareCheck(char[,] wordSquare, int index, List<string> words, TrieNode node)
        {
            if (index >= wordSquare.GetLength(0))
                return true;
            foreach (string word in words)
            {
                if (canFit(wordSquare, word, index, node))
                {
                    char[,] newWordSquare = addWord(wordSquare, word, index);
                    if (isWordSquareCheck(newWordSquare, index + 1, words, node))
                        return true;
                }
            }
            return false;
        }

        public int[] slidingWindowMaximum(int[] array, int w)
        {
            if (array == null || array.Count() == 0 || w == 0 || w > array.Count())
                return null;

            int len = array.Count();
            int[] result = new int[len - w + 1];
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < len; i++)
            {
                int item = array[i];
                while (list.Count > 0 && array[list.Last.Value] < item)
                {
                    list.RemoveLast();
                }
                while (list.Count > 0 && list.First.Value + w < i)
                {
                    list.RemoveFirst();
                }
                list.AddLast(i);
                if (i >= w-1)
                {
                    result[i - w + 1] = array[list.First.Value];
                }

            }

            return result;
        }


        public bool isArraySumSplit(int[] array)
        {
            if (array == null || array.Count() == 0)
                return false;

            int len = array.Count();
            int[] lSum = new int[len];
            int[] rSum = new int[len];
            lSum[0] = 0;
            rSum[len - 1] = 0;

            for (int i = 1; i < len; i++)
            {
                lSum[i] = lSum[i - 1] + array[i - 1];
                rSum[len - i - 1] = rSum[len - i] + array[len - i];
            }

            for (int i = 0; i < len; i++)
            {
                if (lSum[i] == rSum[i])
                    return true;
            }

            return false;
        }

        private bool canFit(char[,] wordSquare, string word, int index, TrieNode root)
        {
            for (int i = 0; i < index; i++)
            {
                if (wordSquare[index, i] != word[i])
                    return false;

                if (root.next[word[i] - 'a'] == null)
                    return false;

                root = root.next[word[i] - 'a'];
            }
            return true;
        }

        private char[,] addWord(char[,] wordSquare, string word, int index)
        {
            char[,] words = new char[wordSquare.GetLength(0), wordSquare.GetLength(1)];
            for (int i = 0; i < wordSquare.GetLength(0); i++)
            {
                for (int j = 0; j < wordSquare.GetLength(1); j++)
                {
                    words[i, j] = wordSquare[i, j];
                }
            }

            for (int i = index; i < word.Length; i++)
            {
                words[index, i] = word[i];
                words[i, index] = word[i];
            }

            return words;
        }

        //public class TrieNode
        //{
        //    public TrieNode[] next;
        //    public bool isWordEnd;
        //    public TrieNode()
        //    {
        //        next = new TrieNode[26];
        //        isWordEnd = false;
        //    }
        //}

        //private void addWordToTrie(TrieNode node, string s)
        //{

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (node.next[s[i] - 'a'] == null)
        //            node.next[s[i] - 'a'] = new TrieNode();
        //        node = node.next[s[i] - 'a'];
        //    }
        //    node.wordEnd = true;
        //}

        public int[] longMult(int[] a, int[] b)
        {
            if (a == null || a.Count() == 0 || b == null || b.Count() == 0)
                return null;

            List<int> result = new List<int>();

            for (int i = 0; i < a.Count() + b.Count() + 1; i++)
            {
                result.Add(0);
            }

            for (int i = 0; i < a.Count(); i++)
            {
                int carry = 0;
                for (int j = 0; j < b.Count(); j++)
                {
                    int res = (a[i] * b[j]) + carry + result[i + j];
                    result[i + j] = res % 10;
                    carry = res / 10;
                }
                int ctr = i + b.Count();
                while (carry != 0)
                {
                    int res = result[ctr] + carry;
                    result[ctr] = res % 10;
                    carry = res / 10;
                    ctr++;
                }
            }

            while (true)
            {
                if (result[result.Count() - 1] == 0)
                    result.RemoveAt(result.Count() - 1);
                else
                    break;
            }
            return result.ToArray();
        }

        public interface IIterator
        {
            bool HasElements();
            int GetNext();
        }

        public class SingleStream : IIterator
        {
            private Stack<IIterator> stack;
            public SingleStream(List<IIterator> list)
            {
                stack = new Stack<IIterator>();
                foreach (IIterator i in list)
                {
                    stack.Push(i);
                }
            }

            public bool HasElements()
            {
                if (!stack.Any())
                    return false;

                return true;
            }

            public int GetNext()
            {
                int value = Int32.MinValue;
                while (true)
                {
                    if (!stack.Any())
                    {
                        break;
                    }
                    IIterator iter = stack.Pop();

                    if (iter.HasElements())
                    {
                        value = iter.GetNext();
                        if (iter.HasElements())
                        {
                            stack.Push(iter);
                        }
                        break;
                    }
                }
                return value;
            }
        }
        
        public enum MapCellType { Land, Water, Visited };

        public int numIslands1(int[,] map)
        {
            if (map == null)
                return 0;

            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            int numIslands = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (map[i, j] == (int)MapCellType.Land)
                    {
                        numIslands++;
                        mapFloodFill(map, i, j, rows, cols);
                    }
                }
            }
            return numIslands;
        }

        private void mapFloodFill(int[,] map, int row, int col, int rows, int cols)
        {
            map[row, col] = (int)MapCellType.Visited;
            if (row > 0 && map[row - 1, col] == (int)MapCellType.Land)
                mapFloodFill(map, row - 1, col, rows, cols);

            if (row < rows - 1 && map[row + 1, col] == (int)MapCellType.Land)
                mapFloodFill(map, row + 1, col, rows, cols);

            if (col > 0 && map[row, col - 1] == (int)MapCellType.Land)
                mapFloodFill(map, row, col - 1, rows, cols);

            if (col < cols - 1 && map[row, col + 1] == (int)MapCellType.Land)
                mapFloodFill(map, row, col + 1, rows, cols);
        }

        public class NumSmallerNode
        {
            public int value;
            public int rep;
            public int numLeft;

            public NumSmallerNode left;
            public NumSmallerNode right;

            public NumSmallerNode(int v, int n)
            {
                value = v;
                rep = 1;
                numLeft = n;
                left = null;
                right = null;
            }
        }

        public int[] countSmaller(int[] nums)
        {
            if (nums == null || nums.Count() == 0)
                return null;

            NumSmallerNode root = null;

            int[] result = new int[nums.Count()];

            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                root = insert(root, i, nums[i], result, 0);
            }

            return result;
        }

        public NumSmallerNode insert(NumSmallerNode root, int index, int num, int[] result, int preSum)
        {
            if (root == null)
            {
                root = new NumSmallerNode(num, 0);
                result[index] = preSum;
            }
            else if (root.value == num)
            {
                root.rep++;
                result[index] = preSum + root.numLeft;
            }
            else if (root.value < num)
            {
                root.numLeft++;
                root.left = insert(root.left, index, num, result, preSum);
            }
            else
            {
                root.right = insert(root.right, index, num, result, preSum + root.rep + root.numLeft);
            }
            return root;
        }

        public class FileNode
        {
            public int depth;
            public string name;
            public int len;
            public int totLen;
            public List<FileNode> children;

            public FileNode(int d, string n)
            {
                depth = d;
                name = n;
                len = name.Length;
                totLen = len;
                children = new List<FileNode>();
            }
        }

        public int longestPath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return 0;

            string[] tokens = path.Split(new char[] { '\n' });

            List<FileNode> list = new List<FileNode>();

            foreach (string token in tokens)
            {
                int ctr = 0;
                while (token[ctr] == '\t')
                {
                    ctr++;
                }
                FileNode node = new FileNode(ctr, token.Substring(ctr));
                list.Add(node);
            }

            int index = 1;
            int maxLen = Int32.MinValue;
            Stack<FileNode> stack = new Stack<FileNode>();
            stack.Push(list[0]);

            while (index < list.Count())
            {
                FileNode node = stack.Pop();
                FileNode newNode = list[index];
                if (node.depth + 1 == newNode.depth)
                {
                    stack.Push(node);
                    newNode.totLen += node.totLen;
                    stack.Push(newNode);
                    index++;
                    if (newNode.name.Contains('.'))
                        maxLen = Math.Max(maxLen, newNode.totLen);
                }
                else if (node.depth == newNode.depth)
                {
                    newNode.totLen += (node.totLen - node.len);
                    stack.Push(newNode);
                    index++;
                    if (newNode.name.Contains('.'))
                        maxLen = Math.Max(maxLen, newNode.totLen);
                }
                else
                {
                    while (node.depth > newNode.depth)
                    {
                        node = stack.Pop();
                    }
                    stack.Push(node);
                }
            }

            return maxLen;
        }

        public int bombEnemy(char[,] map)
        {
            if (map == null || map.GetLength(0) == 0 || map.GetLength(1) == 0)
                return 0;

            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            int[,] rowVals = new int[rows, cols];
            int[,] colVals = new int[rows, cols];

            int[,] rowValsRev = new int[rows, cols];
            int[,] colValsRev = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (map[i, j] == ' ')
                    {
                        rowVals[i, j] = (j == 0) ? 0 : rowVals[i, j - 1];
                        colVals[i, j] = (i == 0) ? 0 : colVals[i - 1, j];
                    }
                    else if (map[i, j] == 'X')
                    {
                        rowVals[i, j] = (j == 0) ? 1 : rowVals[i, j - 1] + 1;
                        colVals[i, j] = (i == 0) ? 1 : colVals[i - 1, j] + 1;
                    }
                    else //'W'
                    {
                        rowVals[i, j] = 0;
                        colVals[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(rowVals[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(colVals[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (map[i, j] != 'W')
                    {
                        int temp = (j == cols - 1) ? 0 : (map[i, j + 1] == 'X') ? rowValsRev[i, j + 1] + 1 : rowValsRev[i, j + 1];
                        rowValsRev[i, j] += temp;
                        temp = (i == rows - 1) ? 0 : (map[i + 1, j] == 'X') ? colValsRev[i + 1, j] + 1 : colValsRev[i + 1, j];
                        colValsRev[i, j] += temp;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(rowValsRev[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(colValsRev[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int max = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (map[i, j] == ' ')
                        max = Math.Max(max, rowVals[i, j] + colVals[i, j] + rowValsRev[i, j] + colValsRev[i, j]);
                }
            }

            return max;
        }

        public int numStrings(int n)
        {
            List<string> combos = new List<string>();
            numStringsInner(0, n, 1, 0, string.Empty, combos);

            foreach (string s in combos)
            {
                Console.WriteLine(s);
            }
            return combos.Count();
        }

        public void numStringsInner(int currIndex, int n, int numB, int numC, string str, List<string> combos)
        {
            if (currIndex == n)
            {
                combos.Add(str);
                return;
            }

            numStringsInner(currIndex + 1, n, numB, 0, str + 'a', combos);

            if (numB != 0)
                numStringsInner(currIndex + 1, n, numB - 1, 0, str + 'b', combos);

            if (numC != 2)
                numStringsInner(currIndex + 1, n, numB, numC + 1, str + 'c', combos);
        }

        public bool isWordSquare(char[,] chars)
        {
            if (chars == null || chars.GetLength(0) != chars.GetLength(1))
                return false;

            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = i; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] != chars[j, i])
                        return false;
                }
            }

            return true;
        }

        public int minReplaceNumber(int num)
        {
            if (num <= 0)
                return 0;

            List<int> nums = new List<int>();
            int temp = num;
            while (temp != 0)
            {
                nums.Add(temp % 10);
                temp /= 10;
            }

            int min = Int32.MaxValue;

            for (int i = 1; i < nums.Count(); i++)
            {
                int maxIndex = i;
                if (nums[i] > nums[i - 1])
                    maxIndex = i - 1;
                int cand = removeDigit(num, maxIndex);
                min = Math.Min(min, cand);
            }

            return min;
        }

        private int removeDigit(int num, int index)
        {
            return (int)(((int)(num / Math.Pow(10, index + 1)) * Math.Pow(10, index)) + (num % Math.Pow(10, index)));
        }

        public class Point
        {
            public int x;
            public int y;
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }

            public override bool Equals(Object o)
            {
                Point p = o as Point;
                if (p == null)
                    return false;
                else return (x == p.x && y == p.y);
            }

            public override int GetHashCode()
            {
                return x * 31 + y * 17;
            }
        }

        public bool isReflected(List<Point> points)
        {
            if (points == null || points.Count == 0)
                return false;

            HashSet<Point> set = new HashSet<Point>();

            int minX = Int32.MaxValue;
            int maxX = Int32.MinValue;

            foreach (Point p in points)
            {
                minX = Math.Min(minX, p.x);
                maxX = Math.Max(maxX, p.x);
                set.Add(p);
            }

            int sum = minX + maxX;

            foreach (Point p in points)
            {
                if (!set.Contains(new Point(sum - p.x, p.y)))
                    return false;
            }

            return true;
        }

        public class AStarNode
        {
            public int x;
            public int y;
            public int heuristic;
            public int cost;
            public int totalCost;

            public AStarNode(int _x, int _y, int _h, int _c)
            {
                x = _x;
                y = _y;
                heuristic = _h;
                cost = _c;
                totalCost = cost + heuristic;
            }
        }

        public int aStarSearch(int[,] map, int sx, int sy, int ex, int ey)
        {
            bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];
            List<AStarNode> list = new List<AStarNode>();
            int dist = Math.Abs(sx - ex) + Math.Abs(sy - ey);
            list.Add(new AStarNode(sx, sy, dist,0));

            while (list.Count() != 0)
            {
                AStarNode node = list[0];
                list.RemoveAt(0);

                if (node.x == ex && node.y == ey)
                    return node.cost;

                visited[node.x, node.y] = true;

                if (node.x > 0 && map[node.x - 1, node.y] != 1 && visited[node.x - 1, node.y] == false)
                    list.Add(new AStarNode(node.x - 1, node.y, Math.Abs(node.x - 1 - ex) + Math.Abs(node.y - ey), node.cost+1));

                if (node.x < map.GetLength(0)-1 && map[node.x + 1, node.y] != 1 && visited[node.x + 1, node.y] == false)
                    list.Add(new AStarNode(node.x + 1, node.y, Math.Abs(node.x + 1 - ex) + Math.Abs(node.y - ey), node.cost + 1));

                if (node.y > 0 && map[node.x, node.y - 1] != 1 && visited[node.x, node.y - 1] == false)
                    list.Add(new AStarNode(node.x, node.y - 1, Math.Abs(node.x - ex) + Math.Abs(node.y - 1 - ey), node.cost + 1));

                if (node.y < map.GetLength(1)-1 && map[node.x, node.y + 1] != 1 && visited[node.x, node.y + 1] == false)
                    list.Add(new AStarNode(node.x, node.y + 1, Math.Abs(node.x - ex) + Math.Abs(node.y + 1 - ey), node.cost + 1));

                list = list.OrderBy(n => n.totalCost).ToList();
            }

            return Int32.MaxValue;
        }

        public class BinaryIndexedTree
        {
            private int[] tree;
            private int MaxVal;

            public BinaryIndexedTree()
            {
                tree = new int[17];
                MaxVal = 16;
            }

            public int read(int idx)
            {
                int sum = 0;
                while (idx > 0)
                {
                    sum += tree[idx];
                    idx -= (idx & -idx);
                }
                return sum;
            }

            public void update(int idx, int val)
            {
                while (idx <= MaxVal)
                {
                    tree[idx] += val;
                    idx += (idx & -idx);
                }
            }
        }

        public void BitTest()
        {
            BinaryIndexedTree bit = new BinaryIndexedTree();
            bit.update(2, 10);
            Console.WriteLine(bit.read(0));
            Console.WriteLine(bit.read(16));
            Console.WriteLine("==================");
            bit.update(4, 10);
            Console.WriteLine(bit.read(0));
            Console.WriteLine(bit.read(16));
            Console.WriteLine("==================");
            bit.update(5, 10);
            Console.WriteLine(bit.read(0));
            Console.WriteLine(bit.read(16));
            Console.WriteLine("==================");
            bit.update(8, 10);
            Console.WriteLine(bit.read(0));
            Console.WriteLine(bit.read(16));
            Console.WriteLine("==================");
            bit.update(14, 10);
            Console.WriteLine(bit.read(0));
            Console.WriteLine(bit.read(16));
            Console.WriteLine("==================");
        }

        public int getLastNode(List<int> l, int n)
        {
            // null checks
            if (l == null || l.Count() == 0 || n <= 0)
                return -1;

            if (l.Count() == 1)
                return l[0];

            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < l.Count(); i++)
            {
                list.AddLast(i);
            }

            foreach (var v in list)
            {
                Console.Write(v + "  ");
            }
            Console.WriteLine();

            LinkedListNode<int> node = list.First;
            for (int i = 0; i < l.Count() - 1; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (node.Next == null)
                        node = list.First;
                    else
                        node = node.Next;
                }
                LinkedListNode<int> nextNode = node.Next;
                if (nextNode == null)
                    nextNode = list.First;
                list.Remove(node);
                node = nextNode;

                foreach (var v in list)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }

            return l[list.First.Value];
        }

        public int maxNonContinuousSum(int[] array)
        {
            if (array == null || array.Count() <= 0)
                return -1;

            int next = 0, skip = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int max = Math.Max(skip + array[i], next);
                skip = next;
                next = max;
            }

            return next;
        }

        public int minJumps2(int[] array)
        {
            if (array == null || array.Length < 1)
                return 0;

            int[] memo = new int[array.Length];
            memo[memo.Length - 1] = 0;

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] <= 0)
                    memo[i] = Int32.MaxValue;
                else if (i + array[i] >= array.Length - 1)
                    memo[i] = 1;
                else
                {
                    int min = Int32.MaxValue;
                    for (int j = 1; j <= array[i]; j++)
                    {
                        min = Math.Min(min, array[i + j]);
                    }
                    memo[i] = (min == Int32.MaxValue) ? min : min + 1;
                }
            }

            return memo[0];
        }

        public class TrieNode
        {
            public TrieNode[] next;
            public bool wordEnd;

            public TrieNode()
            {
                next = new TrieNode[26];
                wordEnd = false;
            }
        }

        public List<List<string>> getWordsSplit(string s, List<string> dict)
        {
            if (string.IsNullOrEmpty(s) || dict == null || dict.Count == 0)
                return null;

            TrieNode root = new TrieNode();

            foreach (string w in dict)
            {
                this.addWordToTrie(root, w.ToLowerInvariant());
            }

            List<List<string>> splits = new List<List<string>>();

            getSplitsInner(s, root, root, splits, new List<string>(), string.Empty, 0);

            return splits;
        }

        private void addWordToTrie(TrieNode root, string s)
        {
            TrieNode node = root;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (node.next[s[i] - 'a'] == null)
                {
                    node.next[s[i] - 'a'] = new TrieNode();
                }
                node = node.next[s[i] - 'a'];
            }
            node.wordEnd = true;
        }

        private void getSplitsInner(string s, TrieNode oRoot, TrieNode root, List<List<string>> splits, List<string> currSplit, string currWord, int index)
        {
            if (index >= s.Length)
            {
                splits.Add(currSplit);
                return;
            }
            currWord += s[index];
            if (root.next[s[index] - 'a'] != null)
            {
                if (root.next[s[index] - 'a'].wordEnd == true)
                {
                    List<string> splitCopy = new List<string>(currSplit);
                    splitCopy.Add(currWord);
                    getSplitsInner(s, oRoot, oRoot, splits, splitCopy, string.Empty, index + 1);
                }
                getSplitsInner(s, oRoot, root.next[s[index] - 'a'], splits, currSplit, currWord, index + 1);
            }
        }

        public List<string> permuteString1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            List<string> permutations = new List<string>();

            permuteStringInner(s.ToCharArray().ToList<char>(), permutations, new List<char>());

            return permutations;
        }

        private void permuteStringInner(List<char> chars, List<string> permutations, List<char> currState)
        {
            if (chars.Count == 0)
            {
                permutations.Add(new string(currState.ToArray()));
            }

            List<char> charsCopy = new List<char>(chars);
            for (int i = 0; i < charsCopy.Count; i++)
            {
                char ch = chars[i];
                List<char> stateCopy = new List<char>(currState);
                stateCopy.Add(ch);
                charsCopy.Remove(ch);
                permuteStringInner(charsCopy, permutations, stateCopy);
                charsCopy.Add(ch);
            }

        }

        public int minTrianglePathSum(List<List<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0)
                return 0;

            List<int> memo = new List<int>();

            for (int i = 0; i < (triangle[triangle.Count - 1]).Count; i++)
            {
                memo.Add((triangle[triangle.Count - 1])[i]);
            }

            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    memo[j] = (triangle[i])[j] + Math.Min(memo[j], memo[j + 1]);
                }
            }

            return memo[0];
        }

        public enum CellType { Land, Water, Visited };

        public int numIslands3(int[,] matrix)
        {
            if (matrix == null)
                return -1;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int numIslands = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == (int)CellType.Land)
                    {
                        innerFill(matrix, i, j, rows, cols);
                        numIslands++;
                    }
                }
            }
            return numIslands;
        }

        private void innerFill(int[,] matrix, int r, int c, int rows, int cols)
        {
            matrix[r, c] = (int)CellType.Visited;

            if (r > 0 && matrix[r - 1, c] == (int)CellType.Land)
                innerFill(matrix, r - 1, c, rows, cols);
            if (r < rows - 1 && matrix[r + 1, c] == (int)CellType.Land)
                innerFill(matrix, r + 1, c, rows, cols);
            if (c > 0 && matrix[r, c - 1] == (int)CellType.Land)
                innerFill(matrix, r, c - 1, rows, cols);
            if (c < cols - 1 && matrix[r, c + 1] == (int)CellType.Land)
                innerFill(matrix, r, c + 1, rows, cols);
        }

        public int trapRainWater(int[] array)
        {
            if (array == null || array.Length < 1)
                return -1;

            int[] lMax = new int[array.Length];
            int[] rMax = new int[array.Length];
            int water = 0;

            lMax[0] = array[0];
            rMax[rMax.Length - 1] = array[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                lMax[i] = Math.Max(array[i], lMax[i - 1]);
                rMax[array.Length - i - 1] = Math.Max(rMax[array.Length - i], array[array.Length - 1 - i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                water += (Math.Min(lMax[i], rMax[i]) - array[i]);
            }
            return water;
        }

        public int knapSackProblem1(List<KnapSack> knapsacks, int weightLimit)
        {
            if (knapsacks == null || knapsacks.Count() == 0 || weightLimit == 0)
                return -1;

            int[,] memo = new int[knapsacks.Count(), weightLimit + 1];

            for (int i = 0; i < knapsacks.Count(); i++)
            {
                for (int j = 0; j < weightLimit + 1; j++)
                {
                    if (i == 0)
                    {
                        memo[i, j] = (j >= knapsacks[i].weight) ? memo[i, j] = knapsacks[i].value : 0;
                    }
                    else
                    {
                        if (j < knapsacks[i].weight)
                            memo[i, j] = memo[i - 1, j];
                        else
                            memo[i, j] = Math.Max(memo[i - 1, j], knapsacks[i].value + memo[i - 1, j - knapsacks[i].weight]);
                    }

                }
            }

            return memo[knapsacks.Count() - 1, weightLimit];
        }

        public bool isFunny(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (Math.Abs(s[i + 1] - s[i]) != Math.Abs(s[s.Length - i - 1] - s[s.Length - i - 2]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isPangram(string line)
        {
            if (string.IsNullOrEmpty(line) || line.Length < 26)
                return false;

            int hash = 0;

            foreach (char ch in line)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    hash = hash | (1 << (ch - 'A'));
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    hash = hash | (1 << (ch - 'a'));
                }
            }

            return (hash == (int)(Math.Pow(2, 26) - 1));
        }

        public int meltTimes(int[] histo)
        {
            if (histo == null || histo.Length == 0)
                return 0;

            int[] memo = new int[histo.Length];
            memo[0] = 1;
            memo[memo.Length - 1] = 1;

            int minTime = Int32.MinValue;

            for (int i = 1; i < memo.Length - 2; i++)
            {
                memo[i] = Math.Min(histo[i], memo[i - 1] + 1);
            }

            for (int i = memo.Length - 2; i > 0; i--)
            {
                int min = Math.Min(histo[i], memo[i + 1] + 1);
                memo[i] = Math.Min(min, memo[i]);
                minTime = Math.Max(minTime, memo[i]);
            }
            return minTime;
        }

        public class MedalTally
        {
            private class Medals
            {
                public int Gold;
                public int Silver;
                public int Bronze;
            }
            private Dictionary<string, Medals> map = new Dictionary<string, Medals>();

            private void testAndAddCountry(string c)
            {
                if (!map.ContainsKey(c))
                    map.Add(c, new Medals());
            }

            public void AddGold(string c)
            {
                testAndAddCountry(c);
                map[c].Gold++;
            }

            public void AddSilver(string c)
            {
                testAndAddCountry(c);
                map[c].Silver++;
            }

            public void AddBronze(string c)
            {
                testAndAddCountry(c);
                map[c].Bronze++;
            }
        }

        public string[] getMedalTally(string[] medals)
        {
            if (medals == null || medals.Count() == 0)
                return null;

            MedalTally tally = new MedalTally();

            foreach (string medal in medals)
            {
                string[] splits = medal.Split(' ');
                tally.AddGold(splits[0]);
                tally.AddSilver(splits[1]);
                tally.AddBronze(splits[2]);
            }

            return null;
        }

        public List<int> longMultiplication(List<int> num1, List<int> num2)
        {
            if (num1 == null || num1.Count() == 0 || num2 == null || num2.Count() == 0)
                return null;

            List<int> result = new List<int>();

            for (int i = 0; i < num1.Count() + num2.Count(); i++)
            {
                result.Add(0);
            }

            for (int i = 0; i < num1.Count(); i++)
            {
                int a = num1[i];
                int carry = 0;
                int j = 0;
                for (j = 0; j < num2.Count(); j++)
                {
                    int b = num2[j];

                    int prod = result[i + j] + (a * b) + carry;
                    carry = prod / 10;

                    result[i + j] = prod % 10;
                }

                while (carry != 0)
                {
                    int t = result[i + j] + carry;
                    result[i + j] = t % 10;
                    carry = t / 10;
                    j++;
                }
            }

            while (true)
            {
                if (result[result.Count() - 1] == 0)
                    result.RemoveAt(result.Count() - 1);
                else
                    break;
            }

            return result;
        }
        public int findInRotatedArray(int[] array, int n)
        {
            if (array == null || array.Count() < 1)
                return -1;

            int low = 0;
            int high = array.Count() - 1;
            int index = -1;
            while (low <= high)
            {
                if (high - low == 1)
                {
                    if (array[high] == n) { index = high; break; }
                    else if (array[low] == n) { index = low; break; }
                    break;
                }
                int mid = (low + high) / 2;
                if (array[mid] == n)
                {
                    index = mid;
                    break;
                }
                if (array[mid] > array[low]) // left has no break
                {
                    if (n < array[mid] && n >= array[low])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else // right has no break
                {
                    if (n > array[mid] && n <= array[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return index;
        }

        public int numIslands2(int[,] map)
        {
            if (map == null || map.GetLength(0) == 0 || map.GetLength(1) == 0)
                return 0;

            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            int numIslands = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (map[i, j] == 0)
                    {
                        floodFillMap(map, i, j, rows, cols);
                        numIslands++;
                    }
                }
            }
            return numIslands;
        }

        private void floodFillMap(int[,] map, int r, int c, int rows, int cols)
        {
            map[r, c] = 2;

            if (r > 0 && map[r - 1, c] == 0)
                floodFillMap(map, r - 1, c, rows, cols);

            if (r < rows - 1 && map[r + 1, c] == 0)
                floodFillMap(map, r + 1, c, rows, cols);

            if (c > 0 && map[r, c - 1] == 0)
                floodFillMap(map, r, c - 1, rows, cols);

            if (c < cols - 1 && map[r, c + 1] == 0)
                floodFillMap(map, r, c + 1, rows, cols);
        }

        public class Interval
        {
            public int start;
            public int end;
            public Interval(int s, int e)
            {
                this.start = s;
                this.end = e;
            }
        }

        public List<Interval> insertInterval(List<Interval> list, Interval i)
        {
            if (list == null || i == null)
                return null;

            if (list.Count() == 0)
                return new List<Interval>() { i };

            List<Interval> result = new List<Interval>();
            int index = 0;

            while (index < list.Count())
            {
                if ((list[index].end < i.start) || (list[index].start <= i.start && list[index].end >= i.end) || (list[index].start > i.end))
                {
                    result.Add(list[index++]);
                }
                else if (list[index].start <= i.start)
                {
                    int start = list[index].start;
                    int end;
                    while (index < list.Count() && !((list[index].start > i.end) || (list[index].end > i.end)))
                    {
                        index++;
                    }
                    if ((index == list.Count()) || (list[index].start > i.end))
                    {
                        end = i.end;
                    }
                    else
                    {
                        end = list[index].end;
                    }
                    result.Add(new Interval(start, end));
                    index++;
                }
            }
            return result;
        }

        public bool isPattMatch(string pattern, string text)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(text))
                return false;

            if (pattern[0] == 'b')
                pattern = switchChars(pattern);

            int na = countChars2(pattern, 'a');
            int nb = pattern.Length - na;

            int maxA = text.Length / na;

            for (int i = 0; i <= maxA; i++)
            {
                if (nb == 0 || ((text.Length - (na * i)) % nb == 0))
                {
                    if (isMatch(pattern, text, i, (nb == 0) ? 0 : ((text.Length - (na * i)) / nb)))
                        return true;
                }
            }

            return false;
        }

        private string switchChars(string s)
        {
            char[] chars = new char[s.Length];
            int ctr = 0;
            foreach (char c in s)
            {
                if (c == 'a') chars[ctr] = 'b';
                if (c == 'b') chars[ctr] = 'a';
                ctr++;
            }
            return new string(chars);
        }

        private int countChars2(string s, char ch)
        {
            int ctr = 0;
            foreach (char c in s)
            {
                if (c == ch) ctr++;
            }
            return ctr;
        }

        private bool isMatch(string pattern, string text, int lenA, int lenB)
        {
            string a = string.Empty;
            string b = string.Empty;
            int index = 0;
            foreach (char p in pattern)
            {
                if (p == 'a')
                {
                    if (a == string.Empty)
                    {
                        a = text.Substring(index, lenA);
                    }
                    else
                    {
                        string s = text.Substring(index, lenA);
                        if (s != a)
                            return false;
                    }
                    index += lenA;
                }
                else
                {
                    if (b == string.Empty)
                    {
                        b = text.Substring(index, lenB);
                    }
                    else
                    {
                        string s = text.Substring(index, lenB);
                        if (s != b)
                            return false;
                    }
                    index += lenB;
                }
            }
            return true;
        }

        public string longestPalinSubStr(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            bool[,] memo = new bool[s.Length, s.Length];
            int len = 1;
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                memo[i, i] = true;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    memo[i - 1, i] = true;
                    if (len == 1)
                    {
                        len = 2;
                        index = i - 1;
                    }
                }

            }

            for (int offset = 2; offset < s.Length; offset++)
            {
                for (int j = 0; j < s.Length - offset; j++)
                {
                    int row = j;
                    int col = j + offset;

                    if ((s[row] == s[col]) && memo[row, col - 2])
                    {
                        memo[row, col] = true;
                        if (col - row + 1 > len)
                        {
                            len = col - row + 1;
                            index = row;
                        }
                    }
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    Console.Write(memo[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return s.Substring(index, len);
        }

        public int getTrianglePathSum(List<List<int>> triangle)
        {
            if (triangle == null || triangle.Count() == 0)
                return -1;

            int[] memo = new int[triangle[triangle.Count() - 1].Count()];

            for (int i = 0; i < memo.Count(); i++)
            {
                memo[i] = (triangle[triangle.Count() - 1])[i];
            }

            for (int i = triangle.Count() - 2; i >= 0; i--)
            {
                for (int j = 0; j < (triangle[i]).Count(); j++)
                {
                    memo[j] = (triangle[i])[j] + Math.Min(memo[j], memo[j + 1]);
                }
            }

            return memo[0];
        }

        public enum Suit
        {
            Spade,
            Diamond,
            Clubs,
            Heart
        };

        public class Card
        {
            private Suit suit;

            public Suit Suit
            {
                get { return suit; }
                set { suit = value; }
            }
            public char num;

            public Card(Suit s, char c)
            {
                this.suit = s;
                this.num = c;
            }
        }

        public Card[] createCardsPack()
        {
            Card[] cards = new Card[52];
            int ctr = 0;
            for (int i = 0; i < 13; i++)
            {
                char ch = (i < 8) ? (char)('0' + i + 2) : (i == 8) ? '0' : (i == 9) ? 'J' : (i == 10) ? 'Q' : (i == 11) ? 'K' : 'A';
                Card c = new Card(Suit.Spade, ch);
                cards[ctr++] = c;
                c = new Card(Suit.Diamond, ch);
                cards[ctr++] = c;
                c = new Card(Suit.Clubs, ch);
                cards[ctr++] = c;
                c = new Card(Suit.Heart, ch);
                cards[ctr++] = c;
            }
            return cards;
        }

        public void shuffleCards(Card[] cards)
        {
            if (cards == null || cards.Count() == 0)
                return;

            int end = cards.Count();
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < cards.Count(); i++)
            {
                int index = rand.Next(end);

                Card temp = cards[index];
                cards[index] = cards[end - 1];
                cards[end - 1] = temp;

                end--;
            }
        }

        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Count() < 1)
                return -1;

            if (nums[0] > target)
                return 0;

            if (nums[nums.Count() - 1] < target)
                return nums.Count();

            int low = 0;
            int high = nums.Count() - 1;

            while (true)
            {
                if (low == high)
                {
                    int val = (nums[low] < target) ? low + 1 : low;
                    return val;
                }

                int mid = (high + low) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

        }

        public string AlienDictionary(string[] words)
        {
            if (words == null || words.Count() == 0)
                return string.Empty;

            TSort sort = new TSort();

            for (int i = 1; i < words.Count(); i++)
            {
                string a = words[i - 1];
                string b = words[i];
                int x = 0;
                int y = 0;

                while (x < a.Length && y < b.Length)
                {
                    if (a[x] != b[y])
                    {
                        sort.AddPair(a[x], b[y]);
                        break;
                    }
                    x++;
                    y++;
                }

            }
            return sort.DoTopSort();
        }

        public class TNode
        {
            public char data;
            public List<TNode> incoming;
            public List<TNode> outgoing;
            public TNode(char c)
            {
                data = c;
                incoming = new List<TNode>();
                outgoing = new List<TNode>();
            }
        }

        public class TSort
        {
            LinkedList<TNode> list;
            Dictionary<char, TNode> map;

            public TSort()
            {
                list = new LinkedList<TNode>();
                map = new Dictionary<char, TNode>();
            }

            public void AddPair(char a, char b)
            {
                if (!map.ContainsKey(a))
                {
                    TNode node = new TNode(a);
                    list.AddLast(node);
                    map.Add(a, node);
                }
                if (!map.ContainsKey(b))
                {
                    TNode node = new TNode(b);
                    list.AddLast(node);
                    map.Add(b, node);
                }
                TNode aNode = map[a];
                TNode bNode = map[b];
                aNode.outgoing.Add(bNode);
                bNode.incoming.Add(aNode);
            }

            public string DoTopSort()
            {
                Queue<TNode> queue = new Queue<TNode>();
                foreach (TNode node in list)
                {
                    if (node.incoming.Count() == 0)
                    {
                        queue.Enqueue(node);
                    }
                }
                StringBuilder sb = new StringBuilder();
                while (queue.Count() != 0)
                {
                    TNode node = queue.Dequeue();
                    sb.Append(node.data + "-->");

                    foreach (TNode n in node.outgoing)
                    {
                        n.incoming.Remove(node);
                        if (n.incoming.Count() == 0)
                        {
                            queue.Enqueue(n);
                        }
                    }

                    map.Remove(node.data);
                    list.Remove(node);
                }

                return sb.ToString();
            }

        }

        public int maxProfitNew(int[] prices)
        {
            if (prices == null || prices.Count() < 2)
                return 0;

            int maxProfit = Int32.MinValue;
            int min = prices[0];
            for (int i = 1; i < prices.Count(); i++)
            {
                maxProfit = Math.Max(maxProfit, prices[i] - min);
                min = Math.Min(prices[i], min);
            }

            return maxProfit;
        }

        public class EquationNode
        {
            public string val;
            public Dictionary<string, double> links;

            public EquationNode(string v)
            {
                val = v;
                links = new Dictionary<string, double>();
            }
        }

        public class EquationSolver
        {
            public Dictionary<string, EquationNode> nodeMap;

            public EquationSolver()
            {
                nodeMap = new Dictionary<string, EquationNode>();
            }

            public void AddNode(string t1, string t2, double d)
            {
                if (!nodeMap.ContainsKey(t1))
                {
                    EquationNode n = new EquationNode(t1);
                    nodeMap.Add(t1, n);
                }
                if (!nodeMap.ContainsKey(t2))
                {
                    EquationNode n = new EquationNode(t2);
                    nodeMap.Add(t2, n);
                }

                EquationNode n1 = nodeMap[t1];
                EquationNode n2 = nodeMap[t2];
                n1.links.Add(t2, d);
                n2.links.Add(t1, (1/d));
            }

            public double getDivision(string s, string d)
            {
                if (s == d)
                    return 1;
                if (!nodeMap.ContainsKey(s) || !nodeMap.ContainsKey(d))
                    return -1;

                double div = findDiv(s, d, 1.0, new Dictionary<string, bool> ());
                return div;
            }

            private double findDiv(string s, string d, double val, Dictionary<string, bool> visited)
            {
                if (s == d)
                    return val;

                int ctr = 0;
                int value = 0;
                foreach (KeyValuePair<string, double> kvp in nodeMap[s].links)
                {
                    if (!visited.ContainsKey(kvp.Key))
                    {
                        Dictionary<string, bool> visitedCopy = new Dictionary<string, bool>(visited);
                        visitedCopy.Add(kvp.Key, true);
                        double v = findDiv(kvp.Key, d, val*kvp.Value, visitedCopy);
                        if (v != 0)
                            return v;
                        ctr ++;
                    }
                }

                if (ctr == 0)
                    return 0;

                return value;
            }

        }

        public class TopSortNode
        {
            public string data;
            public Dictionary<string, bool> incomingNodes;
            public Dictionary<string, bool> outgoingNodes;
            public TopSortNode(string d)
            {
                data = d;
                incomingNodes = new Dictionary<string, bool>();
                outgoingNodes = new Dictionary<string, bool>();
            }
        }

        public class TopSort
        {
            Dictionary<string, TopSortNode> map;
            LinkedList<TopSortNode> list;

            public TopSort()
            {
                map = new Dictionary<string, TopSortNode>();
                list = new LinkedList<TopSortNode>();
            }

            public void addPair(string source, string dest)
            {
                if (!map.ContainsKey(source))
                {
                    TopSortNode node = new TopSortNode(source);
                    map.Add(source, node);
                    list.AddLast(node);
                }
                if (!map.ContainsKey(dest))
                {
                    TopSortNode node = new TopSortNode(dest);
                    map.Add(dest, node);
                    list.AddLast(node);
                }
                TopSortNode s = map[source];
                TopSortNode d = map[dest];
                s.outgoingNodes.Add(dest, true);
                d.incomingNodes.Add(source, true);
            }

            public string doTopologicalSort()
            {
                Queue<string> queue = new Queue<string>();

                foreach (TopSortNode node in list)
                {
                    if (node.incomingNodes.Count() == 0)
                    {
                        queue.Enqueue(node.data);
                    }
                }

                StringBuilder result = new StringBuilder();

                while (queue.Count() != 0)
                {
                    TopSortNode node = map[queue.Dequeue()]; // exception?!

                    result.Append(node.data + " -> ");

                    foreach (string s in node.outgoingNodes.Keys)
                    {
                        TopSortNode n = map[s];
                        n.incomingNodes.Remove(node.data);
                        if (n.incomingNodes.Count() == 0)
                            queue.Enqueue(n.data);
                    }
                }

                return result.ToString();
            }

        }

        public class Stacks
        {
            private int capacityPerStack;
            private Stack<Stack<int>> stacks;

            public Stacks(int cap)
            {
                // if(cap <=0) throw exception
                this.capacityPerStack = cap;
                stacks = new Stack<Stack<int>>();
                Stack<int> stack = new Stack<int>(capacityPerStack);
                stacks.Push(stack);
            }

            public void Push(int n)
            {
                Stack<int> top = stacks.Pop();
                if (top.Count() < this.capacityPerStack - 1)
                {
                    top.Push(n);
                    stacks.Push(top);
                }
                else
                {
                    stacks.Push(top);
                    Stack<int> stack = new Stack<int>(capacityPerStack);
                    stack.Push(n);
                    stacks.Push(stack);
                }
            }

            public int Pop()
            {
                int val;
                Stack<int> top = stacks.Pop();
                if (top.Count() == 0)
                {
                    if (stacks.Count() == 0)
                        return -1; // exception!?
                    top = stacks.Pop();
                    val = top.Pop();
                    stacks.Push(top);
                }
                else
                {
                    val = top.Pop();
                    stacks.Push(top);
                }
                return val;
            }

        }

        public void oddEvenListSplit(List<string> strings)
        {
            if (strings == null || strings.Count() < 2)
                return;

            int evenIndex = 0;
            int oddIndex = strings.Count() - 1;

            while (evenIndex < oddIndex)
            {
                while (evenIndex < strings.Count() && (strings[evenIndex].Length % 2 == 0))
                {
                    evenIndex++;
                }

                while (oddIndex >= 0 && (strings[oddIndex].Length % 2 == 1))
                {
                    oddIndex--;
                }

                if (evenIndex < oddIndex)
                {
                    string temp = strings[evenIndex];
                    strings[evenIndex] = strings[oddIndex];
                    strings[oddIndex] = temp;
                }
            }
        }

        public bool isWeaveString(string s, string t, string w)
        {
            if (string.IsNullOrEmpty(w) && string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
                return true;

            if (string.IsNullOrEmpty(w) || string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || (s.Length + t.Length != w.Length))
                return false;

            bool[,] memo = new bool[s.Length + 1, t.Length + 1];

            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = 0; j <= t.Length; j++)
                {
                    if (i == 0 && j == 0)
                        memo[i, j] = true;
                    else if (i == 0)
                    {
                        memo[i, j] = (memo[i, j - 1] && (t[j - 1] == w[j - 1]));
                    }
                    else if (j == 0)
                    {
                        memo[i, j] = (memo[i - 1, j] && (s[i - 1] == w[i - 1]));
                    }
                    else
                    {
                        memo[i, j] = ((memo[i, j - 1] && (t[j - 1] == w[i + j - 1])) || (memo[i - 1, j] && (s[i - 1] == w[i + j - 1])));
                    }

                }
            }

            return memo[s.Length, t.Length];
        }

        public string getShortestSpan(string text, List<string> words)
        {
            if (string.IsNullOrEmpty(text) || words == null || words.Count() == 0)
                return null;

            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
            foreach (string s in words)
            {
                map.Add(s, new List<int>());
            }

            string[] splits = text.Split(' ');
            for (int i = 0; i < splits.Count(); i++)
            {
                if (map.ContainsKey(splits[i]))
                    map[splits[i]].Add(i);
            }

            int startIndex = 0;
            int len = Int32.MaxValue;
            bool shouldBreak = false;
            while (!shouldBreak)
            {
                int sInd = Int32.MaxValue;
                int lInd = Int32.MinValue;
                string sWord = string.Empty;
                string lWord = string.Empty;
                foreach (string w in words)
                {
                    if (map[w].Count() == 0)
                    {
                        shouldBreak = true;
                        break;
                    }
                    if ((map[w])[0] < sInd)
                    {
                        sWord = w;
                        sInd = (map[w])[0];
                    }
                    if ((map[w])[0] > lInd)
                    {
                        lWord = w;
                        lInd = (map[w])[0];
                    }
                }
                if (!shouldBreak)
                {
                    if (lInd - sInd < len)
                    {
                        len = lInd - sInd;
                        startIndex = sInd;
                    }
                    if (map.ContainsKey(sWord))
                        map[sWord].RemoveAt(0);
                }
            }

            string ret = string.Empty;
            if (len != Int32.MaxValue)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i <= len; i++)
                {
                    sb.Append(splits[startIndex + i] + " ");
                }
                ret = sb.ToString();
            }
            return ret;
        }

        public int minFrogJump(char[] rocks, int vel)
        {
            if (rocks == null || rocks.Count() < 1 || vel < 0)
                return -1;

            List<List<int>> memo = new List<List<int>>(rocks.Count() + 2);

            memo[memo.Count - 1] = new List<int>();
            int lastIndex = - 1;

            for (int i = rocks.Count() - 1; i >= 0; i--)
            {
                if (rocks[i] == 'R')
                {
                    if (lastIndex == -1)
                    {
                        memo[i] = new List<int>() {rocks.Count() - i - 1};
                    }
                    else
                    {
                        int diff = lastIndex - i;
                        List<int> velocities = new List<int>() {diff - 1};
                        List<int> preVel = memo[lastIndex + 1];
                        foreach (int v in preVel)
                        {
                            velocities.Add(v + diff);
                        }
                        memo[i] = velocities;
                    }
                    lastIndex = i;
                }
                else
                {
                    memo[i] = null;
                }
            }
            return 0;
        }

        public void moveEmAgain(int[] array)
        {
            if (array == null || array.Count() < 2)
                return;

            int offset = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    offset++;
                else if (offset != 0)
                    array[i - offset] = array[i];
            }

            for (int i = array.Count() - offset; i < array.Count(); i++)
            {
                array[i] = 0;
            }
        }

        public void reverse(char[] array)
        {
            if (array == null || array.Count() == 0)
                return;

            reverseCharsAgain(array, 0, array.Count() - 1);

            int start = 0;
            int i = 0;

            while (i < array.Count())
            {
                if (array[i] == ' ')
                {
                    reverseCharsAgain(array, start, i - 1);
                    start = i + 1;
                }
                i++;
            }

            reverseCharsAgain(array, start, i - 1);
        }

        private void reverseCharsAgain(char[] array, int start, int end)
        {
            if (start == end)
                return;

            for (int i = start; i <= start + ((end - start) / 2); i++)
            {
                char temp = array[i];
                array[i] = array[end + start - i];
                array[end + start - i] = temp;
            }

        }

        public bool isListEqualSplit(int[] nums)
        {
            if (nums == null || nums.Count() < 2)
                return false;

            int sum = 0;
            foreach (int n in nums)
                sum += n;

            int target = ((sum + 1) / 2);

            bool[,] memo = new bool[nums.Count(), target + 1];

            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = 0; j < target + 1; j++)
                {
                    if (i == 0)
                    {
                        if (j == nums[i])
                            memo[i, j] = true;
                    }
                    else
                    {
                        if (j < nums[i])
                            memo[i, j] = memo[i - 1, j];
                        else if (j == nums[i])
                            memo[i, j] = true;
                        else
                            memo[i, j] = (memo[i - 1, j] || memo[i - 1, j - nums[i]]);
                    }

                }
            }

            return memo[nums.Count() - 1, target] || memo[nums.Count() - 1, target - 1];

        }

        public List<string> substringPermutationMatch(string s, string text)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(text) || s.Length > text.Length)
                return null;

            List<string> solutions = new List<string>();

            int sHash = createHashString(s);
            int tHash = createHashString(text.Substring(0, s.Length));
            if (sHash == tHash)
                solutions.Add(text.Substring(0, s.Length));

            for (int i = 1; i <= text.Length - s.Length; i++)
            {
                tHash = adjustHash(tHash, text[i - 1], text[s.Length + i - 1]);
                if (sHash == tHash)
                    solutions.Add(text.Substring(i, s.Length));

            }
            return solutions;
        }

        private int[] primes = new int[26] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };

        private int createHashString(string s)
        {
            int hash = 1;
            foreach (char ch in s)
            {
                hash *= primes[ch - 'a'];
            }
            return hash;
        }

        private int adjustHash(int hash, char remove, char add)
        {
            return (int)(hash * primes[add - 'a'] / primes[remove - 'a']);
        }

        public class RandomizedSet
        {
            private List<int> list;
            private Dictionary<int, int> map;
            private int count;

            public RandomizedSet()
            {
                list = new List<int>();
                map = new Dictionary<int, int>();
                count = 0;
            }

            public bool Add(int n)
            {
                if (map.ContainsKey(n))
                    return false;
                if (count < list.Count())
                {
                    list[count] = n;
                    map.Add(n, count);
                }
                else
                {
                    list.Add(n);
                    map.Add(n, list.Count() - 1);
                }

                count++;
                return true;
            }

            public bool Remove(int n)
            {
                if (!map.ContainsKey(n) || count == 0)
                    return false;

                int index = map[n];
                if (index != list.Count() - 1)
                {
                    int lastElem = list[list.Count() - 1];
                    list[index] = lastElem;
                    map[lastElem] = index;
                }
                list[list.Count() - 1] = Int32.MinValue;
                map.Remove(n);
                count--;

                return true;
            }

            public int Random()
            {
                if (count < 1)
                    return Int32.MinValue;
                Random rand = new Random();
                int randIndex = rand.Next(count);
                return list[randIndex];
            }

        }

        public List<List<int>> factorCombinations(int n)
        {
            if (n < 2)
                return null;

            List<List<int>> factors = new List<List<int>>();
            factorize(n, factors, new List<int>());

            return (new HashSet<List<int>> (factors)).ToList();
        }

        private void factorize(int n, List<List<int>> factors, List<int> currList)
        {
            if (n <= 3)
            {
                currList.Add(n);
                currList = currList.OrderBy(num => num).ToList();
                factors.Add(currList);
                return;
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    List<int> currListCopy = new List<int>(currList);
                    currListCopy.Add(i);
                    factorize(n / i, factors, currListCopy);
                }
            }

        }

        public class Flatten2DLists
        {
            private List<List<int>> lists;
            private List<int> indexes;
            private int index;

            public Flatten2DLists(List<List<int>> l)
            {
                if (l.Count() < 0)
                    return;
                lists = l;
                indexes = new List<int>();
                index = 0;
            }

            public int getNext()
            {
                int val = Int32.MinValue;
                int ctr = 0;
                while (true)
                {
                    List<int> list = lists[index];
                    if (indexes[index] >= list.Count())
                    {
                        index = (index == lists.Count() - 1) ? 0 : index + 1;
                        ctr++;
                    }
                    else
                    {
                        val = list[indexes[index]];
                        indexes[index]++;
                        index = (index == lists.Count() - 1) ? 0 : index + 1;
                        break;
                    }
                    if (ctr == lists.Count())
                    {
                        break;
                    }
                }
                return val;
            }

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

        public bool IsPerfectSquare(int num)
        {
            if (num < 0)
                return false;

            int min = 0;
            int max = num;

            while (true)
            {
                if (min > max)
                    return false;

                int mid = (int)((min + max) / 2);
                if (mid * mid == num)
                    return true;
                else if (mid * mid < num)
                    min = mid + 1;
                else
                    max = mid - 1;
            }

            return false;
        }

        public class Knapsack
        {
            public int Weight;
            public int Value;

            public Knapsack(int w, int v)
            {
                this.Weight = w;
                this.Value = v;
            }

        }

        public int knapsack(List<Knapsack> knapsacks, int maxWeight)
        {
            if (knapsacks == null || knapsacks.Count() == 0 || maxWeight < 1)
                return 0;

            int[,] memo = new int[knapsacks.Count(), maxWeight+1];

            for (int i = 0; i < knapsacks.Count(); i++)
            {
                for (int j = 0; j <= maxWeight; j++)
                {
                    if (j == 0)
                        memo[i, j] = 0;
                    else
                    {
                        if (i == 0)
                        {
                            if (j < knapsacks[i].Weight)
                                memo[i, j] = 0;
                            else
                                memo[i, j] = knapsacks[i].Value;
                        }
                        else
                        {
                            if (j < knapsacks[i].Weight)
                                memo[i, j] = memo[i - 1, j];
                            else
                                memo[i, j] = Math.Max(memo[i - 1, j],knapsacks[i].Value + memo[i - 1, j - knapsacks[i].Weight]);
                        }
                    }
                }
            }
            return memo[knapsacks.Count() - 1, maxWeight];
        }

        public int[] prodArrayExceptSelf(int[] array)
        {
            if (array == null || array.Count() < 1)
                return null;

            int[] prod1 = new int[array.Count()];
            int[] prod2 = new int[array.Count()];
            int[] prod = new int[array.Count()];

            prod1[0] = 1;
            prod2[prod2.Count() - 1] = 1;
            for (int i = 1; i < array.Count(); i++)
            {
                prod1[i] = prod1[i - 1] * array[i - 1];
                prod2[array.Count() - i - 1] = prod2[array.Count() - i] * array[array.Count() - i];
            }

            for (int i = 0; i < array.Count(); i++)
            {
                prod[i] = prod1[i] * prod2[i];
            }

            return prod;

        }

        public int[,] spiralMatrix(int n)
        {
            if (n < 1)
                return null;

            int[,] matrix = new int[n, n];
            int num = 1;

            for (int layer = 0; layer < (n / 2); layer++)
            {
                int temp = num;
                for (int i = layer; i < n - layer - 1; i++)
                {
                    matrix[layer, i] = temp;
                    matrix[i, n - layer - 1] = temp + (n - layer - 1);
                    matrix[n - 1 - layer, n - i - 1] = temp + 2 * (n - layer - 1);
                    matrix[n - i - 1, layer] = temp + 3 * (n - layer - 1);
                    temp++;
                }
                num += 4*(n - layer - 1);
            }

            if (n % 2 == 1)
            {
                matrix[n / 2, n / 2] = num;
            }

            return matrix;
        }

        public bool isInterleaveTest(string s1, string s2, string t)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || string.IsNullOrEmpty(t) ||
                s1.Length + s2.Length != t.Length)
                return false;

            bool[,] memo = new bool[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i < s1.Length + 1; i++)
            {
                for (int j = 0; j < s2.Length + 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        memo[i, j] = true;
                    }
                    else if (i == 0)
                    {
                        memo[i, j] = (memo[i, j - 1] && t[j - 1] == s2[j - 1]);
                    }
                    else if (j == 0)
                    {
                        memo[i, j] = (memo[i - 1, j] && t[i - 1] == s1[i - 1]);
                    }
                    else
                    {
                        memo[i, j] = ((memo[i - 1, j] && t[i + j - 1] == s1[i - 1]) ||
                                      (memo[i, j - 1] && t[i + j - 1] == s2[j - 1]));
                    }
                }
            }
            return memo[s1.Length, s2.Length];
        }

        public string longestPalindromeTest(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1)
                return string.Empty;

            bool[,] memo = new bool[s.Length, s.Length];
            int endIndex = 1;
            int maxLen = 1;

            // main diagonal
            for (int i = 0; i < s.Length; i++)
            {
                memo[i, i] = true;
            }

            // one off diagonal
            for (int i = 0; i < s.Length - 1; i++)
            {
                memo[i, i + 1] = (s[i] == s[i + 1]) ? true : false;
            }

            // rest of matrix
            for (int offset = 2; offset < s.Length; offset++)
            {
                for (int i = 0; i < s.Length - offset; i++)
                {
                    int row = i;
                    int col = i + offset;

                    memo[row, col] = false;

                    if ((s[row] == s[col]) && (memo[row, col - 2] == true))
                    {
                        memo[row, col] = true;
                        if (col - row > maxLen)
                        {
                            maxLen = col - row;
                            endIndex = col;
                        }
                    }
                }
            }
            return s.Substring(endIndex - maxLen, maxLen + 1);
        }

        public bool isSubstringMatch(string s, string text)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(text) || s.Length > text.Length)
                return false;

            int sHash = hashString(s);
            int textHash = hashString(text.Substring(0, s.Length));

            if (textHash == sHash && s == text.Substring(0, s.Length))
                return true;

            for (int i = s.Length; i < text.Length; i++)
            {
                textHash = modifyHash(textHash, text[i - s.Length], text[i], s.Length);

                if (textHash == sHash && s == text.Substring(i - s.Length + 1, s.Length))
                    return true;

            }

            return false;
        }

        private int hashString(string s)
        {
            int hash = 0;
            for (int i = 0; i < s.Length; i++)
            {
                hash += (int)(Math.Pow(128, i) * s[i]);
            }

            return hash;
        }

        private int modifyHash(int hash, int charToRemove, int charToAdd, int strLen)
        {
            return (int)(((hash - charToRemove) / 128) + (Math.Pow(128, strLen - 1) * charToAdd));
        }

        public List<string> getCombinations(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            List<string> combos = new List<string>();
            getCombinationsInner(s.ToCharArray(), 0, combos);
            return combos;
        }

        private void getCombinationsInner(char[] chars, int index, List<string> combinations)
        {
            if (index >= chars.Count())
                return;

            char ch = chars[index];

            List<string> newCombos = new List<string>();
            newCombos.Add(ch.ToString());

            foreach (string s in combinations)
            {
                newCombos.Add(s + ch);
            }

            combinations.AddRange(newCombos);

            getCombinationsInner(chars, index + 1, combinations);

        }

        public void moveZeroesAgain(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return;

            int offset = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 0)
                    offset++;
                else if (offset != 0)
                    nums[j - offset] = nums[j];
            }

            for (int j = nums.Length - offset; j < nums.Length; j++)
            {
                nums[j] = 0;
            }

        }

        public List<string> getPhoneToStringCombinations(int[] number)
        {
            List<string> strings = new List<string>();
            this.getCombinations(number, strings, 0, string.Empty);

            return strings;
        }

        private void getCombinations(int[] numbers, List<string> strings, int index, string currString)
        {
            if (index >= numbers.Length)
            {
                strings.Add(currString);
                return;
            }

            char[] chars = getCharsForDigit(numbers[index]);

            if (chars != null && chars.Length != 0)
            {
                foreach (char ch in chars)
                {
                    getCombinations(numbers, strings, index + 1, currString + ch);
                }
            }
            else
            {
                getCombinations(numbers, strings, index + 1, currString);
            }

        }

        private char[] getCharsForDigit(int digit)
        {
            switch (digit)
            {
                case 1: return new char[] { }; break;
                case 2: return new char[] { 'a', 'b', 'c' }; break;
                case 3: return new char[] { 'd', 'e', 'f' }; break;
                case 4: return new char[] { 'g', 'h', 'i' }; break;
                case 5: return new char[] { 'j', 'k', 'l' }; break;
                case 6: return new char[] { 'm', 'n', 'o' }; break;
                case 7: return new char[] { 'p', 'q', 'r', 's' }; break;
                case 8: return new char[] { 't', 'u', 'v' }; break;
                case 9: return new char[] { 'w', 'x', 'y', 'z' }; break;
                default: break;
            }
            return new char[] { };
        }

        public void moveZeroesYetAgain(int[] array)
        {
            if (array == null || array.Count() == 0)
                return;

            int offset = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] == 0)
                    offset++;
                else if (offset != 0)
                    array[i - offset] = array[i];
            }
            for (int i = array.Count() - offset; i < array.Count(); i++)
            {
                array[i] = 0;
            }
        }


        public enum LocationTypes
        {
            Land, Water, Visited
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

        public int numIslands(int[,] matrix)
        {
            if (matrix == null)
                return 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int numIslands = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == (int)LocationTypes.Land)
                    {
                        floodFill(matrix, i, j, rows, cols);
                        numIslands++;
                    }
                }
            }

            return numIslands;
        }

        private void floodFill(int[,] matrix, int row, int col, int rows, int cols)
        {
            Queue<Pair> processingQueue = new Queue<Pair>();
            processingQueue.Enqueue(new Pair(row, col));

            while (processingQueue.Count() != 0)
            {
                Pair p = processingQueue.Dequeue();
                matrix[p.row, p.col] = (int)LocationTypes.Visited;

                if (p.row > 0 && matrix[p.row - 1, p.col] == (int)LocationTypes.Land)
                    processingQueue.Enqueue(new Pair(p.row - 1, p.col));

                if (p.row < rows - 1 && matrix[p.row + 1, p.col] == (int)LocationTypes.Land)
                    processingQueue.Enqueue(new Pair(p.row + 1, p.col));

                if (p.col > 0 && matrix[p.row, p.col - 1] == (int)LocationTypes.Land)
                    processingQueue.Enqueue(new Pair(p.row, p.col - 1));

                if (p.col < cols - 1 && matrix[p.row, p.col + 1] == (int)LocationTypes.Land)
                    processingQueue.Enqueue(new Pair(p.row, p.col + 1));
            }

        }


        public int MaxProduct(string[] words)
        {
            if (words == null || words.Count() < 1)
                return 0;

            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string word in words)
            {
                int mask = 0;
                foreach (char ch in word)
                {
                    mask = mask | (1 << (ch - 'a'));
                }
                map.Add(word, mask);
            }

            int prod = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                for (int j = i; j < words.Count(); j++)
                {
                    if ((map[words[i]] & map[words[j]]) == 0)
                    {
                        prod = Math.Max(prod, (words[i].Length * words[j].Length));
                    }
                }
            }

            return prod;
        }

        public class SinglyLinkedListNode
        {
            public int value;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int val)
            {
                this.value = val;
                next = null;
            }
        }

        public SinglyLinkedListNode CreateSampleLinkedList()
        {
            SinglyLinkedListNode head = new SinglyLinkedListNode(0);
            SinglyLinkedListNode node = head;
            for (int i = 1; i <= 10; i++)
            {
                SinglyLinkedListNode node1 = new SinglyLinkedListNode(i);
                node.next = node1;
                node = node1;
            }

            return head;
        }

        public void OddEvenList(SinglyLinkedListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return;

            SinglyLinkedListNode oddHead = head;
            SinglyLinkedListNode oddTail = head;
            SinglyLinkedListNode evenHead = head.next;
            SinglyLinkedListNode evenTail = head.next;

            while (evenTail != null)
            {
                SinglyLinkedListNode oddNext = evenTail.next;
                SinglyLinkedListNode oddNextNext = oddNext.next;
                evenTail.next = oddNextNext;
                evenTail = evenTail.next;
                oddNext.next = oddTail.next;
                oddTail.next = oddNext;
                oddTail = oddNext;
            }
        }

        public void PrintSinglyLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode node = head;
            while (node != null)
            {
                Console.Write(node.value);
                if (node.next != null)
                    Console.Write("-->");
                node = node.next;
            }
            Console.WriteLine();
        }

        public int longestIncreasingPathInMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return -1;

            int[,] paths = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int max = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    List<int> cand = new List<int>();
                    int len = longestPathInner(matrix, paths, i, j);
                    max = (len > max) ? len : max;
                }
            }
            return max;
        }

        private int longestPathInner(int[,] matrix, int[,] paths, int row, int col)
        {
            if (paths[row, col] != 0)
                return paths[row, col];

            int max = 1;

            if (row > 0 && matrix[row - 1, col] > matrix[row, col])
                max = Math.Max(max, 1 + longestPathInner(matrix, paths, row - 1, col));

            if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] > matrix[row, col])
                max = Math.Max(max, 1 + longestPathInner(matrix, paths, row + 1, col));

            if (col > 0 && matrix[row, col - 1] > matrix[row, col])
                max = Math.Max(max, 1 + longestPathInner(matrix, paths, row, col - 1));

            if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] > matrix[row, col])
                max = Math.Max(max, 1 + longestPathInner(matrix, paths, row, col + 1));

            paths[row, col] = max;
            return max;
        }

        public bool isPowerOfFour(int n)
        {
            n = (n < 0) ? -n : n;
            double x = Math.Log(n) / Math.Log(4);
            return (x - (int)(x) == 0);
        }

        public static readonly string[] OnesInRoman = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        public static readonly string[] TensInRoman = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        public static readonly string[] HundInRoman = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        public static readonly string[] ThouInRoman = { "M", "MM", "MMM" };

        public string convertIntToRoman(int n)
        {
            if (n < 0 || n >= 4000)
                return null;

            if (n == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            int thou = n / 1000;
            if (thou > 0)
                sb.Append(ThouInRoman[thou - 1]);

            n %= 1000;

            int hund = n / 100;
            if (hund > 0)
                sb.Append(HundInRoman[hund - 1]);

            n %= 100;

            int tens = n / 10;
            if (tens > 0)
                sb.Append(TensInRoman[tens - 1]);

            n %= 10;

            if (n > 0)
                sb.Append(OnesInRoman[n - 1]);

            return sb.ToString();
        }


        public List<List<int[]>> nQueens(int n)
        {
            if (n < 4)
                return null;

            List<List<int[]>> boards = new List<List<int[]>>();
            nQueensInner(boards, new List<int[]>(), 0, n);

            return boards;
        }

        private void nQueensInner(List<List<int[]>> boards, List<int[]> board, int currIndex, int boardSize)
        {
            if (currIndex == boardSize)
            {
                boards.Add(board);
                return;
            }

            for (int i = 0; i < boardSize; i++)
            {
                int[] pos = new int[] { currIndex, i };
                if (isPositionLegal(board, pos))
                {
                    List<int[]> boardCopy = new List<int[]>(board);
                    boardCopy.Add(pos);
                    nQueensInner(boards, boardCopy, currIndex + 1, boardSize);
                }
            }

        }

        private bool isPositionLegal(List<int[]> board, int[] pos)
        {
            int posSum = pos[0] + pos[1];
            int posDiff = pos[0] - pos[1];
            foreach (int[] array in board)
            {
                int sum = array[0] + array[1];
                int diff = array[0] - array[1];

                if (array[0] == pos[0] || array[1] == pos[1] || posSum == sum || posDiff == diff)
                    return false;
            }

            return true;
        }


        public int calculateMinimumHP(int[,] dungeon)
        {
            int m = dungeon.GetLength(0);
            int n = dungeon.GetLength(1);

            //init dp table
            int[,] h = new int[m, n];

            h[m - 1, n - 1] = Math.Max(1 - dungeon[m - 1, n - 1], 1);

            //init last row
            for (int i = m - 2; i >= 0; i--)
            {
                h[i, n - 1] = Math.Max(h[i + 1, n - 1] - dungeon[i, n - 1], 1);
            }

            //init last column
            for (int j = n - 2; j >= 0; j--)
            {
                h[m - 1, j] = Math.Max(h[m - 1, j + 1] - dungeon[m - 1, j], 1);
            }

            //calculate dp table
            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    int down = Math.Max(h[i + 1, j] - dungeon[i, j], 1);
                    int right = Math.Max(h[i, j + 1] - dungeon[i, j], 1);
                    h[i, j] = Math.Min(right, down);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(h[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return h[0, 0];
        }

        public List<int[]> getKthProduct(int[] array1, int[] array2, int k)
        {
            if (array1 == null || array1.Count() == 0 || array2 == null || array2.Count() == 0)
                return null;

            List<int[]> result = new List<int[]>();
            int[] smaller = array2;
            int[] larger = array1;
            if (array1.Count() < array2.Count())
            {
                smaller = array1;
                larger = array2;
            }

            int[] indices = new int[smaller.Count()];
            int ctr = 0;

            while (ctr < k)
            {
                int smallestIndex = 0;
                int smallestProd = Int32.MaxValue;

                for (int i = 0; i < indices.Count(); i++)
                {
                    if (indices[i] >= larger.Count())
                        continue;

                    int temp = smaller[i] * larger[indices[i]];
                    if (temp < smallestProd)
                    {
                        smallestProd = temp;
                        smallestIndex = i;
                    }
                }

                if (smallestProd == Int32.MaxValue)
                {
                    throw new Exception("Bad data");
                }
                int[] array = new int[2] { smaller[smallestIndex], larger[indices[smallestIndex]] };
                result.Add(array);
                indices[smallestIndex]++;
                ctr++;

            }
            return result;
        }

        public class NodeWithParent
        {
            public int value; //generic

            public NodeWithParent left;
            public NodeWithParent right;
            public NodeWithParent parent;
        }

        class NodeIterator
        {
            NodeWithParent node;

            //Constructor
            public NodeIterator(NodeWithParent root)
            {
                node = root;

                // initialize to first element in in-order traversal.
                // Go into the left subtree until left node
                while (node.left != null)
                {
                    node = node.left;
                }
            }

            public object current()
            {
                return node;
            }

            public bool moveNext()
            {
                if (node == null)
                    return false;

                //if node has right child, return left most child or right subtree - if right child has no left children, return right child
                if (node.right != null)
                {
                    node = node.right;
                    while (node.left != null)
                    {
                        node = node.left;
                    }
                    return true;
                }

                //if node has no right child, we go up the tree with parent pointer
                // let p = parent ptr
                else
                {
                    NodeWithParent parent = node.parent;
                    while (parent != null)
                    {
                        if (parent.left == node)
                        {
                            node = parent;
                            return true;
                        }

                        NodeWithParent grandparent = parent.parent;

                        if (grandparent == null)
                        {
                            return false;
                        }

                        // keep traversing to p.parent, until p.parent's left child is p || parent is null
                        if (grandparent.left == parent)
                        {
                            node = grandparent;
                            return true;
                        }
                        else
                        {
                            parent = grandparent;
                        }
                    }
                }

                // if null return false;
                return false;
            }
        }

        public int[] getIntersection(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null || array1.Count() == 0 || array2.Count() == 0)
                return null;

            Array.Sort(array1);
            Array.Sort(array2);

            int i = 0;
            int j = 0;
            List<int> result = new List<int>();

            while (i < array1.Count() && j < array2.Count())
            {
                if (array1[i] == array2[j])
                {
                    int val = array1[i];
                    result.Add(val);
                    while (i < array1.Count() && array1[i] == val)
                    {
                        i++;
                    }
                    while (j < array2.Count() && array2[j] == val)
                    {
                        j++;
                    }
                }
                else
                {
                    if (array1[i] < array2[j])
                    {
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return result.ToArray();
        }


        public void removeDups(ref int[] array)
        {
            if (array == null || array.Count() < 2)
                return;

            int index = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[index] != array[i])
                {
                    if (++index != i)
                        array[index] = array[i];
                }
            }
            ++index;

            Array.Resize(ref array, index);
        }

        public void getSmallestPairSums(int[] nums1, int[] nums2, int k)
        {
            if (nums1 == null || nums1.Count() < 1 || nums2 == null || nums2.Count() < 1 || k < 1 || k > (nums1.Count() * nums2.Count()))
                return;

            int i = 0;
            int j = 0;
            int ctr = 0;

            while (ctr < k)
            {
                int[] result = new int[2];
                int cand1 = Int32.MaxValue;
                int cand2 = Int32.MaxValue;
                if (i + 1 < nums1.Count())
                {
                    cand1 = Math.Min(cand1, (nums1[i + 1] * nums2[j]));
                }
                if (j + 1 < nums2.Count())
                {
                    cand2 = Math.Min(cand2, (nums1[i] * nums2[j + 1]));
                }

                if (cand1 < cand2)
                {
                    result[0] = nums1[i++];
                    result[1] = nums2[j];
                }
                else
                {
                    result[0] = nums1[i];
                    result[1] = nums2[j++];
                }
                ctr++;

                //Print result
                Console.WriteLine("[{0},{1}]", result[0], result[1]);
            }

        }

        public void moveColors(int[] colors)
        {
            if (colors == null || colors.Count() < 2)
                return;

            int zeroIndex = 0;
            int twoIndex = colors.Count() - 1;

            int ptr1 = 0;

            while (ptr1 < twoIndex)
            {
                if (colors[ptr1] == 0)
                {
                    colors[zeroIndex++] = 0;
                }
                else if (colors[ptr1] == 2)
                {
                    colors[twoIndex--] = 2;
                }
                ptr1++;
            }

            for (int i = zeroIndex; i < twoIndex; i++)
            {
                colors[i] = 1;
            }

        }

        public int[,] getSpiralMatrix(int n)
        {
            if (n < 1)
                return null;

            int[,] matrix = new int[n, n];
            int currNum = 1;

            for (int layer = 0; layer <= n / 2; layer++)
            {

                if (layer == n / 2 && n % 2 == 1)
                {
                    matrix[layer, layer] = currNum++;
                }
                else
                {
                    int maxElem = n - (layer * 2) - 1;
                    for (int j = layer; j < maxElem; j++)
                    {
                        matrix[layer, j] = currNum++;
                    }
                    for (int j = layer; j < maxElem; j++)
                    {
                        matrix[j, n - layer - 1] = currNum++;
                    }
                    for (int j = layer; j < maxElem; j++)
                    {
                        matrix[n - layer - 1, n - j - 1] = currNum++;
                    }
                    for (int j = layer; j < maxElem; j++)
                    {
                        matrix[n - j - 1, layer] = currNum++;
                    }

                }

            }

            return matrix;

        }

        public void moveZeroesAgainOnceMore(int[] array)
        {
            if (array == null || array.Count() < 2)
                return;

            int offset = 0;

            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] == 0)
                {
                    offset++;
                }
                else
                {
                    if (offset != 0)
                    {
                        array[i - offset] = array[i];
                    }
                }
            }

            for (int i = array.Count() - offset; i < array.Count(); i++)
            {
                array[i] = 0;
            }

        }

        public List<string> permuteString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            List<string> permutations = new List<string>();
            permuteStringInner(new List<char>(s.ToCharArray()), permutations, string.Empty);
            return permutations;
        }

        private void permuteStringInner(List<char> chars, List<string> permutations, string currString)
        {
            if (chars.Count() == 0)
            {
                permutations.Add(currString);
                return;
            }

            for (int i = 0; i < chars.Count(); i++)
            {
                List<char> charsCopy = new List<char>(chars);
                charsCopy.RemoveAt(i);
                char ch = chars[i];

                permuteStringInner(charsCopy, permutations, currString + ch);
            }

        }

        public int evaluateExpresion(string exp)
        {
            if (string.IsNullOrEmpty(exp))
                return -1; //exception!?

            Stack<int> operands = new Stack<int>();
            Stack<char> operators = new Stack<char>();

            foreach (char ch in exp)
            {
                if (isDigit(ch))
                {
                    operands.Push(ch - '0');
                }
                else
                {
                    while ((operators.Count() > 0) && (getOperatorPrecedence(operators.Peek()) > getOperatorPrecedence(ch)))
                    {
                        int b = operands.Pop();
                        int a = operands.Pop();
                        char op = operators.Pop();
                        int val = evaluate(a, b, op);
                        operands.Push(val);
                    }
                    operators.Push(ch);

                }

            }

            while (operators.Count() != 0)
            {
                int b = operands.Pop();
                int a = operands.Pop();
                char op = operators.Pop();
                int val = evaluate(a, b, op);
                operands.Push(val);
            }

            return operands.Pop();

        }

        private bool isDigit(char ch)
        {
            return (((ch - '0') >= 0) && ((ch - '0') <= 9));
        }

        private int getOperatorPrecedence(char op)
        {
            switch (op)
            {
                case '/': return 8;
                case '*': return 6;
                case '+': return 4;
                case '-': return 2;
                default: break;
            }

            return -1;
        }

        private int evaluate(int a, int b, char op)
        {
            switch (op)
            {
                case '/': return (int)(a / b);
                case '*': return a * b;
                case '+': return a + b;
                case '-': return a - b;
                default: break;
            }

            return -1; // exception!?
        }

         /*
         * Given a string, we can “shift” each of its letter to its successive letter, for example: “abc” -> “bcd”. We can keep “shifting” which forms the sequence:
         * "abc" -> "bcd" -> ... -> "xyz" Given a list of strings which contains only lowercase alphabets, group all strings that belong to the same shifting sequence.
         * For example,
         * given: ["abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"], 
         * Return:
         * [ ["abc","bcd","xyz"], ["az","ba"], ["acef"], ["a","z"] ]
         */


        public List<List<string>> groupShiftedStrings(List<string> strings)
        {
            if (strings == null || strings.Count() == 0)
                return null;

            Dictionary<string, List<string>> hashStringMap = new Dictionary<string, List<string>>();

            foreach (string s in strings)
            {
                string hash = stringHash(s);
                //string hash = getHashedString(s);
                if (!hashStringMap.ContainsKey(hash))
                    hashStringMap.Add(hash, new List<string>());

                hashStringMap[hash].Add(s);
            }

            List<List<string>> matchingStrings = new List<List<string>>();

            foreach (var kvp in hashStringMap)
            {
                matchingStrings.Add(kvp.Value);
            }

            return matchingStrings;
        }

        private string stringHash(string s)
        {
            int offset = s[0] - 'a';
            char[] hashedString = new char[s.Length];

            int i = 0;
            foreach (char ch in s)
            {
                int x = ch - offset;
                if (x < 'a')
                {
                    x = 'z' - (x - 'a' + 1);
                }
                hashedString[i++] = (char)(x);
            }

            return new string(hashedString);
        }

        private string getHashedString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            StringBuilder sb = new StringBuilder();
            int offset = s[0] - 'a';
            sb.Append('a');
            for (int i = 1; i < s.Length; i++)
            {
                sb.Append((char)('a' + (s[i] - offset + 26) % 26));
            }

            return sb.ToString();
        }

        public bool isSudokuValid(int[,] board)
        {
            if (board == null)
                return false;

            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            int target = getFactorial(rows);
            if (target == -1)
                return false;

            int[] rowsCheck = new int[rows];
            int[] colsCheck = new int[cols];
            int[] minBoxCheck = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                rowsCheck[i] = 1;
                colsCheck[i] = 1;
                minBoxCheck[i] = 1;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] < 0 || board[i, j] > rows)
                        return false;
                    rowsCheck[i] *= board[i, j];
                    colsCheck[j] *= board[i, j];

                    int val = (((int) (i/3))*3) + (j/3);
                    minBoxCheck[val] *= board[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (rowsCheck[i] != target || colsCheck[i] != target || minBoxCheck[i] != target)
                    return false;
            }

            return true;
        }

        private int getFactorial(int n)
        {
            if (n < 0 || n > 9)
                return -1;

            int prod = 1;
            for (int i = 2; i <= n; i++)
            {
                prod *= i;
            }

            return prod;
        }


        public bool isPatternMatchNew(string pattern, string text)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(text) || pattern.Length == 0 || text.Length == 0)
                return false;

            int nA, nB;
            if (pattern[0] == 'b')
                pattern = swapChars(pattern);

            nA = countChars(pattern, 'a');
            nB = pattern.Length - nA;

            if (nB == 0)
            {
                if (text.Length % nA == 0)
                {
                    int lenA = text.Length / nA;
                    return evaluatePattern(pattern, text, lenA, 0);
                }
            }

            int maxA = text.Length / nA;

            for (int i = 0; i <= maxA; i++)
            {
                if ((text.Length - (nA * i)) % nB == 0)
                {
                    int lenB = (text.Length - (nA * i)) / nB;
                    if (evaluatePattern(pattern, text, i, lenB))
                        return true;
                }

            }

            return false;
        }

        private string swapChars(string s)
        {
            char[] swappedText = s.ToCharArray();
            for (int i = 0; i < swappedText.Length; i++)
            {
                if (swappedText[i] == 'a')
                    swappedText[i] = 'b';
                else
                    swappedText[i] = 'a';
            }

            return new string(swappedText);
        }

        private int countChars(string s, char c)
        {
            int count = 0;
            foreach (char ch in s)
            {
                if (ch == c)
                    count++;
            }
            return count;
        }

        private bool evaluatePattern(string pattern, string text, int lenA, int lenB)
        {
            string a = string.Empty;
            string b = string.Empty;

            int ctr = 0;
            foreach (char c in pattern)
            {
                if (c == 'a')
                {
                    string cand = text.Substring(ctr, lenA);
                    if (a == string.Empty)
                        a = cand;
                    else if (cand != a)
                        return false;
                    ctr += a.Length;
                }
                else
                {
                    string cand = text.Substring(ctr, lenB);
                    if (b == string.Empty)
                        b = cand;
                    else if (cand != b)
                        return false;
                    ctr += b.Length;
                }
            }

            return true;
        }

        public bool subsetSum(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return false;

            bool[,] memo = new bool[nums.Length, target + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < target + 1; j++)
                {
                    if (j == 0)
                        memo[i, j] = true;
                    else
                    {
                        if (j < nums[i])
                        {
                            if (i == 0)
                                memo[i, j] = false;
                            else
                                memo[i, j] = memo[i - 1, j];
                        }
                        else
                        {
                            if (i == 0)
                                memo[i, j] = (nums[i] == j);
                            else
                                memo[i, j] = (memo[i - 1, j] || memo[i - 1, j - nums[i]]);
                        }

                    }
                }
            }

            return memo[nums.Length - 1, target];
        }


        public class KnapSack
        {
            public int weight;
            public int value;
            public KnapSack(int w, int v)
            {
                weight = w;
                value = v;
            }
        }

        public int knapSackProblem(List<KnapSack> knapsacks, int weightLimit)
        {
            if (knapsacks == null || knapsacks.Count() < 1)
                return 0;

            int[,] memo = new int[knapsacks.Count(), weightLimit + 1];

            for (int i = 0; i < knapsacks.Count(); i++)
            {
                for (int j = 0; j < weightLimit + 1; j++)
                {
                    if (j == 0)
                        memo[i, j] = 0;
                    else
                    {
                        if (knapsacks[i].weight <= j)
                        {
                            if(i == 0)
                                memo[i, j] = knapsacks[i].value;
                            else
                                memo[i, j] = Math.Max(knapsacks[i].value + memo[i - 1, j - knapsacks[i].weight], memo[i - 1, j]);
                        }
                        else
                        {
                            if (i == 0)
                                memo[i, j] = 0;
                            else
                                memo[i, j] = memo[i - 1, j];
                        }
                    }
                }
            }

            return memo[knapsacks.Count() - 1, weightLimit];

        }


        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int num = 0;
            int start = 0;
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int mask = 1 << (int) (c - 'a');
                bool isRep = ((num & mask) == 1) ? true : false;
                if (isRep)
                {
                    int len = i - start;
                    maxLen = len > maxLen ? len : maxLen;
                    start = i;
                    num = 0;
                }
                else
                {
                    num = num | (1 << (c - 'a'));
                }

            }

            return maxLen;
        }


        public bool isInterleave(string s, string t, string w)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || string.IsNullOrEmpty(w) || (s.Length + t.Length != w.Length))
                return false;

            bool[,] memo = new bool[s.Length + 1, t.Length + 1];

            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < t.Length + 1; j++)
                {
                    if (i == 0 && j == 0)
                        memo[i, j] = true;
                    else if (i == 0)
                    {
                        if (w[j - 1] == t[j - 1] && memo[i, j - 1] == true)
                            memo[i, j] = true;
                        else
                            memo[i, j] = false;
                    }
                    else if (j == 0)
                    {
                        if (w[i - 1] == s[i - 1] && memo[i - 1, j] == true)
                            memo[i, j] = true;
                        else
                            memo[i, j] = false;
                    }
                    else
                    {
                        if ((w[i + j - 1] == t[j - 1] && memo[i, j - 1] == true) || (w[i + j - 1] == s[i - 1] && memo[i - 1, j] == true))
                            memo[i, j] = true;
                        else
                            memo[i, j] = false;
                    }

                }
            }

            //for (int i = 0; i < s.Length + 1; i++)
            //{
            //    for (int j = 0; j < t.Length + 1; j++)
            //    {
            //        Console.Write(memo[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            return memo[s.Length, t.Length];
        }


        public void moveZeroesTest(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int offset = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    offset++;
                }
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

        public int numJumps(int[] A)
        {
            int max = 0;
            int numJumpsMade = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (max >= A.Length - 1)
                {
                    return numJumpsMade + 1;
                }
                if (i > max)
                {
                    return -1;
                }
                if (A[i] + i > max)
                {
                    numJumpsMade++;
                    max = A[i] + i;
                }
                Console.WriteLine("{0} {1} {2}", i, max, numJumpsMade);
            }
            return numJumpsMade;
        }

        public int minJumps1(int[] jumps)
        {
            if (jumps == null || jumps.Length < 1)
                return Int32.MaxValue;

            int[] memo = new int[jumps.Length];
            memo[memo.Count() - 1] = 0;

            for (int i = jumps.Length - 2; i >= 0; i--)
            {
                if (jumps[i] <= 0)
                    memo[i] = Int32.MaxValue;
                else if (jumps[i] + i >= jumps.Length - 1)
                    memo[i] = 1;
                else
                {
                    int min = Int32.MaxValue;
                    for (int j = 1; j <= jumps[i]; j++)
                    {
                        min = Math.Min(min, memo[i + j]);
                    }

                    memo[i] = (min == Int32.MaxValue) ? Int32.MaxValue : min + 1;
                }
            }

            return memo[0];
        }

        public int minJumpsTest(int[] array)
        {
            if (array == null || array.Length < 2)
                return 0;

            int[] jumps = new int[array.Length];
            jumps[jumps.Length - 1] = 0;

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] <= 0)
                    jumps[i] = Int32.MaxValue;
                else if (i + array[i] >= array.Length)
                    jumps[i] = 1;
                else
                {
                    int min = Int32.MaxValue;
                    for (int j = 1; j <= array[i]; j++)
                    {
                        if (jumps[i + j] < min)
                            min = jumps[i + j];
                    }
                    if (min != Int32.MaxValue)
                        jumps[i] = min + 1;
                    else
                        jumps[i] = Int32.MaxValue;
                }
            }

            foreach (int n in jumps)
            {
                Console.Write(n+ " ");
            }

            return jumps[0];
        }

        public string reverseStringNew(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            int start = 0;
            int end = 0;

            char[] chars = s.Reverse().ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    if (start != end)
                    {
                        reverseChars(chars, start, i - 1);
                        start = i + 1;
                        end = i + 1;
                    }
                }
                else
                {
                    end++;
                }
            }

            if (start != end)
                reverseChars(chars, start, end - 1);

            return new string(chars);
        }

        private void reverseChars(char[] chars, int start, int end)
        {
            if (start < end)
            {
                for (int i = start; i <= (start + end) / 2; i++)
                {
                    char c = chars[i];
                    chars[i] = chars[end - i + start];
                    chars[end - i + start] = c;
                }
            }
        }

        public string longestCommonSubstring(string s, string t)
        {
            if (s == null || t == null)
                return string.Empty;

            int[,] memo = new int[s.Length + 1, t.Length + 1];
            int maxLen = 0;
            int endIndex = 0;
            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < t.Length + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        memo[i, j] = 0;
                    }
                    else
                    {
                        int val = 0;
                        if (s[i - 1] == t[j - 1])
                        {
                            val = memo[i - 1, j - 1] + 1;
                        }
                        memo[i, j] = val;
                        if (val > maxLen)
                        {
                            maxLen = val;
                            endIndex = i;
                        }
                    }
                }
            }

            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < t.Length + 1; j++)
                {
                    Console.Write(memo[i,j] + " ");
                }
                Console.WriteLine();
            }

            if (maxLen == 0)
                return string.Empty;
            return s.Substring(endIndex - maxLen + 1 , maxLen - 1);
        }

        private string longestPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            bool[,] memo = new bool[word.Length, word.Length];

            int maxLen = 1;
            int endIndex = 0;

            // main diagonal
            for (int i = 0; i < word.Length; i++)
            {
                memo[i, i] = true;
            }

            // one off main diagonal
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                    memo[i - 1, i] = true;
                else
                    memo[i - 1, i] = false;
            }

            for (int offset = 2; offset < word.Length; offset++)
            {
                for (int i = 0; i < word.Length - offset; i++)
                {
                    int row = i;
                    int col = i + offset;
                    if (word[row] == word[col])
                    {
                        if (memo[row + 1, col - 1] == true)
                        {
                            memo[row, col] = true;
                            if (maxLen < col - row)
                            {
                                maxLen = col - row;
                                endIndex = col;
                            }
                        }
                        else
                        {
                            memo[row, col] = false;
                        }
                    }
                    else
                    {
                        memo[row, col] = false;
                    }
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(memo[i,j] + "\t");
                }
                Console.WriteLine();
            }

            return word.Substring(endIndex - maxLen, maxLen);

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

            //foreach (int q in jumps)
            //{
            //    Console.Write(q + " ");
            //}

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

    public class LRUCache
    {
        public int capacity;
        private int numNodes;
        private LinkedList<LRUCacheNode> nodeList;
        private Dictionary<int, LRUCacheNode> nodeMap;

        public LRUCache(int cap)
        {
            this.capacity = cap;
            numNodes = 0;
            nodeList = new LinkedList<LRUCacheNode>();
            nodeMap = new Dictionary<int, LRUCacheNode>();
        }

        public LRUCacheNode GetLRUItem()
        {
            LRUCacheNode node = null;
            if (numNodes > 0)
                node = nodeList.First.Value;

            return node;
        }

        public int Get(int key)
        {
            if (nodeMap.ContainsKey(key))
            {
                LRUCacheNode node = nodeMap[key];
                nodeList.Remove(node);
                nodeList.AddFirst(node);

                return node.value;
            }
            else
                return -1; //exception!?
        }

        public void Set(int key, int value)
        {
            this.Set(new LRUCacheNode(key, value));
        }

        public void Set(LRUCacheNode node)
        {
            if (nodeMap.ContainsKey(node.key))
            {
                LRUCacheNode node1 = nodeMap[node.key];
                node1.value = node.value;
                nodeList.Remove(node1);
                nodeList.AddFirst(node1);
            }
            else
            {
                if (numNodes >= this.capacity)
                {
                    LRUCacheNode lastNode = nodeList.Last.Value;
                    nodeList.Remove(lastNode);
                    nodeMap.Remove(lastNode.key);
                    numNodes--;
                }
                nodeList.AddFirst(node);
                nodeMap.Add(node.key, node);
                numNodes++;
            }
        }

        public void Remove(int key)
        {
            if (nodeMap.ContainsKey(key))
            {
                LRUCacheNode node = nodeMap[key];
                nodeList.Remove(node);
                nodeMap.Remove(key);
                numNodes--;
            }
        }

    }

    public class LRUCacheNode
    {
        public int key;
        public int value;

        public LRUCacheNode(int k, int v)
        {
            this.key = k;
            this.value = v;
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
