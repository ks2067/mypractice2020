using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton _singleton = Singleton.GetSingleton;
            //Console.WriteLine("Counter value : " + Singleton.counter);

            Singleton _singleton1 = Singleton.GetSingleton;
            //Console.WriteLine("Counter value : " + Singleton.counter);
            Console.ReadLine();
        }
    }
}
