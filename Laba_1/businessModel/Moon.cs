using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.businessModel
{
    public class Moon : SpaceObject
    {     
        private float density;
        private float orbitRadius;
        public float Density { get { return density; } set { density = value; } }
        public float OrbitRadius { get { return orbitRadius; } set { orbitRadius = value; } }
        public Moon() : base()
        {
            density = 0;
            orbitRadius = 0;
        }
    }
}
