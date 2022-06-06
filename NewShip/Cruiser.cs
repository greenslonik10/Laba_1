using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShip.model
{
    class Cruiser : MilitaryShip
    {
        // количество торпед на борту
        private int torpedoCount;
        // вес одной торпеды
        private int torpedoWeight;

        public int TorpedoCount { get { return torpedoCount; } set { torpedoCount = value; } }
        public int TorpedoWeight { get { return torpedoWeight; } set { torpedoWeight = value; } }

        public Cruiser()
        {
            this.torpedoCount = 0;
            this.torpedoWeight = 0;
        }

        // запустить торпеду
        public bool TryLaunchTorpedo()
        {
            if (torpedoCount > 0)
            {
                torpedoCount--;
                Loading -= torpedoWeight;
                return true;
            }
            return false;
        }

        // загрузить торпеду
        public bool TryLoadTorpedo()
        {
            if (TryLoad(torpedoWeight))
            {
                torpedoCount++;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Количество торпед: " + torpedoCount + Environment.NewLine +
                "Вес торпеды: " + torpedoWeight;
        }
    }
}
