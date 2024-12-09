using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_mccluneyz
{
    public class kartFileHandler
    {

    private string fileName;
    public kart[] Karts;
        public kartFileHandler(kart[] Karts, string fileName){
            this.Karts = Karts;
            fileName = "kart-inventory.txt";
        }

        public void GetAllKarts(){
            kart.SetCount(0);

            StreamReader infile = new StreamReader("kart-inventory.txt");
            string line = infile.ReadLine();

            while (line != null)
            {
                string[] temp = line.Split("#");
                Karts[kart.GetCount()] = new kart(int.Parse(temp[0]), temp[1], temp[2],bool.Parse(temp[3]), bool.Parse(temp[4]));
                line =infile.ReadLine();

                kart.IncCount();
            }
            infile.Close();
        }
        public kart[] GetKarts(){
            return Karts;
        }
    }


}