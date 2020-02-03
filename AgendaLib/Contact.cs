using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLib
{
    public class Contact
    {
        public string Name = null;
        public string Email = null;
        public string Telephone = null;

        public Contact(string name, string email, string telephone= null)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
        }
    }
}
