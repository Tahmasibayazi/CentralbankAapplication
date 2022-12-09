using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bank
    {
        public int ID { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
