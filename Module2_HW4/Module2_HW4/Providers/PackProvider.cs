using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW4
{
    internal class PackProvider
    {
        internal static void PrintPackInfo(Pack pack)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMammals in pack:\nName: Weight: Speed: MovementType:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Mammal mammal in pack.ReturnPackMammals())
            {
                Console.WriteLine(mammal.Name + " " + mammal.Weight + " " + mammal.Speed + " " + mammal.MovementType);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total weight of animals in pack: " + pack.ReturnPackWeight());
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void SortPackAnimalsWeightAsc(Pack pack)
        {
            Mammal[] mammals = new Mammal[pack.ReturnPackMammals().Length];
            Mammal[] mammalsFilled = pack.ReturnPackMammals();
            int[] mammalsWeights = new int[pack.ReturnPackMammals().Length];
            for (int i = 0; i < mammalsFilled.Length; i++)
            {
                mammalsWeights[i] = mammalsFilled[i].Weight;
            }

            int len = mammalsFilled.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (mammalsWeights[j] > mammalsWeights[j + 1])
                    {
                        Swap<int>(ref mammalsWeights[j], ref mammalsWeights[j + 1]);
                        Swap<Mammal>(ref mammalsFilled[j], ref mammalsFilled[j + 1]);
                    }
                }
            }

            pack.SetPackMammals(mammalsFilled);
        }

        // To swap items while sorting
        internal static void Swap<T>(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
