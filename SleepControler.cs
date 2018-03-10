using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
    class SleepControler : ISleep
    {
        public bool IsSleeping { get; private set; }

        public void ToggleSleep()
        {
            IsSleeping = !IsSleeping; 
        }

    }
}
