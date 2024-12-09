using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_mccluneyz
{
    public class kart
    {
        private int kartID;
        private string kartName;

        private string kartSize;

        private bool isAvaliable = true;

        static private int count;

        private bool isDeleted = false;

        public kart()
        {

        }
        public kart(int kartID, string kartName, string kartSize, bool isAvaliable, bool isDeleted)
        {
            this.kartID = kartID;
            this.kartName = kartName;
            this.kartSize = kartSize;
            this.isAvaliable = isAvaliable;
            this.isDeleted = isDeleted;
        }

        static public void SetKartName(string kartName)
        {

            kartName = kartName;

        }

        public string GetKartName()
        {
            return kartName;
        }

        public void SetKartID(int kartID)
        {

            this.kartID = kartID;
        }
        public int GetKartID()
        {
            return kartID;
        }


        public void SetKartSize(string kartSize)
        {

            this.kartSize = kartSize;
        }
        public string GetKartSize()
        {
            return kartSize;
        }
        public void ToggleAvaliability()
        {
            isAvaliable = !isAvaliable;

        }
        public void ToggleDeleted(){

            isDeleted = !isDeleted;
        }
        static public void SetCount(int count)
        {
            kart.count = count;
        }
        static public int GetCount()
        {
            return count;
        }
        static public void IncCount()
        {
            count++;
        }

        public void NotAvaiable()
        {
            isAvaliable = !isAvaliable;
        }
        
        public override string ToString()
        {
            return $"{kartID}\t{kartName}\t{kartSize}\t{isAvaliable}";
        }
        public string ToFile()
        {
            return $"{kartID}#{kartName}#{kartSize}{isAvaliable}";
        }

    }
}