using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using WinFormsApp1.businessModel;

namespace WinFormsApp1.businessService
{
    static class StarSerializer
    {
        public static string Serialize(Star star)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(star,options);
        }
        public static Star Deserialize(string str)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Deserialize<Star>(str, options)!;
        }
    }
}
