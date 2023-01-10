namespace FactoryDP
{
    public class SeaTransportFactory : ITransportFactory
    {
      public  ITransport Create()
        {
            ITransport tr = new SeaTransport();
            
            return tr;
        }
    }
}