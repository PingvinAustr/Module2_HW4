using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    public static class Starter
    {
        public static void Run()
        {
            Mammal mammal = new Mammal("Mammal1", 500, 100, MovementType.MovementOption.Fly);
            HorseGeneral horseGeneral = new HorseGeneral("HorseGeneral2", 400, 200, MovementType.MovementOption.Walk, 14);
            HorseDefault horseDefault = new HorseDefault("HorseDefault3", 300, 300, MovementType.MovementOption.Walk, 15, false);
            WorkHorse workHorse = new WorkHorse("workHorse4", 200, 400, MovementType.MovementOption.Walk, 16, true);
            RaceHorse raceHorse = new RaceHorse("raceHorse5", 100, 500, MovementType.MovementOption.Walk, 17, true);
            Mammal[] mammalsToPack = new Mammal[5] { mammal, horseGeneral, horseDefault, workHorse, raceHorse };

            Pack pack = new Pack(mammalsToPack);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pack has been created");
            Console.ForegroundColor = ConsoleColor.White;
            PackProvider.PrintPackInfo(pack);

            // Sorting pack animals per weight ascending
            PackProvider.SortPackAnimalsWeightAsc(pack);
            Console.WriteLine("\n\n-------------------------------------------------\nPack animals have been sorted per weight ascending:");
            PackProvider.PrintPackInfo(pack);

            // Search using extension methods
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n-------------------------------------------------\nThe slowest animal from current pack:");
            Console.ForegroundColor = ConsoleColor.White;
            Mammal slowestMammal = pack.FindPackSlowestAnimal(pack.ReturnPackMammals());
            Console.WriteLine(slowestMammal.Name + " " + slowestMammal.Weight + " " + slowestMammal.Speed + " " + slowestMammal.MovementType);
        }
    }
}
