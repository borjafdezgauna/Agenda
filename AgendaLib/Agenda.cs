using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace AgendaLib
{
    public class Agenda
    {
        List<Contact> Contacts = new List<Contact>();

        public Agenda()
        {

        }

        public void Add(Contact contact)
        {
            Contacts.Add(contact);            
        }

        static public Agenda Load(string filename)
        {
            Agenda agenda = new Agenda();

            if (File.Exists(filename))
            {
                foreach (string line in File.ReadAllLines(filename))
                {
                    string[] lineParts= line.Split(',');
                    if (lineParts.Length == 3)
                    {
                        Contact contact = new Contact(lineParts[0], lineParts[1], lineParts[2]);
                        agenda.Add(contact);
                    }
                }
            }
            else Console.WriteLine("Warning: the file doesn't exist");

            return agenda;
        }

        public void Save(string filename)
        {
            StreamWriter writer = File.CreateText(filename);
            foreach(Contact contact in Contacts)
            {
                writer.WriteLine(contact.Name + "," + contact.Email + "," + contact.Telephone);
            }
            writer.Close();
        }
    }
}
