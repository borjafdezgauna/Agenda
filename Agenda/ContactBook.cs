using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLib
{
    public class ContactBook
    {
        private List<Contact> Contacts = new List<Contact>();

        public ContactBook()
        {
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            //TODO 1
            //You can use: List.Remove()
        }

        public Contact GetIthContact(int i)
        {
            //TODO 1
            return null;
        }

        public int NumContacts()
        {
            //TODO 1
            //You can use: List.Count
            return 0;
        }

        public Contact ContactByName(string name)
        {
            //TODO 1
            //You can use: List.Find() or for/if
            //Example:
            //List<string> names;
            //string foundName = names.Find(n => n.Contains(name))
            return null;
        }

        public Contact ContactByEmail(string email)
        {
            //TODO 1
            //You can use: List.Find() or for/if
            return null;
        }

        public List<Contact> ContactsBySubstring(string substring)
        {
            //TODO 1
            //You can use: List.Find() or for/if, and string.Contains()
            return null;
        }

        public bool Save(string filename)
        {
            //TODO 2: Save to a file all the contacts in any format you want
            //If everything goes ok, return true, false otherwise
            //You can write to a file as in the example:
            //System.IO.File.TextWriter writer = System.IO.File.CreateText(filename);
            //writer.WriteLine("...");
            //writer.Close();

            return false;
        }

        public static ContactBook Load(string filename)
        {
            //TODO 2: Load a previously saved contact book from the file
            //If everything goes ok, return a new instance of ContactBook, null otherwise
            //You can read all the lines from a file one by one as in the example:
            //System.IO.File.TextReader reader = System.IO.File.OpenText(filename);
            //string line = reader.ReadLine();
            //while (line != null)
            //{
            //  writer.WriteLine("...");
            //  line = reader.ReadLine();
            //}
            
            return null;
        }
    }
}
