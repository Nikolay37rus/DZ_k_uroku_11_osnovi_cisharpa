using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разработать_ковариантный_и_контравариантный_делегат
{
    class Programs
    {
        delegate void GetInfo<in T>(T item);
        static void Man(string[] args)
        {
            GetInfo<Person> personInfo = PersonInfo;
            GetInfo<Client> clientInfo = personInfo;      // контравариантность

            Client client = new Client { Name = "Tom" };
            clientInfo(client); // Client: Tom

            Console.Read();
        }
        private static void PersonInfo(Person p) => p.Display();
        private static void ClientInfo(Client cl) => cl.Display();
    }
}
