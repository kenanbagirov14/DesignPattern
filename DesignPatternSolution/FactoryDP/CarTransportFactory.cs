namespace FactoryDP
{
    public class CarTransportFactory : ITransportFactory
    {
        public ITransport Create()
        {
            ITransport tr = new CarTransport();

            return tr;
        }
    }
}