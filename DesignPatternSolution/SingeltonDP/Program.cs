using SingeltonDP;

Thread t1 = new Thread(t => DBConnection.CreateInstance());
Thread t2 = new Thread(t => DBConnection.CreateInstance());
Thread t3 = new Thread(t => DBConnection.CreateInstance());
Thread t4 = new Thread(t => DBConnection.CreateInstance());
Thread t5 = new Thread(t => DBConnection.CreateInstance());

t1.Start();
t2.Start();
t3.Start();
t4.Start();
t5.Start();

Console.ReadLine();
