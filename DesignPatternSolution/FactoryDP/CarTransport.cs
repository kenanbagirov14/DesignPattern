using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    public class CarTransport : ITransport
    {
        public void TransportName()
        {
            Console.WriteLine("land transport");
        }

        public void TransportNumber()
        {
            Console.WriteLine("33RR333");
        }
    }
}
