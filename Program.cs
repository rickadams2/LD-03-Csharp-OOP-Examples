using LD_03_Csharp_OOP_Examples;
using System;

class Program
    {
        static void Main(string[] args)
        {

      // var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);

        var comp = new Laptop("Generic Laptop", 1024, 768);
        
        Console.WriteLine("Computer type - " + comp.GetType());

        var IsComputer = comp is Computer;
    
        Console.WriteLine("Is computer - " + IsComputer);
        Console.WriteLine("Computer name - " + comp.Name);
       // Console.WriteLine("Computer case - " + comp.caseType);

        comp.TogglePower(); 
        Console.WriteLine("Computer is on - " + comp.IsOn);



        if (comp is ISleep sleepingComp)
        {
            sleepingComp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + sleepingComp.IsSleeping);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.IsOn);

        }



        Console.Read(); 
            
    }

}
