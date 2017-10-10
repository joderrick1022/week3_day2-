using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day2
{
    class Cell_Phone
    {
        private string ringTone;
        public Double usage;
        private int storage;



        public string RingTone
        {
            get { return this.ringTone; }
            set { this.ringTone = value; }
        }

        public int Storage
        {
            get { return this.storage; }
            set { this.storage = value; }
        }

        public Cell_Phone()
        {

        }

        public Cell_Phone(string ringTone,double usage,int storage)
        {
            this.ringTone = ringTone;
            this.usage = usage;
            this.storage = storage;
        }

        public void Ring()
        {
            Console.WriteLine("\a\a\a");
        }


            
    }


}
