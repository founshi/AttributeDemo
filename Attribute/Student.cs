using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    public class Student
    {
        public int Id { get; set; }
        [NullEmpty]
        public string Name { get; set; }
    }
}
