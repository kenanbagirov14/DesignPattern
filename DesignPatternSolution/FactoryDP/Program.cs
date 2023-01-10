global using FactoryDP;

var tr = new CarTransportFactory().Create();
var tr2 = new SeaTransportFactory().Create();

tr.TransportName();
tr.TransportNumber();

tr2.TransportName();
tr2.TransportNumber();
Console.ReadLine();
