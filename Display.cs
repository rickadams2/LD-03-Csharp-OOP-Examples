using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
    class Display
    {
        public int With { get; private set;  }
        public int Heigth { get; private set; }


        public Display(int width, int height)
        {
            this.With = width;
            this.Heigth = Heigth; 
        }

    }
}
