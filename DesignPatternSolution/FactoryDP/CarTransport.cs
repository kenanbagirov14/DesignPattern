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

    public class SeaTransport : ITransport
    {
        public void TransportName()
        {
            Console.WriteLine("sea transport");
        }

        public void TransportNumber()
        {
            Console.WriteLine("WW455");
        }
    }

    public class TransportFactory : ITransportFactory
    {
        public ITransport Create(TransportTypes transportType)
        {
            ITransport transport = transportType switch
            {
                TransportTypes.CarTransport =>  new CarTransport(),
                TransportTypes.SeaTransport => new SeaTransport(),
                _ =>throw new NullReferenceException(),
            };

            return transport;
        }
    }
}
