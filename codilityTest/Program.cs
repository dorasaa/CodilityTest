using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace codilityTest
{
    class Program
    {
        private static bool stopArraySlicing = false;

        static void Main(string[] args)
        {
            List<int> resultUniqueArray = new List<int>() { };
            List<int> Result = GetSlicedArray(out resultUniqueArray);
             
            foreach (int item in Result)
            {
                Console.Write(item + ",");

            }
            Console.WriteLine("Unique values");
            foreach (int item in resultUniqueArray)
            {
                Console.Write(item + ",");

            } 
        }

        static List<int> GetSlicedArray(out List<int> resultUniqueArray)
        {
            List<int> arr = new List<int>() { 1, 1, 1, 2, 2, 2, 2, 1, 1, 2, 2, 6, 2, 1, 8 };
            List<int> SlicedArray = new List<int>() { };
            resultUniqueArray = new List<int>() { };


            foreach (int item in arr)
            {

                if (!resultUniqueArray.Contains(item))
                {
                    //If unique count is 2
                    if (resultUniqueArray.Count < 2)
                    {
                        SlicedArray.Add(item);
                        resultUniqueArray.Add(item);
                    }
                    else
                    {
                        return SlicedArray;
                    }
                }
                else {

                    SlicedArray.Add(item);
                }
            }
            return SlicedArray;
            
        }        
    }
    

    public static class Extensions
    {
        /// <summary>
        /// Get the array slice between the two indexes.
        /// ... Inclusive for start index, exclusive for end index.
        /// </summary>
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            // Handles negative ends.
            if (end < 0)
            {
                end = source.Length + end;
            }
            int len = end - start;

            // Return new array.
            T[] res = new T[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }
    }


    //int[] a = new int[] {1, 2, 3, 4, 5, 6, 7};
    //foreach (int i in a.Slice(0, 1))
    //{
    //    Console.WriteLine(i);
    //}
    //Console.WriteLine();
    //foreach (int i in a.Slice(0, 2))
    //{
    //    Console.WriteLine(i);
    //}
    //Console.WriteLine();
    //foreach (int i in a.Slice(2, 5))
    //{
    //    Console.WriteLine(i);
    //}
    //Console.WriteLine();
    //foreach (int i in a.Slice(2, -3))
    //{
    //    Console.WriteLine(i);
    //}
    //var newstring = new StringBuilder();

    //string s1= "tatish";
    //string s2 = "satish";
    //Console.WriteLine(string.Compare(s1,0,s2,0,1));
    //string s = "abc";
    //Console.WriteLine(s[0]);
    //List<int> Digits = new List<int>();
    //int num = 83792;
    //if (num > 0)
    //{
    //    int rem = 0;
    //    int digit = 0;
    //    while (num > 0)
    //    {
    //        digit = num % 10;
    //        rem = (int)num / 10;
    //        num = rem;
    //        Digits.Add(digit);
    //    }

    //}

    //Digits.Reverse();
    //int finalResult;
    //foreach (var item in Digits)
    //{
    //    finalResult = item*10;
    //}

    //Console.WriteLine(finalResult);

    //List<int> MyList = new List<int>();
    //List<int> ShortList = new List<int>();
    //MyList = Enumerable.Range(1, 5).ToList();
    //ShortList = MyList.Where(item => (item % 3 == 0 || item % 5 == 0)).ToList();
    //var ss= ShortList.Sum(num => num);

    //utilities ut = new utilities();
    //List<int> MyList = new List<int>(){ 9, 2, 4, 6 };
    //Console.WriteLine(MyList);


    //  IList<int> listnos = new List<int>();
    //  IList<int> listnos1 = new List<int>();
    //  IList<int> oddnos = new Lists<int>() { 1,3,7,9};
    //  List<int> broaderval = new List<int>();
    //  List<int> FinalList = new List<int>();

    //  //List numbers using range
    //  listnos = Enumerable.Range(1, 10).ToList();
    //  listnos1 = Enumerable.Range(1, 10).ToList();

    // //List1.Range(list2).Except is used find difference list1-list2
    // //List.Intersect(list) - to find common values between list 1 and list2

    //  broaderval.AddRange(listnos);
    //  broaderval.AddRange(listnos1);
    //  FinalList = broaderval.Except(oddnos).ToList();
    //  //foreach (var item in broaderval) {

    //  //    Console.WriteLine(item);
    //  //}

    //  IList<int> firstlist = new List<int>() { 1, 3, 5, 7, 9, 8 };
    //  IList<int> secondlist = new List<int>() {  3,  9 };


    //  //3 group 



    //  //Find common elements
    ////  IEnumerable<int> commonElements =
    //      List<int> commonElements = firstlist.Intersect(secondlist).ToList();
    //  foreach (var item1 in commonElements)
    //  {

    //      Console.WriteLine(item1);
    //  }


    //  List<int> nos3 = new List<int>();
    //  List<int> nos7 = new List<int>();
    //  List<int> nos9 = new List<int>();

    //  Lib.common cmn = new Lib.common();
    //  nos3 = cmn.getDivs(0, 100, 3);
    //  nos7 = cmn.getDivs(0, 100, 7);
    //  nos9 = cmn.getDivs(0, 100, 9);
    //  Console.WriteLine("Divisible by 3 only");
    //  DisplayElements(nos3);

    //  Console.WriteLine("Divisible by 3 and 7");
    //  List<int> nos3And7 = nos3.Intersect(nos7).ToList();
    //  DisplayElements(nos3And7); 

    //  Console.WriteLine("Divisible by 7 only");
    //  DisplayElements(nos7);

    //  Console.WriteLine("Divisible by 3 and 9");

    //  List<int> nos3And9 = nos3.Intersect(nos9).ToList();
    //  DisplayElements(nos3And9);

    //  Console.WriteLine("Divisible by 9 only");
    //  DisplayElements(nos9);

    //  Console.WriteLine("Divisible by 7 & 9 only");
    //  List<int>  nos7And9 = nos7.Intersect(nos9).ToList();
    //  DisplayElements((List<int>)nos7And9);


    //  Console.WriteLine("Divisible by 9 only");
    //  DisplayElements(nos9);




    //static void DisplayElements(List<int> nums)
    //{
    //    foreach (var item in nums)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

}