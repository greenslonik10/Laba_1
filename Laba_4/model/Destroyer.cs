using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShip.model
{
    class Destroyer : MilitaryShip
    {
        // количество ракет в ЗРК
        private int salvoMissileCount;
        // количество ракет на борту
        private int missileCount;
        // вес одной ракеты
        private int missileWeight;

        public int SalvoMissileCount { get { return salvoMissileCount; } set { salvoMissileCount = value; } }
        public int MissileCount { get { return missileCount; } set { missileCount = value; } }
        public int MissileWeight { get { return missileWeight; } set { missileWeight = value; } }

        public Destroyer()
        {
            this.salvoMissileCount = 0;
            this.missileCount = 0;
            this.missileWeight = 0;
        }

        // сделать залп
        public bool TrySalvo()
        {
            if ((missileCount > 0) && (missileCount >= salvoMissileCount))
            {
                missileCount -= salvoMissileCount;
                Loading -= (salvoMissileCount * missileWeight);
                return true;
            }
            return false;
        }

        // перезарядить
        public bool TryReloadSalvo()
        {
            if (TryLoad(salvoMissileCount * missileWeight))
            {
                missileCount++;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Количество ракет в залпе: " +salvoMissileCount + Environment.NewLine +
                "Количество ракет на борту: " + missileCount + Environment.NewLine +
                "Вес ракеты: " + missileWeight;
        }
    }
}
