using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaLib;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda myAgenda= Agenda.Load("myagenda.txt");

            myAgenda.Save("myagenda-2.txt");

            Console.ReadKey();
        }
    }
}
