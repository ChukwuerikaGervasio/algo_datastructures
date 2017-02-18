using System;

namespace Recursion
{
    public static class Recursion
    {
        public static void powerSet(int[] set, int start, out int[][] result)
        {
            if (set.Length == 0)
            {
                result = new int[][] {new int[] {}};
            }
            else if (set.Length == 1)
            {
                result = new int[][] {set};
            }
            //int setSize = set.Length;
            // int[][] combined = new int[setSize + setSize - 1][];
            // Array.Copy(new int[][] {set}, combined, setSize);
            // return Array.Copy(powerSet(set), 0, combined, setSize, setSize - 1);
            // int[][] res = new int[][] {set};
            else
            {
                result = new int[][] {set, set};
            }

        }

        public static int tripleStep(int num)
        {
            if (num < 1)
            {
                return 0;
            }
            int by1 = tripleStep(num - 1);
            int by2 = tripleStep(num - 2);
            int by3 = tripleStep(num - 3);
            return 1 + by1 + by2 + by3;
        }
    }
}