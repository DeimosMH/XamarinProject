using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ModalNavigation
{
    public class Contact
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Occupation { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
