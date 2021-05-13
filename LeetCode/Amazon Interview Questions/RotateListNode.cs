using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class RotateListNode
    {
        Dictionary<int, int> mappings = new Dictionary<int, int>();
        Dictionary<int, int> valueStore = new Dictionary<int, int>();
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            if (k == 0)
            {
                return head;
            }
            ListNode result = new ListNode();
            var tempresult = result;
            int counter = CountOfElements(head);
            CalculateNewMappings(counter, k);
            if (mappings.Count == 0)
            {
                return head;
            }
            else
            {

                StoreValuesInMappings(head);
                for (int i = 0; i < valueStore.Count; i++)
                {
                    tempresult.val = valueStore[i];
                    if (i + 1 != counter)
                    {
                        tempresult.next = new ListNode();
                        tempresult = tempresult.next;
                    }

                }

            }

            return result;
        }
        private void StoreValuesInMappings(ListNode head)
        {
            int counter = 0;
            while(head!=null)
            {
                valueStore.Add(mappings.FirstOrDefault(x => x.Value == counter).Key, head.val);
                head = head.next;
                counter++;
            }
        }
        private int CountOfElements(ListNode head)
        {
            var temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        private int CalculateNewMappings(int count, int k)
        {
            if (k > count)
            {
                k %= count;
            }
            if (k == 0)
            {
                return 0;
            }
            for (int i = 0; i < count; i++)
            {
                if (i + k < count)
                {
                    mappings.Add(i+k, i);
                }
                else
                {
                    mappings.Add(Math.Abs(count - (i + k)),i);
                }
            }
            mappings = mappings.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            return k;
        }
    }
}
