using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public static class DBConnectionString
    {
        public static string ConnectionString => Environment.GetEnvironmentVariable("CONNECTION_STRING");

    }
}
