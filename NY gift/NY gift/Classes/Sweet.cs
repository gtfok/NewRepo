using NY_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_gift.Classes
{
    public abstract class Sweet : ISweetness
    {
        public double SugarPerUnit { get; }
        public string Name { get; }
        public double Calories { get; }
        public string TypeOfSweetness { get; }
        public double Weight { get; }
        public string ItemInfo { get; }

       

        public Sweet(string name, double weight, string item, double sugar, double calories, string typeOfSweetness)
        {
            Name = name;
            Weight = weight;
            ItemInfo = item;
            TypeOfSweetness = typeOfSweetness;
            SugarPerUnit = sugar;
            Calories = calories;
        }

    }
}
