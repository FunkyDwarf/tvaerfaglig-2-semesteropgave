using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    public class StoreSingelton
    {
        private static object syncLock = new object();
        static private Store _instance;

        private StoreSingelton()
        {
        }

        static public Store GetStoreInstance()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Store();
                    }
                }
            }

            return _instance;
        }
    }
}