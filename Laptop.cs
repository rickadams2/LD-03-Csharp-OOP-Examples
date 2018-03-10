using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_03_Csharp_OOP_Examples
{
    class Laptop : Computer, ISleep 
    {
        public ISleep sleepController; 
        public Display Display { get; private set; }

        public bool IsSleeping
        {

            get
            {
                return sleepController.IsSleeping;
            }
        } 


        public Laptop(string name, int width, int heigth) : base(name)
        {
            Display = new Display(width, heigth);
            sleepController = new SleepControler(); 
        }

        public void ToggleSleep()
        {

            sleepController.ToggleSleep(); 
        }
    }
}
