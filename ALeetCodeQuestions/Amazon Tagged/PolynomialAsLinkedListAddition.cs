using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.ca/2020-05-21-1634-Add-Two-Polynomials-Represented-as-Linked-Lists/
/// </summary>
namespace ALQ.Amazon_Tagged
{
    /// <summary>
    /// The idea is simple we need to parse through two lists and add them if suitable.
   /// At the end check for any leftover nodes and append them
    /// </summary>
    class PolynomialAsLinkedListAddition
    {
        public PolyNode AddTwoPolyNodes(PolyNode p1, PolyNode p2)
        {
            if (p1 == null && p2 == null)
            {
                return null;
            }
            else if (p1 == null && p2 != null)
            {
                return p2;
            }
            else if (p1 != null && p2 == null)
            {
                return p1;
            }
            var head1 = p1;
            var head2 = p2;
            PolyNode result = null;
            PolyNode temp = result;
            while (head1 != null && head2 != null)
            {
                if (head1.Power == head2.Power)
                {
                    if (head1.Coefficient + head2.Coefficient !=0)
                    {
                        if(result==null)
                        {
                            result = new PolyNode();
                            temp = result;
                        }
                        temp.Coefficient = head1.Coefficient + head2.Coefficient;
                        temp.Power = head1.Power;
                        head1 = head1.Next;
                        head2 = head2.Next;
                    }
                    else
                    {
                        head1 = head1.Next;
                        head2 = head2.Next;
                        continue;
                    }
                    
                    
                }
                else if (head1.Power > head2.Power)
                {
                    if (result == null)
                    {
                        result = new PolyNode();
                        temp = result;
                    }
                    temp.Coefficient = head1.Coefficient;
                    temp.Power = head1.Power;
                    head1 = head1.Next;
                }
                else if (head2.Power > head1.Power)
                {
                    if (result == null)
                    {
                        result = new PolyNode();
                        temp = result;
                    }
                    temp.Coefficient = head2.Coefficient;
                    temp.Power = head2.Power;
                    head2 = head2.Next;
                }
                if (head1 != null || head2 != null)
                {
                    temp.Next = new PolyNode();
                    temp = temp.Next;
                }
            }
            if (head1 != null)
            {
                do
                {
                    if (result == null)
                    {
                        result = new PolyNode();
                        temp = result;
                    }
                    temp.Coefficient = head1.Coefficient;
                    temp.Power = head1.Power;
                    
                    head1 = head1.Next;
                    if(head1!=null)
                    {
                        temp.Next = new PolyNode();
                        temp = temp.Next;
                    }
                } while (head1 != null);
            }
            if (head2 != null)
            {
                do
                {
                    if (result == null)
                    {
                        result = new PolyNode();
                        temp = result;
                    }
                    temp.Coefficient = head2.Coefficient;
                    temp.Power = head2.Power;
                   
                    head2 = head2.Next;
                    if(head2!=null)
                    {
                        temp.Next = new PolyNode();
                        temp = temp.Next;
                    }
                } while (head2!= null);
            }
            return result;
        }
    }

}
