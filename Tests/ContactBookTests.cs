using Xunit;
using AgendaLib;
using NuGet.Frameworks;

namespace Tests
{
    public class ContactBookTests
    {
        [Fact]
        public void RemoveContactAndNumContacts()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("María", "Prado kalea 13, 2.B", "Vitoria-Gasteiz", "maria@ehu.eus"));
            Assert.Equal(1, contactBook.NumContacts());
            contactBook.AddContact(new Contact("Jacinto", "Independencia 2, 6.A", "Vitoria-Gasteiz", "jacinto@ehu.eus"));
            Assert.Equal(2, contactBook.NumContacts());
        }

        [Fact]
        public void ContactByName()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("María", "Prado kalea 13, 2.B", "Vitoria-Gasteiz", "maria@ehu.eus"));
            contactBook.AddContact(new Contact("Jacinto", "Independencia 2, 6.A", "Vitoria-Gasteiz", "jacinto@ehu.eus"));

            Assert.NotNull(contactBook.ContactByName("María"));
            Assert.Null(contactBook.ContactByName("Ramona"));
            Assert.NotNull(contactBook.ContactByName("Jacinto"));
            Assert.Null(contactBook.ContactByName("Maria"));
        }

        [Fact]
        public void ContactByEmail()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("María", "Prado kalea 13, 2.B", "Vitoria-Gasteiz", "maria@ehu.eus"));
            contactBook.AddContact(new Contact("Jacinto", "Independencia 2, 6.A", "Vitoria-Gasteiz", "jacinto@ehu.eus"));

            Assert.NotNull(contactBook.ContactByName("maria@ehu.eus"));
            Assert.Null(contactBook.ContactByName("roman@google.es"));
            Assert.NotNull(contactBook.ContactByName("jacinto@ehu.eus"));
            Assert.Null(contactBook.ContactByName("pepito@hotmail.com"));
        }

        [Fact]
        public void ContactsBySubstring()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("María", "Prado kalea 13, 2.B", "Vitoria-Gasteiz", "maria@ehu.eus"));
            contactBook.AddContact(new Contact("Jacinto", "Independencia 2, 6.A", "Vitoria-Gasteiz", "jacinto@ehu.eus"));

            List<Contact> contacts = contactBook.ContactsBySubstring("cinto");
            Assert.Single(contacts);
            contacts = contactBook.ContactsBySubstring("maria");
            Assert.Single(contacts);
            contacts = contactBook.ContactsBySubstring("Gasteiz");
            Assert.Equal(2, contacts.Count);
        }

        [Fact]
        public void LoadAndSave()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("María", "Prado kalea 13, 2.B", "Vitoria-Gasteiz", "maria@ehu.eus"));
            contactBook.AddContact(new Contact("Jacinto", "Independencia 2, 6.A", "Vitoria-Gasteiz", "jacinto@ehu.eus"));

            Assert.True(contactBook.Save("test-file.txt"));

            ContactBook loaded = ContactBook.Load("test-file.txt");
            Assert.NotNull(loaded);

            for (int i= 0; i< contactBook.NumContacts(); i++)
            {
                Assert.Equal(contactBook.GetIthContact(i).Name, loaded.GetIthContact(i).Name);
                Assert.Equal(contactBook.GetIthContact(i).Address, loaded.GetIthContact(i).Address);
                Assert.Equal(contactBook.GetIthContact(i).City, loaded.GetIthContact(i).City);
                Assert.Equal(contactBook.GetIthContact(i).Email, loaded.GetIthContact(i).Email);
            }
        }
    }
}