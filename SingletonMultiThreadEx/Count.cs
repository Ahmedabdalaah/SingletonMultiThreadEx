using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMultiThreadEx
{
    internal class Count
    {
        private static Count instance= null;
        private static Object locker = new object();
        public  int Couunt=0;
        private Count()
        {   
        }
        public static Count getInstance()
        {
            if(instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Count();
                    }
                }
            }
            return instance;
        }
        public void increment ()
        {
            Couunt++;
        }
    }
}
