using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    public class MobilePhoneSIM : MobilePhone
    {
        private int numberOfSIM;

        public MobilePhoneSIM(string brand, float price, float memory, int numberOfSIM)
            : base(brand, price, memory)
        {
            this.numberOfSIM = numberOfSIM;
        }

        public override float Q()
        {
            return base.Q() * numberOfSIM;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                "Количество SIM-карт: " + numberOfSIM;
        }

        public int NumberOfSIM { get { return numberOfSIM; } set { numberOfSIM = value; } }
    }
}
