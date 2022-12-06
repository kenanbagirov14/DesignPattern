using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDP
{
    #region method base
    public class DBConnection
    {

        private static DBConnection Instance ;

        private static object obj;
        public static DBConnection CreateInstance()
        {
            Console.WriteLine("Out lock=>" + Thread.CurrentThread.ManagedThreadId);
            lock (obj)
            {
                Console.WriteLine("In Lock=>" + Thread.CurrentThread.ManagedThreadId);
                if (Instance is null)
                {
                    Console.WriteLine("In if=>" + Thread.CurrentThread.ManagedThreadId);
                    Instance = new DBConnection();
                    Console.WriteLine("Created Inctance =>" + Thread.CurrentThread.ManagedThreadId);
                }
            }

            Console.WriteLine("return Inctance =>" + Thread.CurrentThread.ManagedThreadId);
            return Instance;
        }
        private DBConnection()
        {

        }

        static DBConnection()
        {
            obj = new object();
        }
    }
    #endregion

    #region property base
    public class FileConnection
    {
        private static FileConnection _instance;

        public static  FileConnection Instance => _instance is null ? _instance = new() : _instance;
      
        private FileConnection()
        {

        }

        static FileConnection()
        {
            _instance = new FileConnection();
        }
    }
    #endregion
}
