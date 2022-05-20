using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.businessModel
{
    public class Star : SpaceObject
    {
        private int temperature;
        private long age;
        private List<Planet> planets;
        public int Temperature { get { return temperature; } set { temperature = value; } }
        public long Age { get { return age; } set { age = value; } }
        public List<Planet> Planets { get { return planets; } set { planets = value; } }
        public Star() : base()
        {
            temperature = 0;
            age = 0;
            planets = new List<Planet>();
        }   
    }
}
