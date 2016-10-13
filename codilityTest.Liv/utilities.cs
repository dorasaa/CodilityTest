using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTest
{
    public class utilities
    {
        public List<int> MyList { get; set; }
        public string strexception { get; set; }

        public List<int> GetMissingNums(List<int> MyList)
        {
            try {
                List<int> newlist = Enumerable.Range(MyList.Min(), MyList.Max()).ToList();
                List<int> Result = newlist.Except(MyList).ToList();
                return Result;
            }
            catch (Exception ex)
            {
                return null;
                strexception = ex.Message;
            }
        }
        
         
        
    }
}
