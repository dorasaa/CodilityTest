using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTest.Liv
{
    public class phonebook
    {

        public string name  { get; set; }
        public string number  { get; set; }
        public static List<phonebook> GetPhoneBook()
        {
            List<phonebook> listofcontacts = new List<phonebook>();
            phonebook contract1 = new phonebook { name = "satish", number="07894427829" };
            phonebook contract2 = new phonebook { name = "kavya", number = "07904784411" };
            phonebook contract3 = new phonebook { name = "home", number = "01737768353" };
            listofcontacts.Add(contract1);
            return listofcontacts;
        }

        public void add(string name ,string number ) {
            phonebook contract1 = new phonebook { name = name, number = number };

        }
    }
}
