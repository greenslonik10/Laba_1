using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShip.model
{
    // авианосец
    public class Aerocarrier : MilitaryShip
    {
        // количество самолетов на борту
        private int jetCount;
        // вес одного самолета
        private int jetWeight;

        public int JetCount { get { return jetCount; } set { jetCount = value; } }

        public int JetWeight { get { return jetWeight; } set { jetWeight = value;} }

        public Aerocarrier(string name, int maxLoading, int weaponCount, int projectileWeight, int jetWeight) : base(name, maxLoading, weaponCount, projectileWeight)
        {
            this.jetWeight = jetWeight;
            this.jetCount = 0;
        }

        // запустить один самолет
        public bool TryStartJet()
        {
            if (jetCount > 0)
            {
                jetCount--;
                Loading -= jetWeight;
                return true;
            }
            return false;
        }

        // посадить один самолет
        public bool TryLandJat()
        {
            if (TryLoad(jetWeight))
            {
                jetCount++;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Количество самолетов: " + jetCount + Environment.NewLine +
                "Вес самолета: " + jetWeight;
        }
    }
}
