using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SingletonPattern
{
      internal sealed class Singleton
    {
        private Singleton()
        {

        }

        static Singleton instance = null;

        public static Singleton Nesne()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    class A
    {
        public int a = 0;

        public A()
        {
            a++;
        }
        public override string ToString()
        {
            Console.WriteLine(a);
            return "";
        }
    }
    
}
