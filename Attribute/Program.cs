using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student _Student = new Student();
                _Student.Validate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
