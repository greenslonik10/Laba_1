using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    public class MobilePhone
    {
        private string brand;

        private float price;

        private float memory;

        public MobilePhone(string brand, float price, float memory)
        {
            this.brand = brand;
            this.price = price;
            this.memory = memory;
        }

        public virtual float Q()
        {
            return memory / price;
        }

        public virtual string ToString()
        {
            return "Фирма: " + brand + Environment.NewLine + 
                "Цена: " + price + Environment.NewLine + 
                "Объем памяти: " + memory;
        }

        public string Brand { get { return brand; } set { brand = value; } }
        public float Price { get { return price; } set { price = value; } }
        public float Memory { get { return memory; } set { memory = value; } }

    }
}
