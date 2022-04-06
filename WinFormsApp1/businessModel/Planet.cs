using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.businessModel
{
    public class Planet : SpaceObject
    {
        private bool isInhabited;
        private bool hasAtmosphere;
        private List<Moon> moons;
        public bool IsInhabited { get { return isInhabited; } set { isInhabited = value; } }
        public bool HasAtmosphere { get { return hasAtmosphere; } set { hasAtmosphere = value; } }
        public List<Moon> Moons { get { return moons; } set { moons = value; } }
        public Planet() : base()
        {
            isInhabited = false;
            hasAtmosphere = false;
            moons = new List<Moon>();
        }
    }
}
