using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    public interface ITransport
    {
        void TransportName();
        void TransportNumber();
    }

    public interface ITransportFactory
    {
        ITransport Create(TransportTypes transportType);
    }
}
