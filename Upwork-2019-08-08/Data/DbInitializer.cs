using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork_2019_08_08.Data
{
    public class DbInitializer
    {
        public static void Initialize(SystemContext context)
        {

            if (context.ClientUsers.Any())
            {
                return;   // DB has been seeded
            }
        }
    }
}
