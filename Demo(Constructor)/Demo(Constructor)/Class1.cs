using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructor_
{
    class PublicConstructor
    {
        PublicConstructor()
        {
            Console.WriteLine("Constructor is called");
        }
        static void Main()
        {
            PublicConstructor instance= new PublicConstructor();
            PublicConstructor instance2= new PublicConstructor();
            PublicConstructor instance3= new PublicConstructor();


        }
    }
}
