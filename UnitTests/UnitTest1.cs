using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgendaLib;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadAndSaveAgenda()
        {
            Contact contact1 = new Contact("Ronald Reagan", "ronald@gmail.com", "12341234");
            Contact contact2 = new Contact("Donald Trump", "trump-tonto@gmail.com", "78907890");
            Agenda agenda = new Agenda();
            agenda.Save("myagenda.txt");

            Agenda loadedAgenda = Agenda.Load("myagenda.txt");

            Assert.AreEqual(agenda.NumContacts(), loadedAgenda.NumContacts());
        }

        [TestMethod]
        public void LoadEmptyAgenda()
        {
            Agenda loadedAgenda = Agenda.Load("new-file.txt");

            Assert.AreEqual(0, loadedAgenda.NumContacts());            
        }
    }
}
