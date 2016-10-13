using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
namespace codilityTest.Lib
{
    public class common
    {
        //write a method that can find all numbers from 0-100 divisiable 3,7,and 9
        ///and write them to console without repeating any nos.
        ///ie. 27 is divisable by 9 and 3, donot print 27 twice
        ///

        public List<int> getDivs(int min,int max,int divby) {
            List<int> numList = new List<int>();

            numList = Enumerable.Range(min, max).Where(item => ( item % divby == 0)).ToList();
            
            return numList;
        }


    
    }
}
