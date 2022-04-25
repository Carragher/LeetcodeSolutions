using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualBasic;

namespace AddTwoNumbers
{
    class Program
    {

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //save a pointer to the head of the list
            ListNode pointer = new ListNode();
            ListNode head = pointer;

            //set summation and the Carry value so that we can both use them to sum individual portions of the list AND use the carry place once we run out of linked list to make sure we add the final significant digit
            int summation = 0;
            int carryPlace = 0;

            while (l1 != null || l2 != null)
            {
                summation = carryPlace;
                //iterate l1
                if (l1 != null)
                {
                    summation += l1.val;
                    l1 = l1.next;
                }
                //iterate l2
                if (l2 != null)
                {
                    summation += l2.val;
                    l2 = l2.next;
                }
                //set carry to next pass and set accurate digit for this pass
                if (summation >= 10)
                {
                    carryPlace = summation / 10;
                    summation %= 10;
                }
                else
                {
                    //reset carry digit
                    carryPlace = 0;
                }
                //add the result and move the "pointer" to the next bit of the result
                pointer.next = new ListNode(summation);
                pointer = pointer.next;
            }

            if (carryPlace != 0)
            {
                pointer.next = new ListNode(carryPlace);
            }


            return head.next;


        }







    }





   public class ListNode
   {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val; 
            this.next = next;
        }
   }


}
