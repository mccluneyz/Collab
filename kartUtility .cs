using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_mccluneyz
{
    public class kartUtility
    {

            kart[]Karts;
            kartFileHandler kartfilehandler;
        public kartUtility()
        {
           kartfilehandler= kartFileHandler.GetKarts();
                   
         }

        public void AddAKart()
        {

            StreamReader inFile = new StreamReader("kart-inventory.txt");
            string line = inFile.ReadLine();

            StreamWriter outFIle = new StreamWriter("kart-inventory.txt");
                    kart.IncCount();
                int count = kart.GetCount();

            while (line != null)
            {

                System.Console.WriteLine("What's the name of the kart?");
                string kartName = Console.ReadLine();
                System.Console.WriteLine("What's the kart size?");
                string kartSize = Console.ReadLine();
                System.Console.WriteLine("Is the kart avaiable to use??");
                bool avaiable = true;
                kart kart = new kart(count, kartName, kartSize, true,false);
                kartFileHandler.Karts[kart.GetCount()] = kart;

                 outFIle.WriteLine(kart);
                 line = inFile.ReadLine();

            }
            
        }
        public void KartSort()
        {

            for (int i = 0; i < kart.GetCount() - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < kart.GetCount(); j++)
                {
                    if (Karts[j].GetKartID() < Karts[i].GetKartID() )
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Swap(min, i);
                }
            }

        }

        public void Swap(int x, int y)
        {
            kart temp = Karts[x];
            Karts[x] = Karts[y];
            Karts[y] = temp;
        }
        public void RemoveKart()
        {

        }

        public void EditKart()
        {
            StreamReader inFile = new StreamReader("kart-inventory.txt");
            string line = inFile.ReadLine();

            StreamWriter outFIle = new StreamWriter("kart-inventory.txt");
                    kart.IncCount();
                int count = kart.GetCount();

            while (line != null)
            {

                System.Console.WriteLine("What's the name of the kart?");
                string kartName = Console.ReadLine();
                System.Console.WriteLine("What's the kart size?");
                string kartSize = Console.ReadLine();
                System.Console.WriteLine("Is the kart avaiable to use??");
                bool avaiable = true;
                kart kart = new kart(count, kartName, kartSize, true,false);
                kartFileHandler.Karts[kart.GetCount()] = kart;

                 outFIle.WriteLine(kart);
                 line = inFile.ReadLine();
        }
    }
}