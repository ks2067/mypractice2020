using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    public sealed class Singleton
    {
        private static Singleton _singleton = null;
        private Singleton()
        {
        }
        public static Singleton GetSingleton
        {
            get
            { 
                if(_singleton == null)
                    _singleton= new Singleton();
                return _singleton;
            }
        }
    }
   

}
