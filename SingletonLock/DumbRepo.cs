using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLock
{
    public class DumbRepo
    {
        private static DumbRepo _repo;

        private static object LockObject = new object();

        private static int CallCounter;

        public static DumbRepo Instance
        {
            get
            {
                lock (LockObject)
                {
                    if (_repo == null)
                    {
                        _repo = new DumbRepo();
                        CallCounter = 1;
                        Console.WriteLine(CallCounter + " : " + nameof(DumbRepo) + " object is created.");
                    }
                    Console.WriteLine(CallCounter + " : " + "An existing " + nameof(DumbRepo) + " object is send.");
                    Console.WriteLine();
                    CallCounter += 1;
                    return _repo;
                }
            }
        }

    }
}
