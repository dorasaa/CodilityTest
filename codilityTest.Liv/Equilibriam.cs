using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTest.Lib
{
    public class Equilibriam
    {
        public int IsItEquilibrium(int[] arr)
        {
            if (arr.Length== 0)
            {
                return 0;
            }

            int[] DiffArray= { };
            int i=0;
            int IndexP = 1;
            while (IndexP < arr.Length)
            {
                var sumofleftArrayElements_Left = GetSum(IndexP, arr, "left");
                var sumofleftArrayElements_Right = GetSum(IndexP, arr, "right");
                int diffvalue = Math.Abs(sumofleftArrayElements_Left - sumofleftArrayElements_Right);
                DiffArray[i] = diffvalue;
                i += 1;
                IndexP += 1;
            }
            return DiffArray.Min();


        }

        private int GetSum(int ArrayIndex, int[] arr, string side)
        {
            int  tempsum = 0,i=0;
            if (side == "left")
            {
                if (!(i == 0 && ArrayIndex == 0))
                {
                    for (int item = 0; item < ArrayIndex; item++)
                    {
                        tempsum += arr[item];
                    }

                }

                else
                {
                    tempsum = arr[tempsum];
                }
            }
            return tempsum; 
        } 

        //A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.
        /*A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.

Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].

The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|

In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

For example, consider array A such that:

  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
We can split this tape in four places:

P = 1, difference = |3 − 10| = 7 
P = 2, difference = |4 − 9| = 5 
P = 3, difference = |6 − 7| = 1 
P = 4, difference = |10 − 3| = 7 
Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty zero-indexed array A of N integers, returns the minimal difference that can be achieved.

For example, given:

  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
    }
    *
    */


    }

}
