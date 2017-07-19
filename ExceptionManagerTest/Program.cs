using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ExceptionManager.Exceptions;

namespace ExceptionManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExceptionManager.ExceptionManager().Initalize();
            throw new BusinessException("Fırlattım yakala");
        }
    }
}
