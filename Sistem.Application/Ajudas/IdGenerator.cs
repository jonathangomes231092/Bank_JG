using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Ajudas
{
    public class IdGenerator
    {

        private static int _currentId = 0;
        private static object _lock = new object();

        public static int GenerateNewId()
        {
            lock (_lock)
            {
                _currentId++;
                return _currentId;
            }
        }
    }
}

