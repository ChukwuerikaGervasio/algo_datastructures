using System;

namespace ConsoleApplication
{
    public class ListNode
    {
        public int Value;
        public ListNode Next;

        public bool Contains(int needle)
        {
            if (Value == needle)
            {
                return true;
            }
            else if (Next == null)
            {
                return false;
            }
            return Next.Contains(needle);
        }
    }
}
