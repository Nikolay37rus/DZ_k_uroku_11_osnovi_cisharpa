using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разработать_ковариантный_и_контравариантный_делегат
{
    class Person
    {
        public string Name { get; set; }
        public virtual void Display() => Console.WriteLine($"Person {Name}");
    }
    class Client : Person
    {
        public override void Display() => Console.WriteLine($"Client {Name}");
    }
}
