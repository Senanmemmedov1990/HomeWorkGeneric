using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeneric
{
    public class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int? Age { get; set; }

        public Person()
        {
            _id++;
            Id = _id;

        }
        public void Add()
        {
                                  
        }
        
    }
}
