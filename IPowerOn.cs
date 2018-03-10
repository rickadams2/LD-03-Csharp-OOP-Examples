using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
    interface IPowerOn
    {
        bool  IsOn { get; }
        void TogglePower(); 
    }
}
