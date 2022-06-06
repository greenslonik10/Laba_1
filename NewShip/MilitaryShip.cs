using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShip.model
{
    public abstract class MilitaryShip : IShip
    {
        // текущая загрузка
        private int loading;
        // максимальная загрузка
        private int maxLoading;
        // название
        private string name;
        // количество орудий
        private int weaponCount;
        // вес одного снаряда
        private int projectileWeight;
        public int Loading { get { return loading; } set { loading = value; } }
        public int MaxLoading { get { return maxLoading; } set { maxLoading = value; } }
        public int WeaponCount { get { return weaponCount; } set { weaponCount = value; } }
        public int ProjectileWeight { get { return projectileWeight; } set { projectileWeight = value; } }
        public string Name { get { return name; } set { name = value; } }
        public MilitaryShip()
        {
            this.name = "";
            this.maxLoading = 0;
            this.weaponCount = 0;
            this.projectileWeight = 0;
            this.loading = 0;
        }

        // перезарядить все орудия
        public bool TryReload()
        {
            return TryLoad(projectileWeight * weaponCount);
        }

        // атаковать из всех орудий
        public bool TryAtack()
        {
            return TryUnload(projectileWeight * weaponCount);
        }

        public bool TryLoad(int weight)
        {
            if (loading + weight > maxLoading)
                return false;
            else
            {
                loading += weight;
                return true;
            }
        }

        public bool TryUnload(int weight)
        {
            if (loading - weight < 0)
                return false;
            else
            {
                loading -= weight;
                return true;
            }
        }

        public override string ToString()
        {
            return "Название: " + name + Environment.NewLine + 
                "Текущая загрузка: " + loading + Environment.NewLine +
                "Максимальная загрузка: " + maxLoading + Environment.NewLine +
                "Количество орудий: " + weaponCount + Environment.NewLine +
                "Вес снаряда: " + projectileWeight;
        }
    }
}
