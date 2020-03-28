using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UsingProgramTest2 : IDisposable
    {
        public void UseLimitedResource()
        {
            Console.WriteLine("Using limited resource......");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("Disposing limited resource");
        }
    }

}
