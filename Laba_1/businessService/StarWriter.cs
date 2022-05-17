using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.businessModel;

namespace WinFormsApp1.businessService
{
    static class StarWriter
    {
        public static string Write(Moon moon)
        {
            return "\t\tНазвание: " + moon.Name + Environment.NewLine
                + "\t\tВес: " + moon.Weight + Environment.NewLine
                + "\t\tПлотность: " + moon.Density + Environment.NewLine
                + "\t\tРадиус орбиты: " + moon.OrbitRadius + Environment.NewLine;
        }

        public static string Write(Planet planet)
        {
            string res = "\tНазвание: " + planet.Name + Environment.NewLine
                   + "\tВес: " + planet.Weight + Environment.NewLine
                   + "\tНаселена: " + (planet.IsInhabited ? "да" : "нет") + Environment.NewLine
                   + "\tАтмосфера: " + (planet.HasAtmosphere ? "есть" : "нет") + Environment.NewLine;
            int i = 1;
            foreach (Moon moon in planet.Moons)
            {
                res += "\tЛуна " + (i++) + Environment.NewLine;
                res += Write(moon);
            }
            return res;
        }

        public static string Write(Star s)
        {
            string res = "Название: " + s.Name + Environment.NewLine
                + "Вес: " + s.Weight + Environment.NewLine
                + "Температура: " + s.Temperature + Environment.NewLine
                + "Возраст: " + s.Age + Environment.NewLine;
            int i = 1;
            foreach (Planet planet in s.Planets)
            {
                res += "Планета " + (i++) + Environment.NewLine;
                res += Write(planet);
            }
            return res;
        }
    }
}
