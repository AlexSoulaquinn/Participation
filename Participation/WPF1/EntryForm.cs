using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        string name { get; set; }
        string address { get; set; }
        int zipCode { get; set; }

        public EntryForm()
        {
            name = "";
            address = "";
            zipCode = 0;
        }

        public EntryForm(string Name, string Address, int ZipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }

        public override string ToString()
        {
            string phrase = ($"{name} // {address} // {zipCode}");
            return phrase;
        }

    }
}
