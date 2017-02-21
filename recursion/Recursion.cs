using System.Collections.Generic;

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

        public static List<string> permsWithOutDups(string astr)
        {
            if (astr.Length < 1)
            {
                return new List<string>();
            }
            if (astr.Length == 1)
            {
                return new List<string>{astr};
            }
            var first = astr[0];
            var rest = astr.Substring(1, astr.Length - 1);
            var permsOfrest = permsWithOutDups(rest);
            var combPerms = new List<string>();
            foreach (var perm in permsOfrest)
            {
                for (var i = 0; i < perm.Length + 1; i++)
                {
                    string endString;
                    if (i == perm.Length) {
                        endString = "";
                    }
                    else 
                    {
                        endString = perm.Substring(i, perm.Length - i);
                    }
                    combPerms.Add(perm.Substring(0, i) + first + endString);
                }
            }
            return combPerms;
        }

        public static List<string> permsWithDups(string astr)
        {
            if (astr.Length < 1)
            {
                return new List<string>();
            }
            if (astr.Length == 1)
            {
                return new List<string>{astr};
            }
            var first = astr[0];
            var rest = astr.Substring(1, astr.Length - 1);
            var permsOfrest = permsWithOutDups(rest);
            var combPerms = new HashSet<string>();
            foreach (var perm in permsOfrest)
            {
                for (var i = 0; i < perm.Length + 1; i++)
                {
                    string endString;
                    if (i == perm.Length) {
                        endString = "";
                    }
                    else 
                    {
                        endString = perm.Substring(i, perm.Length - i);
                    }
                    combPerms.Add(perm.Substring(0, i) + first + endString);
                }
            }
            return new List<string>(combPerms);
        }
    }
}