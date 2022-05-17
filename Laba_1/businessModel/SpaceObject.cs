using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.businessModel
{
    public class SpaceObject
    {
        private string name;
        private float weight;
        public string Name { get { return name; } set { name = value; } }
        public float Weight { get { return weight; } set { weight = value; } }
        public SpaceObject()
        {
            name = "";
            weight = 0;
        }
    }
}
