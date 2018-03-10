using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
 abstract class Computer
    {
        protected string _name = "unknown";
        public bool IsOn { get; private set;  }
        public virtual string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public Computer(string name)
        {
            this.Name = name;
        }
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

            // end of line 
    }
    }