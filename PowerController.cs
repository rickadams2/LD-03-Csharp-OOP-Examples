using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
    class PowerController : IPowerOn
    {
        public bool IsOn { get; private set; }

        protected void TurnOn()
        {
            IsOn = true;
        }

        protected void TurnOff()
        {
            IsOn = false;
        }

        public virtual void TogglePower()
        {
            if (IsOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }

    }
}
