using System;
using System.Threading.Tasks;

namespace SingletonLock
{
    class Program
    {
        delegate void AsyncHandler();

        static void Main(string[] args)
        {
            AsyncHandler method = () => {
                var repo = DumbRepo.Instance; // Instantiate or call DumbRepo object;
            };
            
            Task.Run(() => { method(); }); // Call 1;
            Task.Run(() => { method(); }); // Call 2;
            Task.Run(() => { method(); }); // Call 3;
            Task.Run(() => { method(); }); // Call 4;
            Task.Run(() => { method(); }); // Call 5;
            Task.Run(() => { method(); }); // Call 6;

            Console.Read();
        }
    }
}
