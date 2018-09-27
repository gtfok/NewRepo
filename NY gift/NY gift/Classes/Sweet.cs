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
        private double sugar;

        public double SugarPerUnit { get; }
        public string Name { get; }
        public double Calories { get; }
        public double Weight { get; }
        public Sweet(string name, double weight,  double sugar, double calories)
        {
            Name = name;
            Weight = weight;
            SugarPerUnit = sugar;
            Calories = calories;
        }

        public abstract string TypeOfSweetness { get; }
    public abstract string ItemInfo { get; }
    }
}
