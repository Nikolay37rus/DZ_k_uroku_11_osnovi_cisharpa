using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разработать_ковариантный_и_контравариантный_делегат
{
    class Program
    {
        delegate T Builder<out T>(string name);
        static void Main(string[] args)
        {
            Builder<Client> clientBuilder = GetClient;
            Builder<Person> personBuilder1 = clientBuilder;     // ковариантность
            Builder<Person> personBuilder2 = GetClient;         // ковариантность

            Person p = personBuilder1("Tom"); // вызов делегата
            p.Display(); // Client: Tom

            Console.Read();
        }
        private static Person GetPerson(string name)
        {
            return new Person { Name = name };
        }
        private static Client GetClient(string name)
        {
            return new Client { Name = name };
        }
    }
}
